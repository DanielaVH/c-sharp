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

        public void metodoDegato()
        {
            Comer = true;
            Vertebrados = true;
            TienenPelaje = true;
            Caminar = true;
            Viviparos = true;
            gato();
        }

        private void gato()
        {
            Maullar = true;
            TienenBigote = true;
        }
    }
}
