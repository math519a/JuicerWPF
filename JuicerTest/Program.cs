using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Controls;
using JuicerLib.Models;
using JuicerLib.Models.Enums;
using JuicerLib.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic.CompilerServices;

namespace JuicerTest
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            
            var items = ApiCaller.GetItems<BaseModel>("delirium", "base");
            
            var db = new ItemsDbContext();
            //var deleted = db.Database.EnsureDeleted();
            var created = db.Database.EnsureCreated();
            //Console.WriteLine(deleted);
            Console.WriteLine(created);

            if (db.Bases.Any())
            {
                Console.WriteLine("Updating Items");
                db.Bases.UpdateRange(items);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Adding Items");
                db.Bases.AddRange(items);
                db.SaveChanges();
            }
            
            
            foreach (var accessoryModel in db.Bases.Where(a => a.Exalted > 1 ).OrderBy(a => a.Exalted))
            {
                Console.Write($"{accessoryModel.Name} ");
                
                foreach (var influence in accessoryModel.Influences)
                {
                    Console.Write($"{influence.ToString()} ");
                }
                Console.Write($"{accessoryModel.BaseItemLevel} {accessoryModel.Exalted} {accessoryModel.Id}");
                Console.Write("\n");
            }
            Console.WriteLine("Finished in {0}ms", timer.ElapsedMilliseconds);
        }
    }
}