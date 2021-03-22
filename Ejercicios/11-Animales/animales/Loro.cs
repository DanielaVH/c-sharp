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
        public void metodoDeloro()
        {
            Comer = true;
            Vertebrados = true;
            Volar = true;
            TienenPico = true;
            loro();
            
        }

        private void loro()
        {
            Hablar = true;
    

        }
    }
}   