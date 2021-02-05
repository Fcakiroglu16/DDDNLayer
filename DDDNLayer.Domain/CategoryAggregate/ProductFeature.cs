using DDDNLayer.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.CategoryAggregate
{
    public class ProductFeature : ValueObject
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        public string Color { get; private set; }

        public ProductFeature()
        {
        }

        public ProductFeature(int height, int width, string color)
        {
            Height = height;
            Width = width;
            Color = color;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Height;
            yield return Width;
            yield return Color;
        }
    }
}