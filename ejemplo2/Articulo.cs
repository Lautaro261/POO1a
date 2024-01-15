using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    {
        //private int codArticulo;
        public int CodigoArticulo { get; set; }
        //private float precio;
        public float Precio { get; set; } //prop 

        private int codMarca;

        public int CodiMarca
        {
            get { return codMarca; }
            set
            {
                if(value > 0 && value < 11)
                codMarca = value;
                else 
                    codMarca = -1;
            }
        }


    }
}
