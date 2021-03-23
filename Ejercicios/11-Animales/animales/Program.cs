using System;
namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
           Perro p = new Perro("Zeus",4);
           p.MetodoDeperro();

            Gato g = new Gato("Coco",4);
            g.MetodoDegato();
            

            Mono m = new Mono("Jorge",2);
            m.MetodoDemono();
           

            Aguila a = new Aguila("Aguila Real","Castano y Dorado");
            a.MetodoDeaguila();
         
           
            Loro L = new Loro("Chachi","Verde, Rojo y Azul");
            L.MetodoDeloro();
          
            PezGlobo PG = new PezGlobo("Tetraodontidae",2);
            PG.MetodoPezGlobo();
           

        }
    }
}