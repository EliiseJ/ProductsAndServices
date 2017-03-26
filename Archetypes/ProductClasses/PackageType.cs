﻿using System;
using System.Linq;
using Archetypes.ProductClasses;

namespace Open.Archetypes.ProductClasses
{
    public class PackageType
    {

        public void addProductType(ProductType product)
        {
            ProductTypes.Instance.Add(product);
        }

        public ProductType[] getComponents()
        {
            return ProductTypes.Instance.ToArray();
        }

        public Price[] getPrices()
        {
            return Prices.Instance.ToArray();
        }

        /*public void addProductSet(ProductSet set)
        {
            ProductSets.Instance.Add(set);
        }*/

        /*public void addPropositionOfinclusion(PropositionOfInclusion proposition)
        {
            
        }*/

        public Boolean validatePackage()
        {
            return false;
        }
    }
}

