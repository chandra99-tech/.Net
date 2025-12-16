using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02.Logic
{
    public class CMath : IX, IY
    {
        #region Implicit way
            public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Mult(int x, int y)
        {
            return x * y;
        }
        #endregion

        #region Explicit way of implementation
        int IX.Add(int x, int y)
        {
            return x + y;
        }

        int IY.Add(int x, int y)
        {
            return x + y + 1000;
        }

        int IY.Mult(int x, int y)
        {
            return x * y;
        }

        int IX.Sub(int x, int y)
        {
            return x - y;
        }
        #endregion
    }
}
