﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetrApp
{
    class Model : IModel
    {
     
        int IModel.GetP(int a, int b)
        {
            return (a + b) * 2;
        }
    }
}
