using System;
namespace animales
{
    class Gato  : Mamiferos
    {
      public bool Maullar { get; set; } 
      public bool TienenBigote { get; set; }

        
        public Gato(string nombre, int patas)
        {
            Nombre = nombre;
            Patas = patas;
        }

        public void MetodoDegato()
        {
            Comer = true;
            Vertebrados = true;
            TienenPelaje = true;
            Caminar = true;
            Viviparos = true;
            CaracteristicasGato();

            Console.WriteLine("Nombre del gato: " + Nombre);
            Console.WriteLine("Numero de patas: " + Patas);
            Console.WriteLine("¿Puede Comer? " + Comer);
            Console.WriteLine("¿Es un animal Vertebrado? " + Vertebrados);
            Console.WriteLine("¿Tiene Pelaje? " + TienenPelaje);
            Console.WriteLine("¿Puede caminar? " + Caminar);
            Console.WriteLine("¿Es viviparo? " + Viviparos);
            Console.WriteLine("¿Puede Maullar? " + Maullar);
            Console.WriteLine("¿Tiene Bigote? " + TienenBigote);
            Console.WriteLine("");
           
        }

        private void CaracteristicasGato()
        {
            Maullar = true;
            TienenBigote = true;
        }
    }
}
