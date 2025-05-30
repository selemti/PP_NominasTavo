using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace PP_NominasBack.Services.Utileria
{
    public class SecuenciaService
    {
        private readonly IMongoCollection<BsonDocument> _collection;

        public SecuenciaService(IMongoDatabase db)
        {
            _collection = db.GetCollection<BsonDocument>("Contadores");
        }

        public async Task<string> ObtenerSiguienteNumeroEmpleadoAsync()
        {
            var resultado = await _collection.FindOneAndUpdateAsync(
                Builders<BsonDocument>.Filter.Eq("_id", "Empleado"),
                Builders<BsonDocument>.Update.Inc("UltimoNumero", 1),
                new FindOneAndUpdateOptions<BsonDocument>
                {
                    IsUpsert = true,
                    ReturnDocument = ReturnDocument.After
                });

            var numero = resultado["UltimoNumero"].AsInt32;
            return $"E{numero:D5}"; // E00001, E00002...
        }
    }
}
