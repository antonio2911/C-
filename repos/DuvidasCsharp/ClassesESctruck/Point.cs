﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesESctruck
{
 public struct Point
  {
   public double x, y;

    public override string ToString()
    {
      return $"({x}, {y})";
    }
  }
}
