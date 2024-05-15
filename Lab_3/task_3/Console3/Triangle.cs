﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            _renderer.Render("Triangle");
        }
    }
}
