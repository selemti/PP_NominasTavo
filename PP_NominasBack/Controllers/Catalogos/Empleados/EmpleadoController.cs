using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using PP_NominasBack.Dtos.Catalogos.Asistencia;
using PP_NominasBack.Dtos.Catalogos.Empleados;
using PP_NominasBack.Dtos.Catalogos.Organización;
using PP_NominasBack.Dtos.Catalogos.Shared;
using PP_NominasBack.Models.Catalogos.Asistencia;
using PP_NominasBack.Models.Catalogos.Empleados;
using PP_NominasBack.Models.Catalogos.Shared;
using PP_NominasBack.Services.Utileria;

namespace PP_NominasBack.Controllers.Catalogos.Empleados
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly IMongoDatabase _db;
        private readonly IMapper _mapper;
        private readonly SecuenciaService _secuenciaService;

        public EmpleadoController(IMongoDatabase db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _secuenciaService = new SecuenciaService(db);
        }

        // GET: api/Empleado
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpleadoDto>>> GetAll()
        {
            var empleados = await _db.GetCollection<Empleado>("Empleados").Find(_ => true).ToListAsync();
            return Ok(_mapper.Map<IEnumerable<EmpleadoDto>>(empleados));
        }

        // GET: api/Empleado/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpleadoDto>> GetById(string id)
        {
            var empleado = await _db.GetCollection<Empleado>("Empleados").Find(x => x.Id == id).FirstOrDefaultAsync();
            if (empleado == null) return NotFound();
            return Ok(_mapper.Map<EmpleadoDto>(empleado));
        }

        // POST: api/Empleado
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmpleadoCreacionDto dto)
        {
            if (dto.Persona == null)
                return BadRequest("La información de la persona es obligatoria.");

            string personaId = dto.Persona.Id ?? ObjectId.GenerateNewId().ToString();
            dto.Persona.Id = personaId;

            var empleadoExistente = await _db.GetCollection<Empleado>("Empleados")
                .Find(e => e.Persona == personaId)
                .FirstOrDefaultAsync();

            if (empleadoExistente != null && empleadoExistente.EstatusEmpleado != EstatusEmpleadoEnum.Baja)
                return Conflict("La persona ya está registrada como empleado activo.");

            string nuevoEmpleadoId = ObjectId.GenerateNewId().ToString();
            dto.NumeroEmpleado ??= await _secuenciaService.ObtenerSiguienteNumeroEmpleadoAsync();

            dto.Persona.Direccion.Id ??= ObjectId.GenerateNewId().ToString();
            dto.Persona.Direccion.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;

            dto.Persona.Telefonos?.ForEach(t =>
            {
                t.Id ??= ObjectId.GenerateNewId().ToString();
                t.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;
            });

            var persona = _mapper.Map<Persona>(dto.Persona);
            await _db.GetCollection<Persona>("Persona").InsertOneAsync(persona);

            // Inicializar listas y variables
            string? datosPagoId = null;
            string? asignacionId = null;
            var asignacionHistorialIds = new List<string>();
            var horarioIds = new List<string>();
            var registroImssIds = new List<string>();
            var ubicacionIds = new List<string>();
            var documentos = new List<DocumentoEmpleado>();
            var contactos = new List<ContactoEmergencia>();

            // Datos de pago
            if (dto.DatosPago != null)
            {
                dto.DatosPago.Id ??= ObjectId.GenerateNewId().ToString();
                dto.DatosPago.EmpleadoId = nuevoEmpleadoId;
                dto.DatosPago.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;

                dto.DatosPago.Id ??= ObjectId.GenerateNewId().ToString();
                dto.DatosPago.EmpleadoId = nuevoEmpleadoId;
                dto.DatosPago.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;

                var datos = _mapper.Map<DatosPagoEmpleado>(dto.DatosPago);
                await _db.GetCollection<DatosPagoEmpleado>("DatosPagoEmpleado").InsertOneAsync(datos);
                datosPagoId = datos.Id;
            }

            // Asignaciones
            if (dto.Asignaciones?.Any() == true)
            {
                foreach (var a in dto.Asignaciones)
                {
                    a.Id ??= ObjectId.GenerateNewId().ToString();
                    a.EmpleadoId = nuevoEmpleadoId;
                    a.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;
                    asignacionHistorialIds.Add(a.Id);
                }

                var asignaciones = dto.Asignaciones
    .Select(dtoAsignacion =>
    {
        var model = _mapper.Map<AsignacionPlazaEmpleado>(dtoAsignacion);
        return model;
    })
    .ToList();

                await _db.GetCollection<AsignacionPlazaEmpleado>("AsignacionPlazaEmpleado")
                    .InsertManyAsync(asignaciones);

                asignacionId = dto.Asignaciones.Last().Id;
            }

            // Horarios
            if (dto.Horarios?.Any() == true)
            {
                foreach (var h in dto.Horarios)
                {
                    h.Id ??= ObjectId.GenerateNewId().ToString();
                    h.EmpleadoId = nuevoEmpleadoId;
                    h.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;
                    horarioIds.Add(h.Id);
                }

                await _db.GetCollection<HorarioEmpleado>("HorarioEmpleado")
                    .InsertManyAsync(_mapper.Map<List<HorarioEmpleado>>(dto.Horarios));
            }

            // Registros IMSS
            if (dto.RegistrosImss?.Any() == true)
            {
                foreach (var r in dto.RegistrosImss)
                {
                    r.Id ??= ObjectId.GenerateNewId().ToString();
                    r.EmpleadoId = nuevoEmpleadoId;
                    r.Nss = dto.Nss;
                    r.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;
                    registroImssIds.Add(r.Id);
                }

                await _db.GetCollection<RegistroImss>("RegistroImss")
                    .InsertManyAsync(_mapper.Map<List<RegistroImss>>(dto.RegistrosImss));
            }

            // Ubicaciones
            if (dto.HistorialUbicaciones?.Any() == true)
            {
                foreach (var u in dto.HistorialUbicaciones)
                {
                    u.Id ??= ObjectId.GenerateNewId().ToString();
                    u.EmpleadoId = nuevoEmpleadoId;
                    u.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;
                    ubicacionIds.Add(u.Id);
                }

                await _db.GetCollection<UbicacionEmpleado>("UbicacionEmpleado")
                    .InsertManyAsync(_mapper.Map<List<UbicacionEmpleado>>(dto.HistorialUbicaciones));
            }

            // Documentos
            if (dto.Documentos?.Any() == true)
            {
                foreach (var d in dto.Documentos)
                {
                    d.Id ??= ObjectId.GenerateNewId().ToString();
                    d.EmpleadoId = nuevoEmpleadoId;
                    d.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;

                    documentos.Add(_mapper.Map<DocumentoEmpleado>(d));
                }

                await _db.GetCollection<DocumentoEmpleado>("DocumentoEmpleado")
                    .InsertManyAsync(documentos);
            }

            // Contactos emergencia
            if (dto.ContactosEmergencia?.Any() == true)
            {
                foreach (var c in dto.ContactosEmergencia)
                {
                    c.Id ??= ObjectId.GenerateNewId().ToString();
                    c.EmpleadoId = nuevoEmpleadoId;
                    c.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;

                    contactos.Add(_mapper.Map<ContactoEmergencia>(c));
                }

                await _db.GetCollection<ContactoEmergencia>("ContactoEmergencia")
                    .InsertManyAsync(contactos);
            }

            // Crear objeto final Empleado
            var empleado = new Empleado
            {
                Id = nuevoEmpleadoId,
                NumeroEmpleado = dto.NumeroEmpleado,
                Persona = persona.Id,
                Nss = dto.Nss,
                FechaIngreso = dto.FechaIngreso,
                TipoContrato = (TipoContratoEnum)dto.TipoContrato!,
                TipoHorario = (TipoHorarioEnum)dto.TipoHorario!,
                EstatusEmpleado = (EstatusEmpleadoEnum)dto.EstatusEmpleado!,
                DatosPagoId = datosPagoId,
                AsignacionId = asignacionId,
                AsignacionHistorialIds = asignacionHistorialIds,
                RegistroImssIds = registroImssIds,
                HorarioIds = horarioIds,
                HistorialUbicacionIds = ubicacionIds,
                Documentos = documentos,
                ContactosEmergencia = contactos,
                CorreoCorporativo = dto.CorreoCorporativo,
                UsuarioRed = dto.UsuarioRed,
                IdBiometrico = dto.IdBiometrico,
                FotoPerfilUrl = dto.FotoPerfilUrl,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };

            await _db.GetCollection<Empleado>("Empleados").InsertOneAsync(empleado);
            return CreatedAtAction(nameof(Post), new { id = empleado.Id }, new { empleado.Id });
        }

        // PUT: api/Empleado/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] EmpleadoCreacionDto dto)
        {
            var empleado = await _db.GetCollection<Empleado>("Empleados")
                .Find(e => e.Id == id)
                .FirstOrDefaultAsync();

            if (empleado == null)
                return NotFound("Empleado no encontrado.");

            string? datosPagoId = null;
            string? asignacionId = null;
            var asignacionHistorialIds = new List<string>();
            var horarioIds = new List<string>();
            var registroImssIds = new List<string>();
            var ubicacionIds = new List<string>();
            var documentos = new List<DocumentoEmpleado>();
            var contactos = new List<ContactoEmergencia>();

            // 🧍 Persona
            if (dto.Persona != null)
            {
                dto.Persona.Id ??= empleado.Persona;
                dto.Persona.Direccion ??= new DireccionDto();
                dto.Persona.Direccion.Id ??= ObjectId.GenerateNewId().ToString();
                dto.Persona.Direccion.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;

                dto.Persona.Telefonos?.ForEach(t =>
                {
                    t.Id ??= ObjectId.GenerateNewId().ToString();
                    t.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;
                });

                var persona = _mapper.Map<Persona>(dto.Persona);
                await _db.GetCollection<Persona>("Persona")
                    .ReplaceOneAsync(p => p.Id == dto.Persona.Id, persona, new ReplaceOptions { IsUpsert = true });
            }

            // 💰 Datos de pago
            if (dto.DatosPago != null)
            {
                dto.DatosPago.Id ??= ObjectId.GenerateNewId().ToString();
                dto.DatosPago.EmpleadoId = empleado.Id;
                dto.DatosPago.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;

                var pago = _mapper.Map<DatosPagoEmpleado>(dto.DatosPago);
                var filtro = Builders<DatosPagoEmpleado>.Filter.Eq(x => x.EmpleadoId, empleado.Id);

                await MongoHelper.ReplaceOneOrInsertAsync(
                    _db.GetCollection<DatosPagoEmpleado>("DatosPagoEmpleado"),
                    filtro,
                    pago
                );

                datosPagoId = pago.Id;
            }

            // 🏢 Asignaciones
            if (dto.Asignaciones?.Any() == true)
            {
                foreach (var asignacionDto in dto.Asignaciones)
                {
                    asignacionDto.Id ??= ObjectId.GenerateNewId().ToString();
                    asignacionDto.EmpleadoId = empleado.Id;
                    asignacionDto.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;
                    asignacionHistorialIds.Add(asignacionDto.Id);
                }

                var asignaciones = dto.Asignaciones
                    .Select(a => _mapper.Map<AsignacionPlazaEmpleado>(a))
                    .ToList();

                await _db.GetCollection<AsignacionPlazaEmpleado>("AsignacionPlazaEmpleado")
                    .InsertManyAsync(asignaciones);

                asignacionId = dto.Asignaciones.Last().Id;
            }

            // ⏰ Horarios
            if (dto.Horarios?.Any() == true)
            {
                foreach (var h in dto.Horarios)
                {
                    h.Id ??= ObjectId.GenerateNewId().ToString();
                    h.EmpleadoId = empleado.Id;
                    h.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;
                    horarioIds.Add(h.Id);
                }

                await _db.GetCollection<HorarioEmpleado>("HorarioEmpleado")
                    .InsertManyAsync(_mapper.Map<List<HorarioEmpleado>>(dto.Horarios));
            }

            // 🛡️ Registro IMSS
            if (dto.RegistrosImss?.Any() == true)
            {
                foreach (var r in dto.RegistrosImss)
                {
                    r.Id ??= ObjectId.GenerateNewId().ToString();
                    r.EmpleadoId = empleado.Id;
                    r.Nss = dto.Nss;
                    r.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;
                    registroImssIds.Add(r.Id);
                }

                await _db.GetCollection<RegistroImss>("RegistroImss")
                    .InsertManyAsync(_mapper.Map<List<RegistroImss>>(dto.RegistrosImss));
            }

            // 📍 Ubicaciones
            if (dto.HistorialUbicaciones?.Any() == true)
            {
                foreach (var u in dto.HistorialUbicaciones)
                {
                    u.Id ??= ObjectId.GenerateNewId().ToString();
                    u.EmpleadoId = empleado.Id;
                    u.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;
                    ubicacionIds.Add(u.Id);
                }

                await _db.GetCollection<UbicacionEmpleado>("UbicacionEmpleado")
                    .InsertManyAsync(_mapper.Map<List<UbicacionEmpleado>>(dto.HistorialUbicaciones));
            }

            // 📄 Documentos
            if (dto.Documentos?.Any() == true)
            {
                foreach (var d in dto.Documentos)
                {
                    d.Id ??= ObjectId.GenerateNewId().ToString();
                    d.EmpleadoId = empleado.Id;
                    d.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;

                    documentos.Add(_mapper.Map<DocumentoEmpleado>(d));
                }

                await _db.GetCollection<DocumentoEmpleado>("DocumentoEmpleado")
                    .InsertManyAsync(documentos);
            }

            // 🚨 Contactos emergencia
            if (dto.ContactosEmergencia?.Any() == true)
            {
                foreach (var c in dto.ContactosEmergencia)
                {
                    c.Id ??= ObjectId.GenerateNewId().ToString();
                    c.EmpleadoId = empleado.Id;
                    c.UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion;

                    contactos.Add(_mapper.Map<ContactoEmergencia>(c));
                }

                await _db.GetCollection<ContactoEmergencia>("ContactoEmergencia")
                    .InsertManyAsync(contactos);
            }

            // 🔁 Actualizar campos del modelo Empleado principal
            var update = Builders<Empleado>.Update
                .Set(e => e.FechaUltimaModificacion, dto.FechaUltimaModificacion)
                .Set(e => e.UsuarioUltimaModificacion, dto.UsuarioUltimaModificacion)
                .Set(e => e.DatosPagoId, datosPagoId)
                .Set(e => e.AsignacionId, asignacionId)
                .Set(e => e.AsignacionHistorialIds, asignacionHistorialIds)
                .Set(e => e.RegistroImssIds, registroImssIds)
                .Set(e => e.HorarioIds, horarioIds)
                .Set(e => e.HistorialUbicacionIds, ubicacionIds)
                .Set(e => e.Documentos, documentos)
                .Set(e => e.ContactosEmergencia, contactos);

            if (dto.FechaIngreso != null) update = update.Set(e => e.FechaIngreso, dto.FechaIngreso);
            if (dto.Nss != null) update = update.Set(e => e.Nss, dto.Nss);
            if (dto.NumeroEmpleado != null) update = update.Set(e => e.NumeroEmpleado, dto.NumeroEmpleado);
            if (dto.TipoContrato != null) update = update.Set(e => e.TipoContrato, (TipoContratoEnum)dto.TipoContrato.Value);
            if (dto.TipoHorario != null) update = update.Set(e => e.TipoHorario, (TipoHorarioEnum)dto.TipoHorario.Value);
            if (dto.EstatusEmpleado != null) update = update.Set(e => e.EstatusEmpleado, (EstatusEmpleadoEnum)dto.EstatusEmpleado.Value);
            if (dto.CorreoCorporativo != null) update = update.Set(e => e.CorreoCorporativo, dto.CorreoCorporativo);
            if (dto.UsuarioRed != null) update = update.Set(e => e.UsuarioRed, dto.UsuarioRed);
            if (dto.IdBiometrico != null) update = update.Set(e => e.IdBiometrico, dto.IdBiometrico);
            if (dto.FotoPerfilUrl != null) update = update.Set(e => e.FotoPerfilUrl, dto.FotoPerfilUrl);

            await _db.GetCollection<Empleado>("Empleados").UpdateOneAsync(e => e.Id == id, update);

            return NoContent();
        }


        // DELETE: api/Empleado/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var resultado = await _db.GetCollection<Empleado>("Empleados").DeleteOneAsync(x => x.Id == id);
            if (resultado.DeletedCount == 0) return NotFound();
            return NoContent();
        }
    }
}
