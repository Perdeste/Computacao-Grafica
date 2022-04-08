using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DGEN
{
    internal class Aresta
    {
        int verticeA, verticeB;

        public Aresta(int verticeA, int verticeB)
        {
            this.verticeA = verticeA;
            this.verticeB = verticeB;
        }

        public int getVerticeA()
        {
            return this.verticeA;
        }
        public int getVerticeB()
        {
            return this.verticeB;
        }


    }
}
