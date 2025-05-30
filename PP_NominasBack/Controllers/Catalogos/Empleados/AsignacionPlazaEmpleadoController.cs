// Controllers/Catalogos/Empleados/AsignacionPlazaEmpleadoController.cs
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PP_NominasBack.Models.Catalogos.Empleados;
using PP_NominasBack.Dtos.Catalogos.Empleados;
using AutoMapper;

namespace PP_NominasBack.Controllers.Catalogos.Empleados
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsignacionPlazaEmpleadoController : ControllerBase
    {
        private readonly IMongoCollection<AsignacionPlazaEmpleado> _collection;
        private readonly IMapper _mapper;

        public AsignacionPlazaEmpleadoController(IMongoDatabase db, IMapper mapper)
        {
            _collection = db.GetCollection<AsignacionPlazaEmpleado>("AsignacionesPlazaEmpleado");
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AsignacionPlazaEmpleadoDto dto)
        {
            var entity = _mapper.Map<AsignacionPlazaEmpleado>(dto);
            await _collection.InsertOneAsync(entity);
            return CreatedAtAction(nameof(Get), new { id = entity.Id }, _mapper.Map<AsignacionPlazaEmpleadoDto>(entity));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AsignacionPlazaEmpleadoDto>> Get(string id)
        {
            var entity = await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            if (entity == null) return NotFound();
            return _mapper.Map<AsignacionPlazaEmpleadoDto>(entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] AsignacionPlazaEmpleadoDto dto)
        {
            var entity = _mapper.Map<AsignacionPlazaEmpleado>(dto);
            entity.Id = id;
            var result = await _collection.ReplaceOneAsync(x => x.Id == id, entity);
            return result.MatchedCount > 0 ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _collection.DeleteOneAsync(x => x.Id == id);
            return result.DeletedCount > 0 ? NoContent() : NotFound();
        }
    }
}