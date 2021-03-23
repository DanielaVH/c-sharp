using System;
namespace animales
{
    class Loro : Aves
    {
        public bool Hablar { get; set; }

         public Loro(string nombre, string colorPlumaje)
        {
            Nombre = nombre;
            ColorPlumaje = colorPlumaje;
        }
        public void MetodoDeloro()
        {
            Comer = true;
            Vertebrados = true;
            Volar = true;
            TienenPico = true;
            CaracteristicasLoro();

        
            
            Console.WriteLine("Nombre del Loro: " + Nombre);
            Console.WriteLine("Color del Plumaje: " + ColorPlumaje);
            Console.WriteLine("¿Pude comer? " + Comer);
            Console.WriteLine("¿Es un animal vertebrado? " + Vertebrados);
            Console.WriteLine("¿Puede volar? " + Volar);
            Console.WriteLine("¿Puede hablar? " + Hablar);
            Console.WriteLine("¿Tiene Pico?" + TienenPico);
            Console.WriteLine("");
        }

        private void CaracteristicasLoro()
        {
            Hablar = true;
    

        }
    }
}   