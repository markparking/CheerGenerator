using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pass
    {
        private int Passes;

        public void GetPass(int passes)
        {
            this.Passes = passes;
        }
        public int SetPass()
        {
            return Passes;
        }

    }
}
