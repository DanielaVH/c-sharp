using System;
namespace animales
{
   abstract class Mamiferos : Animal
    {
        public int Patas { get; set; }

        public bool TienenPelaje { get; set; }

        public bool Caminar { get; set; }

        public bool Viviparos { get; set; }

        
    }
}