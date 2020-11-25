using BitsBrewers.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitsBrewersUnitTests
{
    [TestFixture]
    class Ingredients
    {
        BitsContext dbContext;
        Ingredient i;
        List<Ingredient> ingredients;

        [SetUp]
        public void Setup()
        {
            dbContext = new BitsContext();
        }

        [Test]
        public void GetAllTest()
        {
            ingredients = dbContext.Ingredient.OrderBy(i => i.Name).ToList();
            Assert.AreEqual(1149, ingredients.Count);
            Assert.AreEqual("Abbaye Belgian", ingredients[0].Name);
            PrintAll(ingredients);
        }

        [Test]
        public void GetByPrimaryKeyTest()
        {
            i = dbContext.Ingredient.Find(796);
            Assert.IsNotNull(i);
            Assert.AreEqual("Sur Lie", i.Name);
            Console.WriteLine(i);
        }

        [Test]
        public void GetUsingWhere()
        {
            ingredients = dbContext.Ingredient.Where(i => i.Name.StartsWith("W")).OrderBy(i => i.Name).ToList();
            Assert.AreEqual(49, ingredients.Count);
            Assert.AreEqual("Warrior", ingredients[4].Name);
            PrintAll(ingredients);
        }

        [Test]
        public void CreateTest()
        {
            i = new Ingredient();
            i.IngredientId = 1408;
            i.Name = "Bastille 1808";
            i.Version = 11;
            i.IngredientTypeId = 4;
            i.OnHandQuantity = 90;
            i.UnitTypeId = 1;
            i.UnitCost = 1222.00m;
            i.ReorderPoint = 12;
            i.Notes = "Hints of orange, leather, cuban cigar smoke(havannah)/ considered exoctic";
            dbContext.Ingredient.Add(i);
            dbContext.SaveChanges();
            Assert.IsNotNull(dbContext.Ingredient.Find(1408));
        }

        [Test]
        public void UpdateTest()
        {
            i = dbContext.Ingredient.Find(1408);
            i.Name = "Sleep";
            dbContext.Ingredient.Update(i);
            dbContext.SaveChanges();
            i = dbContext.Ingredient.Find(1408);
            Assert.AreEqual("Sleep", i.Name);
        }

        [Test]
        public void DeleteTest()
        {
            i = dbContext.Ingredient.Find(1408);
            dbContext.Ingredient.Remove(i);
            dbContext.SaveChanges();
            Assert.IsNull(dbContext.Ingredient.Find(1408));
        }

        public void PrintAll(List<Ingredient> ingredients)
        {
            foreach (Ingredient i in ingredients)
            {
                Console.WriteLine(i);
            }
        }
    }
}
