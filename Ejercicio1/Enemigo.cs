using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Enemigo
    {
        public int x { get; set; }
        public int y { get; set; }
        
        public int _ganas;

        public int Ganas
        {
            get
            {
                return _ganas;
            }
            set
            {
                if (value >= 100)
                {
                    _ganas = value;
                }
                else
                {
                    throw new Exception("No es mayor de 100");
                }
            }
        }
        public moverse()
        {

        }
        public disparo()
        {

        }
        public explotar()
        {

        }
    }
}
