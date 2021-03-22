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
        public void metodoDeaguila()
        {
            Comer = true;
            Vertebrados = true;
            Volar = true;
            TienenPico = true;
            aguila();
            
        }

        private void aguila()
        {
            VolarAlto = true;
            PoseenGarras = true;

        }
    }
}   