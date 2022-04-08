using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DGEN
{
    internal class Vertice
    {
        public float x, y, z;

        public Vertice()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public Vertice(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
