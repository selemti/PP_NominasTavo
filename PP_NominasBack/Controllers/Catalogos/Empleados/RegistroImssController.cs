using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PP_NominasBack.Models.Catalogos.Empleados;
using PP_NominasBack.Dtos.Catalogos.Empleados;
using AutoMapper;

namespace PP_NominasBack.Controllers.Catalogos.Empleados
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroImssController : ControllerBase
    {
        private readonly IMongoCollection<RegistroImss> _collection;
        private readonly IMapper _mapper;

        public RegistroImssController(IMongoDatabase db, IMapper mapper)
        {
            _collection = db.GetCollection<RegistroImss>("RegistrosImss");
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RegistroImssDto dto)
        {
            var entity = _mapper.Map<RegistroImss>(dto);
            await _collection.InsertOneAsync(entity);
            return CreatedAtAction(nameof(Get), new { id = entity.Id }, _mapper.Map<RegistroImssDto>(entity));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroImssDto>> Get(string id)
        {
            var entity = await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            if (entity == null) return NotFound();
            return _mapper.Map<RegistroImssDto>(entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] RegistroImssDto dto)
        {
            var entity = _mapper.Map<RegistroImss>(dto);
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
