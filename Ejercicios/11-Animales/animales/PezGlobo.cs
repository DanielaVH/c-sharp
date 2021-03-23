using System;
namespace animales
{
    class PezGlobo : Peces
    {
        public bool Inflarse { get; set; }

         public bool SonToxicos { get; set; }

         public PezGlobo(string nombre, int numeroAletas)
        {
            Nombre = nombre;
            NumeroAletas = numeroAletas;
        }
        public void MetodoPezGlobo()
        {
            Vertebrados = true;
            Comer = true;
            Nadar = true;
            TienenEscamas = true;
            CaracteristicasPezGlobo();


            Console.WriteLine("Nombre del pez globo: " + Nombre);
            Console.WriteLine("Cantidad de aletas: " + NumeroAletas);
            Console.WriteLine("¿Es un animal vertebrado? " + Vertebrados);
            Console.WriteLine("¿Puede comer? " + Comer);
            Console.WriteLine("¿Puede Nadar? " + Nadar);
            Console.WriteLine("¿Tiene escamas? " + TienenEscamas);
            Console.WriteLine("¿Puede inflarse? " + Inflarse);
            Console.WriteLine("¿Es toxico? " + SonToxicos);
            Console.WriteLine("");
        }
         private void CaracteristicasPezGlobo()
        {
            Inflarse = true;
            SonToxicos =true;
        }
    }
}
