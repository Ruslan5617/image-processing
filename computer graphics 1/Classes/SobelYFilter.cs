using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_graphics_1
{
    class SobelYFilter : MatrixFilter
    {
        public SobelYFilter()
        {
            kernel = new float[3, 3] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
        }
    }
}
