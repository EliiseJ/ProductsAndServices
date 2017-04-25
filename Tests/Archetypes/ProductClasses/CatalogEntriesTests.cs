﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class CatalogEntriesTests : CommonTests<CatalogEntries>
    {
        protected override CatalogEntries GetRandomObj()
        {
            return CatalogEntries.Random();
        }

        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => CatalogEntries.Instance);
        }
    }
}
