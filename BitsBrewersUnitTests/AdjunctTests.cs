using BitsBrewers.Models;
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
            Assert.AreEqual("'Antioxident'", adjuncts[4].UseFor);
            //PrintAll(adjuncts);
        }

    }
}