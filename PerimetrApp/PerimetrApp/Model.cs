using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetrApp
{
    class ModelGreat : IModel
    {
        public int GetP(int a, int b)
        {
            return a+b+a+b;
        }
    }
}
