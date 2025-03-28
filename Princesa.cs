namespace practica_POO;

public class Princesa : Personaje
{
    public int Humor { get; set; }

    public Princesa(string nombre, int fuerza, int vida, int humor) : base(nombre, fuerza, vida)
    {
        this.Humor = humor;
    }

   public void Mood(int harm)
   {
        Humor -= harm * 2;
        Console.WriteLine($"La princesa {Nombre} fue herida en lugar de los guerros, su humor baja a {Humor}");
   }

}
