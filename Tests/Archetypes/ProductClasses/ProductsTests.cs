﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductsTests : ClassTests<Products>
    {

        [TestMethod]
        public void ConstructorTest()
        {
            var a = new Products().GetType();
            Assert.AreEqual(a, typeof(Products));
        }

        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => Products.Instance);
        }
        [TestMethod]
        public void GetInstancesTest()
        {
            var s = GetRandom.String();
            Assert.AreEqual(0, Products.GetInstances(s).Count);
            var l = Products.Random();
            foreach (var e in l) e.TypeId = s;
            Products.Instance.AddRange(l);
            Products.Instance.AddRange(Products.Random());
            Assert.AreEqual(l.Count, Products.GetInstances(s).Count);
        }
        [TestMethod]
        public void GetContentTest()
        {
            var s = GetRandom.String();
            Assert.AreEqual(0, Products.GetContent(s).Count);
            var l = Products.Random();
            foreach (var e in l) e.PackageId = s;
            Products.Instance.AddRange(l);
            Products.Instance.AddRange(Products.Random());
            Assert.AreEqual(l.Count, Products.GetContent(s).Count);
        }
        protected Products GetRandomObj()
        {
            return Products.Random();
        }
    }
}
