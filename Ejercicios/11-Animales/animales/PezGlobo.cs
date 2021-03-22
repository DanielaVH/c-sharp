using System;
namespace animales
{
    class PezGlobo : Peces
    {
        public bool Inflarse { get; set; }

         public bool SonToxicos { get; set; }

         public PezGlobo(string nombre, int numeroAletas)
        {
            Nombre = nombre;
            NumeroAletas = numeroAletas;
        }
        public void MetodoPezGlobo()
        {
            Vertebrados = true;
            Comer = true;
            Nadar = true;
            TienenEscamas = true;
            FuncionPezGlobo();
        }
         private void FuncionPezGlobo()
        {
            Inflarse = true;
            SonToxicos =true;
        }
    }
}
