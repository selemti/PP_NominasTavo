using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace PP_NominasBack.Services
{
    /// <summary>
    /// Representa la clase MongoDbService.
    /// </summary>
    public class MongoDbService

    {
       /// <summary>
       /// Ejecuta el método GetDatabase.
       /// </summary>
       public static IMongoDatabase GetDatabase(IConfiguration config)
        {
            var settings = config.GetSection("MongoConnection");
            var client = new MongoClient(settings["ConnectionString"]);
            return client.GetDatabase(settings["Database"]);
        }
    }
}