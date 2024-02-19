using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViendoQueOnda
{
    public class Figuras
    {

        public class Formas
        {
            protected double x, y;

            public  void Nombre(string nombre)
            {
                Console.WriteLine(nombre);
            }

            public virtual double Area()
            {
                return x + y;
            }
            
            

            
        }
        public abstract class Invento
        {
            public abstract string nombreInvento();
        }

        public class Invento1 : Invento
        {
            public override string nombreInvento()
            {
                throw new NotImplementedException();
            }
        }

        public class Circulo : Formas 
        {
            //public string nombre = "Circulo";
            

            public override double Area()
            {
                return 3.14 * x * y;
            }

        }
        public class Triangulo:Formas
        {

            public override double Area()
            {
                return (x * y) / 2;
            }

        }


    }

    


}
