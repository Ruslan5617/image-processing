using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics_1
{
    class SobelXFilter : MatrixFilter
    {
        public SobelXFilter()
        {
            kernel = new float[3, 3] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
        }
    }
}
