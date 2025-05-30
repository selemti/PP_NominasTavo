using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PP_NominasBack.Models.Catalogos.Shared;
using PP_NominasBack.Dtos.Catalogos.Shared;
using AutoMapper;
using MongoDB.Bson;

namespace PP_NominasBack.Controllers.Catalogos.Shared
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IMongoCollection<Persona> _collection;
        private readonly IMapper _mapper;

        public PersonaController(IMongoDatabase database, IMapper mapper)
        {
            _collection = database.GetCollection<Persona>("Personas");
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonaDto dto)
        {
            var persona = _mapper.Map<Persona>(dto);
            persona.Id ??= ObjectId.GenerateNewId().ToString();

            await _collection.InsertOneAsync(persona);
            return CreatedAtAction(nameof(Get), new { id = persona.Id }, _mapper.Map<PersonaDto>(persona));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonaDto>> Get(string id)
        {
            var persona = await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            if (persona == null) return NotFound();
            return _mapper.Map<PersonaDto>(persona);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] PersonaDto dto)
        {
            var persona = _mapper.Map<Persona>(dto);
            persona.Id = id;
            var result = await _collection.ReplaceOneAsync(p => p.Id == id, persona);
            return result.MatchedCount > 0 ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _collection.DeleteOneAsync(p => p.Id == id);
            return result.DeletedCount > 0 ? NoContent() : NotFound();
        }
    }
}
