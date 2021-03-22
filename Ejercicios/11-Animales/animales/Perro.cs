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

        public void metodoDeperro()
        {
            Comer = true;
            Vertebrados = true;
            TienenPelaje = true;
            Caminar = true;
            Viviparos = true;
            perro();
        }

        private void perro()
        {
            Ladrar = true;
            Carnivoro = true;
        }
    }
}
