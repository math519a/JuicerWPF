using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using JuicerLib.Models;
using Microsoft.Extensions.Configuration;

namespace JuicerLib.Services
{
    public static class CacheManager
    {
        
        public static async Task<IEnumerable<T>> GetItems<T>() where T : class
        {
            var type = typeof(T).Name.Replace("Model", "");
            using IDbConnection db = new SQLiteConnection(LoadConnectionString());
            var result = await db.QueryAsync<T>($"SELECT * FROM {type}", new DynamicParameters());
            return result;
        }
        
        public static async Task SaveItem<T>(T item) where T : class
        {
            var type = typeof(T).Name.Replace("Model", "");
            using IDbConnection db = new SQLiteConnection(LoadConnectionString());
            await db.ExecuteAsync($"INSERT INTO {type}", item);
        }

        private static string LoadConnectionString(string id = "Default")
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            return config.GetConnectionString(id);
        }
        
    }
}