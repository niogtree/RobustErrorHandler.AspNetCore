﻿using RobustErrorHandler.Core;
using System.Collections.Generic;

namespace RobustErrorHandler.Sample.ShapeDomain
{
    public class Rectangle : Shape
    {
        private Rectangle(IList<int> sides) : base(sides)
        {
        }

        public static Either<Error, Rectangle> Create(IList<int> sides)
        {
            if (sides.Count != 4)
                return Result.Invalid<Rectangle>(new ErrorMessages.NotEnoughSides(4));
            else
                return Result.Success(new Rectangle(sides));
        }

        public override int GetPerimeter()
        {
            return base.GetPerimeter();
        }
    }
}
