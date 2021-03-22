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

        public void metodoDemono()
        {
            Comer = true;
            Vertebrados = true;
            TienenPelaje = true;
            Caminar = true;
            Viviparos = true;
            mono();
        }

        private void mono()
        {
            Maullar = true;
            Omnivoros = true;
        }
    }
}