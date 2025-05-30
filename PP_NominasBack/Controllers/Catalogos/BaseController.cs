using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using System;

namespace PP_NominasBack.Controllers.Catalogos
{
    [ApiController]
    public abstract class BaseController<TModel, TDto> : ControllerBase where TModel : class
    {
        private readonly IMongoCollection<TModel> _collection;
        private readonly IMapper _mapper;

        public BaseController(IMongoDatabase database, IMapper mapper)
        {
            _collection = database.GetCollection<TModel>(typeof(TModel).Name);
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TDto>>> Get()
        {
            var entities = await _collection.Find(_ => true).ToListAsync();
            return Ok(_mapper.Map<IEnumerable<TDto>>(entities));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TDto>> Get(string id)
        {
            var filter = Builders<TModel>.Filter.Eq("Id", ObjectId.Parse(id));
            var entity = await _collection.Find(filter).FirstOrDefaultAsync();

            if (entity == null)
                return NotFound();

            return Ok(_mapper.Map<TDto>(entity));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            await _collection.InsertOneAsync(entity);
            return CreatedAtAction(nameof(Get), new { id = entity?.GetType().GetProperty("Id")?.GetValue(entity)?.ToString() }, dto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, [FromBody] TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            var filter = Builders<TModel>.Filter.Eq("Id", ObjectId.Parse(id));
            var result = await _collection.ReplaceOneAsync(filter, entity);

            if (result.MatchedCount == 0)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var filter = Builders<TModel>.Filter.Eq("Id", ObjectId.Parse(id));
            var result = await _collection.DeleteOneAsync(filter);

            if (result.DeletedCount == 0)
                return NotFound();

            return NoContent();
        }
    }
}
