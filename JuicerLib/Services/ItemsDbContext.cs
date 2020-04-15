using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using JuicerLib.Models;
using JuicerLib.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace JuicerLib.Services
{
    public class ItemsDbContext : DbContext
    {
        public DbSet<AccessoryModel> Accessories { get; set; }
        public DbSet<ArmourModel> Armours { get; set; }
        public DbSet<BaseModel> Bases { get; set; }
        public DbSet<CardModel> Cards { get; set; }
        public DbSet<CurrencyModel> Currencies { get; set; }
        public DbSet<EnchantmentModel> Enchantments { get; set; }
        public DbSet<FlaskModel> Flasks { get; set; }
        public DbSet<JewelModel> Jewels { get; set; }
        public DbSet<MapModel> Maps { get; set; }
        public DbSet<ProphecyModel> Prophecies { get; set; }
        public DbSet<WeaponModel> Weapons { get; set; }
        public DbSet<ItemCategoryModel> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite(@"Data Source=.\Caches\Items.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Accessory Model
            modelBuilder.Entity<AccessoryModel>(e =>
            {
                e.Property(p => p.Category)
                    .HasConversion(x => x.ToString(),
                        x => (Categories) Enum.Parse(typeof(Categories), x));
                e.Property(p => p.Group)
                    .HasConversion(x => x.ToString(),
                        x => (Groups) Enum.Parse(typeof(Groups), x));
                e.Property(p => p.Influences)
                    .HasConversion(
                        x => string.Join(",", x), 
                        x => StringToListOf<Influences>(x));
            });
            #endregion
            #region Armour Model
            modelBuilder.Entity<ArmourModel>(e =>
            {
                e.Property(p => p.Category)
                    .HasConversion(x => x.ToString(),
                        x => (Categories) Enum.Parse(typeof(Categories), x));
                e.Property(p => p.Group)
                    .HasConversion(x => x.ToString(),
                        x =>(Groups) Enum.Parse(typeof(Groups), x));
                e.Property(p => p.Influences)
                    .HasConversion(
                        x => string.Join(",", x), 
                        x => StringToListOf<Influences>(x));
            });
            #endregion
            #region Base Model
            modelBuilder.Entity<BaseModel>(e =>
            {
                e.Property(p => p.Category)
                    .HasConversion(x => x.ToString(),
                        x => (Categories) Enum.Parse(typeof(Categories), x));
                e.Property(p => p.Group)
                    .HasConversion(x => x.ToString(),
                        x => (Groups) Enum.Parse(typeof(Groups), x));
                e.Property(p => p.Influences)
                    .HasConversion(
                        x => string.Join(",", x), 
                        x => StringToListOf<Influences>(x));
            });
            #endregion
            #region Card Model
            modelBuilder.Entity<CardModel>(e =>
            {
                e.Property(p => p.Category)
                    .HasConversion(x => x.ToString(),
                        x => (Categories) Enum.Parse(typeof(Categories), x));
                e.Property(p => p.Group)
                    .HasConversion(x => x.ToString(),
                        x => (Groups) Enum.Parse(typeof(Groups), x));
            });
            #endregion
            #region Currency Model
            modelBuilder.Entity<CurrencyModel>(e =>
            {
                e.Property(p => p.Category)
                    .HasConversion(x => x.ToString(),
                        x => (Categories) Enum.Parse(typeof(Categories), x));
                e.Property(p => p.Group)
                    .HasConversion(x => x.ToString(),
                        x => (Groups) Enum.Parse(typeof(Groups), x));
            });
            #endregion
            #region Enchantment Model
                        modelBuilder.Entity<EnchantmentModel>(e =>
                        {
                            e.Property(p => p.Category)
                                .HasConversion(x => x.ToString(),
                                                x => (Categories) Enum.Parse(typeof(Categories), x));
                            e.Property(p => p.Group)
                                .HasConversion(x => x.ToString(),
                                    x => (Groups) Enum.Parse(typeof(Groups), x));
                            e.Property(p => p.Influences)
                                .HasConversion(
                                    x => string.Join(",", x), 
                                    x => StringToListOf<Influences>(x));
                        });
            #endregion
            #region Flask Model
            modelBuilder.Entity<FlaskModel>(e =>
            {
                e.Property(p => p.Category)
                    .HasConversion(x => x.ToString(),
                        x => (Categories) Enum.Parse(typeof(Categories), x));
                e.Property(p => p.Group)
                    .HasConversion(x => x.ToString(),
                        x => (Groups) Enum.Parse(typeof(Groups), x));
            });
            #endregion
            #region Jewel Model
            modelBuilder.Entity<JewelModel>(e =>
            {
                e.Property(p => p.Category)
                    .HasConversion(x => x.ToString(),
                        x => (Categories) Enum.Parse(typeof(Categories), x));
                e.Property(p => p.Group)
                    .HasConversion(x => x.ToString(),
                        x => (Groups) Enum.Parse(typeof(Groups), x));
                e.Property(p => p.Type)
                    .HasConversion(x => x.ToString(),
                        x => (Types) Enum.Parse(typeof(Types), x));
            });
            #endregion
            #region Map Model
            modelBuilder.Entity<MapModel>(e =>
            {
                e.Property(p => p.Category)
                    .HasConversion(x => x.ToString(),
                        x => (Categories) Enum.Parse(typeof(Categories), x));
                e.Property(p => p.Group)
                    .HasConversion(x => x.ToString(),
                        x => (Groups) Enum.Parse(typeof(Groups), x));
            });
            #endregion
            #region Prophecy Model
            modelBuilder.Entity<ProphecyModel>(e =>
            {
                e.Property(p => p.Category)
                    .HasConversion(x => x.ToString(),
                        x => (Categories) Enum.Parse(typeof(Categories), x));
                e.Property(p => p.Group)
                    .HasConversion(x => x.ToString(),
                        x => (Groups) Enum.Parse(typeof(Groups), x));
            });
            #endregion
            #region Weapon Model
            modelBuilder.Entity<WeaponModel>(e =>
            {
                e.Property(p => p.Category)
                    .HasConversion(x => x.ToString(),
                        x => (Categories) Enum.Parse(typeof(Categories), x));
                e.Property(p => p.Group)
                    .HasConversion(x => x.ToString(),
                        x => (Groups) Enum.Parse(typeof(Groups), x));
                e.Property(p => p.Influences)
                    .HasConversion(
                        x => string.Join(",", x), 
                        x => StringToListOf<Influences>(x));
            });
            #endregion
            #region Item Category Model
            modelBuilder.Entity<ItemCategoryModel>();
            #endregion
            base.OnModelCreating(modelBuilder);
        }
        private static List<T> StringToListOf<T>(string s) where T : struct
        {
            var enums = new List<T>();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine($"{typeof(T).ToString()} is null or empty");
                return enums;
            }
            var list = s.Split(",").ToList();
            if (list.Capacity == 0) return enums;
            foreach (var str in list)
            {
                enums.Add(Enum.Parse<T>(str));
            }
            return enums;
        }

        private static T? StringToEnumOf<T>(string s) where T : struct
        {
            if (!string.IsNullOrEmpty(s))
            {
                return (T) Enum.Parse(typeof(T), s);
            }
            Console.WriteLine($"{typeof(T).ToString()} is null or empty");
            return null;
        }
    }
    
}