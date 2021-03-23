using System;
namespace animales
{
    class Mono : Mamiferos 
    {
        public bool Maullar { get; set; }
        public bool Omnivoros { get; set; }

         public Mono(string nombre, int patas)
        {
            Nombre = nombre;
            Patas = patas;
        }

        public void MetodoDemono()
        {
            Comer = true;
            Vertebrados = true;
            TienenPelaje = true;
            Caminar = true;
            Viviparos = true;
           

            Console.WriteLine("Nombre del mono: " + Nombre);
            Console.WriteLine("Numero de patas: " + Patas);
            Console.WriteLine("Puede comer? " + Comer);
            Console.WriteLine("¿Es un animal vertebrado? " + Vertebrados);
            Console.WriteLine("¿Tiene Pelaje? " + TienenPelaje);
            Console.WriteLine("Puede caminar? " + Caminar);
            Console.WriteLine("¿Es un animal Viviparo? " + Viviparos);
            CaracteristicasMono();
            Console.WriteLine("");
            
        }

        private void CaracteristicasMono()
        {
            Maullar = true;
            Omnivoros = true;
        }
    }
}