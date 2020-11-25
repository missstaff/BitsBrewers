using BitsBrewers.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BitsBrewersUnitTests
{
    [TestFixture]
    public class Tests
    {
        BitsContext dbContext;
        Adjunct a;
        List<Adjunct> adjuncts;

        [SetUp]
        public void Setup()
        {
            dbContext = new BitsContext();
        }

        [Test]
        public void GetAllTest()
        {
            adjuncts = dbContext.Adjunct.OrderBy(a => a.AdjunctType).ToList();
            Assert.AreEqual(130, adjuncts.Count);
            Assert.AreEqual("Chill Haze", adjuncts[0].UseFor);
            PrintAll(adjuncts);
        }

        [Test]
        public void GetByPrimaryKeyTest()
        {
            a = dbContext.Adjunct.Find(779);
            Assert.IsNotNull(a);
            Assert.AreEqual("Fruit Beer", a.UseFor);
            Console.WriteLine(a);
        }

        [Test]
        public void GetUsingWhere()
        {
            adjuncts = dbContext.Adjunct.Where(a => a.UseFor.StartsWith("A")).OrderBy(a => a.UseFor).ToList();
            Assert.AreEqual(2, adjuncts.Count);
            Assert.AreEqual("Antioxident", adjuncts[1].UseFor);
            PrintAll(adjuncts);
        }

        [Test]
        public void DeleteTest()
        {
            a = dbContext.Adjunct.Find(759);
            dbContext.Adjunct.Remove(a);
            dbContext.SaveChanges();
            Assert.IsNull(dbContext.Adjunct.Find(759));
        }

        [Test]
        public void CreateTest()
        {
            a = new Adjunct();
            a.IngredientId = 884;
            a.AdjunctTypeId = 4;
            a.UseFor = "Winter Ale";
            a.RecommendedQuantity = 0.0019;
            a.BatchVolume = 3.78541;
            a.RecommendedUseDuringId = 7;
            dbContext.Adjunct.Add(a);
            dbContext.SaveChanges();
            Assert.IsNotNull(dbContext.Adjunct.Find(884));
        }

        [Test]
        public void UpdateTest()
        {
            a = dbContext.Adjunct.Find(884);
            a.UseFor = "Spice";
            dbContext.Adjunct.Update(a);
            dbContext.SaveChanges();
            a = dbContext.Adjunct.Find(884);
            Assert.AreEqual("Spice", a.UseFor);
        }

        public void PrintAll(List<Adjunct> adjuncts)
        {
            foreach (Adjunct a in adjuncts)
            {
                Console.WriteLine(a);
            }
        }
    }
}