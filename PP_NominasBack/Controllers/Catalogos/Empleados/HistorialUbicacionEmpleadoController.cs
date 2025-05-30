using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PP_NominasBack.Models.Catalogos.Empleados;
using PP_NominasBack.Dtos.Catalogos.Organizacion;
using AutoMapper;
using PP_NominasBack.Models.Catalogos.Organización;
using PP_NominasBack.Dtos.Catalogos.Organización;

namespace PP_NominasBack.Controllers.Catalogos.Organizacion
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistorialUbicacionEmpleadoController : ControllerBase
    {
        private readonly IMongoCollection<HistorialUbicacionEmpleado> _collection;
        private readonly IMapper _mapper;

        public HistorialUbicacionEmpleadoController(IMongoDatabase db, IMapper mapper)
        {
            _collection = db.GetCollection<HistorialUbicacionEmpleado>("HistorialUbicacionesEmpleado");
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] HistorialUbicacionEmpleadoDto dto)
        {
            var entity = _mapper.Map<HistorialUbicacionEmpleado>(dto);
            await _collection.InsertOneAsync(entity);
            return CreatedAtAction(nameof(Get), new { id = entity.Id }, _mapper.Map<HistorialUbicacionEmpleadoDto>(entity));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HistorialUbicacionEmpleadoDto>> Get(string id)
        {
            var entity = await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            if (entity == null) return NotFound();
            return _mapper.Map<HistorialUbicacionEmpleadoDto>(entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] HistorialUbicacionEmpleadoDto dto)
        {
            var entity = _mapper.Map<HistorialUbicacionEmpleado>(dto);
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
