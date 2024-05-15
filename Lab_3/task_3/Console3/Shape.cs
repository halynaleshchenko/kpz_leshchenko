﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    public abstract class Shape
    {
        protected IRenderer _renderer;

        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();
    }
}
