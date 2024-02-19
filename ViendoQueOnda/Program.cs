using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ViendoQueOnda
{

    public static class clase1
    {
        public static void Saludo()
        {
            Console.WriteLine("Hola q onda viejones");
        }
    }
    public class clase2
    {
        public void Saludo()
        {
            Console.WriteLine("Hola q onda ala verga");
        }
        
        public static void Saludo2()
        {
            Console.WriteLine("Hola putitas");
        }
    }

    public class Persona
    {
        private int _edad;

        // Propiedad virtual Edad con lógica
        public virtual int Edad
        {
            get { return _edad; }
            set
            {
                // Lógica para asegurarnos de que la edad no sea negativa ni mayor a 120
                _edad = (value < 0) ? 0 : (value > 120) ? 120 : value;
            }
        }
    }
    interface IinterfazA
    {
        void Saludo();
    }
    interface IinterfazB
    {
        void Saludo();
    }
    public class Estudiante : Persona, IinterfazA, IinterfazB
    {
        void IinterfazA.Saludo()
        {
            Console.WriteLine("Saludo desde interfaz A");
        }
        void IinterfazB.Saludo()
        {
            Console.WriteLine("Saludo desde interfaz B");
        }
        public void putas() 
        {
            Console.WriteLine("Hola putitas");
        }
    }
    public interface IInterfaceA
    {
        void MetodoComun();
    }

    public interface IInterfaceB
    {
        void MetodoComun();
    }

    public class MiClase : IInterfaceA, IInterfaceB
    {
        // Implementación de IInterfaceA
        void IInterfaceA.MetodoComun()
        {
            Console.WriteLine("Implementación de IInterfaceA");
        }

        // Implementación de IInterfaceB
        void IInterfaceB.MetodoComun()
        {
            Console.WriteLine("Implementación de IInterfaceB");
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
            //Una forma de hacerlo
            Estudiante estudiantexd = new Estudiante();
            IinterfazA estudiante1 = new Estudiante();
            estudiante1.Saludo();;


            //otra forma de hacerlo
            MiClase instancia = new MiClase();
            ((IInterfaceA)instancia).MetodoComun();  // Salida: Implementación de IInterfaceA
            ((IInterfaceB)instancia).MetodoComun();  // Salida: Implementación de IInterfaceB


            //Estudiante estudiante = new Estudiante();
            //// Asignamos edades, pero la lógica de rango se aplica en la clase base
            //estudiante.Edad = 25;
            //Console.WriteLine("Edad del estudiante: " + estudiante.Edad);  // Salida: 25

            //estudiante.Edad = 15123;
            //Console.WriteLine("Edad del estudiante: " + estudiante.Edad);  // Salida: 120 (límite superior aplicado)

            //estudiante.Edad = -5;
            //Console.WriteLine("Edad del estudiante: " + estudiante.Edad);  // Salida: 0 (límite inferior aplicado)

            //estudiante.Edad =  -512160;


            //Caballo caballo = new Caballo("Spirit");
            //caballo.Respirar();
            //caballo.Galopar();


            //Humano humano = new Humano("Alex");
            //humano.Respirar();
            //humano.Pensar();

            //Perro perro = new Perro("Wero");
            //perro.Respirar();
            //perro.Comer();
            //perro.Olfatear();

            //Serpiente serpiente = new Serpiente("Snake");
            //serpiente.Serpentear();
            //serpiente.Cazar();

            //Gato gatito = new Gato("Negrito");

            //perro.RecibirMamiferoxd(humano);

            //gatito.RecibirMamiferoxd(perro);

            //Mamiferos caballo1 = new Caballo("Spake");

            //caballo1.Respirar();

            //Mamiferos animal = new Humano("Juan");
            //animal.Pensar();

            //animal = new Gato("Pepsiki");
            //animal.Pensar();

            //Mamiferos gato = new Gato("Gatiko"); 
            //gato.Pensar();



            //List<Mamiferos> listaMamiferos = new List<Mamiferos>();
            //{
            //    listaMamiferos.Add(new Humano("Juan"));
            //    listaMamiferos.Add(new Gato("Gatikon"));
            //};

            //Console.WriteLine("hOLA");
            //foreach(Mamiferos mami in listaMamiferos)
            //{

            //    Console.WriteLine(mami.Nombre);
            //    mami.CriarCrias();
            //    if(mami is Gato)
            //    {
            //        mami.Pensar();

            //    }

            //}

            ////Humano humano1 = new Humano("Aleksey");
            ////humano1.Pensar();
            ////Mamiferos humanito = new Humano("Alex");
            ////humanito.Pensar();

            ////ObservableCollection<Mamiferos> miCollecion = new ObservableCollection<Mamiferos>(listaMamiferos);
            ////Icontrato esquilax = new Caballo("Juan");
            ////int numeropatas = esquilax.numeroPatas();
            ////Console.WriteLine(numeropatas);

            ////Icontrato humanobro = new Humano("Adolfo");
            ////int piernas = humanobro.numeroPatas();
            //Console.WriteLine(piernas);
           // Caballo caballito = new Caballo("perrillo");
          

        }
    }

    /// <summary>
    ///  Esto es asi porque todos solo los mamiferos terrestres tienen patas
    /// </summary>
    interface IcontratoTerrestres
    {
        int numeroPatas();
        int Raza { get; set; }
    }
    interface IcontratoSaltos
    {
        int numeroPatas();
    }
    interface Icontratoxd : IcontratoTerrestres
    {

    }


    interface IcontratoAcuaticos
    {
       void RespirarAgua();
    }

    public class ViendoQueOndaa : Icontratoxd
    {
        public int numeroPatas()
        {
            return 4;
        }
        public int Raza { get; set;}
    }

    public class Mamiferos
    {

        public string Nombre { get; private set; }
        protected int edad;
        public virtual string sexo { get; set; }
        public Mamiferos(string nombre)
        {
            Nombre = nombre;
        }

        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public virtual void CriarCrias()
        {
            Console.WriteLine("Soy capaz de cuidar mis crias");
        }

        public void Comer()
        {
            Console.WriteLine("Soy capaz de comer");
        }

        public void RecibirMamiferoxd(Mamiferos mamifero)
        {

            Console.WriteLine($"Mamifero recibido! se llama {mamifero.Nombre}!");

        }

        public virtual void Pensar()
        {
            Console.WriteLine("pensamientos institivos...");
        }


        public virtual double Velocidad()
        {
            return 25 + 30;
        }


    }


    public class Caballo : Mamiferos, IcontratoTerrestres, IcontratoSaltos
    {
        public int Raza { get;set; }
        public override string sexo { get; set; }

        public Caballo(string nombre, int raza) : base(nombre)
        {

        }

        int IcontratoTerrestres.numeroPatas()
        {
            return 4;
        }
        int IcontratoSaltos.numeroPatas() 
        {
            return 4; 
        }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
            edad = 4;
        }


    }



    public class Humano : Mamiferos, IcontratoTerrestres
    {
        public int Raza { get; set; }
        public int numeroPatas()
        {
            return 2;
        }
        
        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine($"Soy capaz de pensar! me llamo {base.Nombre} y puedo codificar");
        }

        public override void CriarCrias()
        {
            Console.WriteLine("Soy capaz de cuidar mis crias");
        }

        public string RegresarNombre()
        {
            return Nombre;
        }

    }
    public class Perro : Mamiferos, IcontratoTerrestres
    {
        public int Raza { get; set; }
        public int numeroPatas()
        {
            return 5;
        }
        public Perro(string nombrePerro) : base(nombrePerro)
        {

        }
        public void Olfatear()
        {
            Console.WriteLine($"Soy capaz de olfatear!");
        }
    }


    public class Gato : Mamiferos, IcontratoAcuaticos
    {

        public Gato(string nombre) : base(nombre)
        {

        }

        public void Maullar()
        {
            Console.WriteLine("Soy capaz de maullar");
        }
        public override void Pensar()
        {
           Console.WriteLine("Pensando gatunamente");
        }
        public void RespirarAgua()
        {
            Console.WriteLine("Respirar aire");
        }

    }

}
