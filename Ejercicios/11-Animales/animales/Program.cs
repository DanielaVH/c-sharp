using System;
namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
          Perro p = new Perro("Zeus",4);
            p.metodoDeperro();
            Console.WriteLine("Nombre perro: " + p.Nombre);
            Console.WriteLine("Cantidad de patas: " + p.Patas);
            Console.WriteLine("¿Puede comer? " + p.Comer);
            Console.WriteLine("¿Es un animal vertebrado?  " + p.Vertebrados);
            Console.WriteLine("¿Tiene Pelaje?  " + p.TienenPelaje);
            Console.WriteLine("¿Puede caminar? " + p.Caminar);
            Console.WriteLine("¿Es un animal Viviparo? " + p.Viviparos);
            Console.WriteLine("¿Puede Ladrar? " + p.Ladrar);
            Console.WriteLine("¿Es una animal carnivoro? " + p.Carnivoro);
            Console.WriteLine("");

            Gato g = new Gato("Coco",4);
            g.metodoDegato();
            Console.WriteLine("Nombre del gato: " + g.Nombre);
            Console.WriteLine("Numero de patas: " + g.Patas);
            Console.WriteLine("¿Puede Comer? " + g.Comer);
            Console.WriteLine("¿Es un animal Vertebrado? " + g. Vertebrados);
            Console.WriteLine("¿Tiene Pelaje? " + g.TienenPelaje);
            Console.WriteLine("¿Puede caminar? " + g.Caminar);
            Console.WriteLine("¿Es viviparo? " + g.Viviparos);
            Console.WriteLine("¿Puede Maullar? " + g.Maullar);
            Console.WriteLine("¿Tiene Bigote? " + g.TienenBigote);
            Console.WriteLine("");

            Mono m = new Mono("Jorge",2);
            m.metodoDemono();
            Console.WriteLine("Nombre del mono: " + m.Nombre);
            Console.WriteLine("Numero de patas: " + m.Patas);
            Console.WriteLine("Puede comer? " + m.Comer);
            Console.WriteLine("¿Es un animal vertebrado? " + m.Vertebrados);
            Console.WriteLine("¿Tiene Pelaje? " + m.TienenPelaje);
            Console.WriteLine("Puede caminar? " + m.Caminar);
            Console.WriteLine("¿Es un animal Viviparo? " + m.Viviparos);
            Console.WriteLine("");

            Aguila a = new Aguila("Aguila Real","Castano y Dorado");
            a.metodoDeaguila();
            Console.WriteLine("Nombre del aguila: " + a.Nombre);
            Console.WriteLine("Color del Plumaje: " + a.ColorPlumaje);
            Console.WriteLine("¿Puede comer? " + a.Comer);
            Console.WriteLine("¿Es un animal vertebrado? " + a.Vertebrados);
            Console.WriteLine("¿Este animal Puede volar? " + a.Volar);
            Console.WriteLine("¿Tiene Pico? " + a.TienenPico);
            Console.WriteLine("");
           
            Loro L = new Loro("Chachi","Verde, Rojo y Azul");
            L.metodoDeloro();
            Console.WriteLine("Nombre del Loro: " + L.Nombre);
            Console.WriteLine("Color del Plumaje: " + L.ColorPlumaje);
            Console.WriteLine("¿Pude comer? " + L.Comer);
            Console.WriteLine("¿Es un animal vertebrado? " + L.Vertebrados);
            Console.WriteLine("¿Puede volar? " + L.Volar);
            Console.WriteLine("¿Puede hablar? " + L.Hablar);
            Console.WriteLine("¿Tiene Pico?" + L.TienenPico);
            Console.WriteLine("");

            PezGlobo PG = new PezGlobo("Tetraodontidae",2);
            PG.MetodoPezGlobo();
            Console.WriteLine("Nombre del pez globo: " + PG.Nombre);
            Console.WriteLine("Cantidad de aletas: " + PG.NumeroAletas);
            Console.WriteLine("¿Es un animal vertebrado? " + PG.Vertebrados);
            Console.WriteLine("¿Puede comer? " + PG.Comer);
            Console.WriteLine("¿Puede Nadar? " + PG.Nadar);
            Console.WriteLine("¿Tiene escamas? " + PG.TienenEscamas);
            Console.WriteLine("¿Puede inflarse? " + PG.Inflarse);
            Console.WriteLine("¿Es toxico? " + PG.SonToxicos);
            Console.WriteLine("");

        }
    }
}