using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PP_NominasBack.Models.Catalogos.Asistencia;
using PP_NominasBack.Dtos.Catalogos.Asistencia;
using AutoMapper;

namespace PP_NominasBack.Controllers.Catalogos.Asistencia
{
    [ApiController]
    [Route("api/[controller]")]
    public class HorarioEmpleadoController : ControllerBase
    {
        private readonly IMongoCollection<HorarioEmpleado> _collection;
        private readonly IMapper _mapper;

        public HorarioEmpleadoController(IMongoDatabase db, IMapper mapper)
        {
            _collection = db.GetCollection<HorarioEmpleado>("HorariosEmpleado");
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] HorarioEmpleadoDto dto)
        {
            var entity = _mapper.Map<HorarioEmpleado>(dto);
            await _collection.InsertOneAsync(entity);
            return CreatedAtAction(nameof(Get), new { id = entity.Id }, _mapper.Map<HorarioEmpleadoDto>(entity));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HorarioEmpleadoDto>> Get(string id)
        {
            var entity = await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            if (entity == null) return NotFound();
            return _mapper.Map<HorarioEmpleadoDto>(entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] HorarioEmpleadoDto dto)
        {
            var entity = _mapper.Map<HorarioEmpleado>(dto);
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
