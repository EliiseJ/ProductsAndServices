﻿using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ArbitaryPrices : Archetypes<ArbitaryPrice>
    {
        public static ArbitaryPrices Instances { get; } = new ArbitaryPrices();
    }
}
