using System.Reflection.PortableExecutable;

namespace practica_POO;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        Guerrero1 guerrero1 = new Guerrero1("Martin", 20, 10);
        Guerrero2 guerrero2 = new Guerrero2("José", 22, 10);

        Console.WriteLine($"Pelea entre los guerreros {guerrero1.Nombre} y {guerrero2.Nombre}");

        Console.WriteLine("Vida inicial de los guerreros:");
        Console.WriteLine($"{guerrero1.Nombre}: {guerrero1.Vida}");
        Console.WriteLine($"{guerrero2.Nombre}: {guerrero2.Vida}");

        while (true)
        {
            int harm = rand.Next(1, 6);
            
            guerrero1.atacar(harm);
            guerrero2.Harm(harm);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - ");

            if(guerrero2.Vida <= 0)
            {
                Console.WriteLine($"{guerrero1.Nombre} ganó la batalla!");
                break;
            }

            harm = rand.Next(1, 6);


            guerrero2.atacar(harm);
            guerrero1.Harm(harm);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - ");

            if(guerrero1.Vida <= 0)
            {
                Console.WriteLine($"{guerrero2.Nombre} ganó la batalla!");
                break;
            }
        
        }
        

    }
}
