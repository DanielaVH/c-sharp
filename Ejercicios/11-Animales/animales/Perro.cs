using System;
namespace animales
{
    class Perro : Mamiferos
    {
        public bool Ladrar { get; set; }
        public bool Carnivoro{get; set;}

        public Perro(string nombre, int patas)
        {
            Nombre = nombre;
            Patas = patas;
        }

        public void MetodoDeperro()
        {
            Comer = true;
            Vertebrados = true;
            TienenPelaje = true;
            Caminar = true;
            Viviparos = true;
            

            Console.WriteLine("Nombre perro: " + Nombre);
            Console.WriteLine("Cantidad de patas: " + Patas);
            Console.WriteLine("¿Puede comer? " + Comer);
            Console.WriteLine("¿Es un animal vertebrado?  " + Vertebrados);
            Console.WriteLine("¿Tiene Pelaje?  " + TienenPelaje);
            Console.WriteLine("¿Puede caminar? " + Caminar);
            Console.WriteLine("¿Es un animal Viviparo? " + Viviparos);
            Console.WriteLine("¿Puede Ladrar? " + Ladrar);
            Console.WriteLine("¿Es una animal carnivoro? " + Carnivoro);
            CacteristicasPerro();
            Console.WriteLine("");
          
        }

        private void CacteristicasPerro()
        {
            Ladrar = true;
            Carnivoro = true;
        }
    }
}
