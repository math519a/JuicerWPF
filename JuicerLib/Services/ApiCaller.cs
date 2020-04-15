using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using JuicerLib.Models;
using Newtonsoft.Json;

namespace JuicerLib.Services
{
    public static class ApiCaller
    {
        private const string CategoryApi = "https://api.poe.watch/categories";

        //Example ItemApi = https://api.poe.watch/get?league=Standard&category=flask
        private const string ItemApi = "https://api.poe.watch/get";

        public static IEnumerable<ItemCategoryModel> GetCategories()
        {
            var client = new WebClient();
            var result = client.DownloadString(CategoryApi);
            var model = JsonConvert.DeserializeObject<IEnumerable<ItemCategoryModel>>(result);
            return model;
        }

        public static IEnumerable<T> GetItems<T>(string league, string category) where T : class
        {
            var client = new WebClient();
            var result = client.DownloadString(ItemApi + $"?league={league}&category={category}");
            var model = JsonConvert.DeserializeObject<IEnumerable<T>>(result);
            return model;
        }

        public static void GetUpdateFromItemId<T>() where T : class
        {
            
        }
    }
}