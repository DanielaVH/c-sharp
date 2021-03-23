using System;
namespace animales
{
    class Aguila : Aves 
    {
       public bool VolarAlto { get; set; }

       public bool PoseenGarras { get; set; }


       public Aguila(string nombre, string colorPlumaje)
        {
            Nombre = nombre;
            ColorPlumaje = colorPlumaje;
        }
        public void MetodoDeaguila()
        {
            Comer = true;
            Vertebrados = true;
            Volar = true;
            TienenPico = true;
            CaracteristicasAguila();


            Console.WriteLine("Nombre del aguila: " + Nombre);
            Console.WriteLine("Color del Plumaje: " + ColorPlumaje);
            Console.WriteLine("¿Puede comer? " + Comer);
            Console.WriteLine("¿Es un animal vertebrado? " + Vertebrados);
            Console.WriteLine("¿Este animal Puede volar? " + Volar);
            Console.WriteLine("¿Tiene Pico? " + TienenPico);
            Console.WriteLine("");
           
        }

        private void CaracteristicasAguila()
        {
            VolarAlto = true;
            PoseenGarras = true;

        }
    }
}   