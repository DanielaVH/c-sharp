using System;
namespace animales
{
   abstract class Aves : Animal
    {

        public string ColorPlumaje { get; set; }

        public bool Volar { get; set; }

        public bool TienenPico { get; set; }
    }
}