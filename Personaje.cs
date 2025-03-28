namespace practica_POO;

public class Personaje
{
   public string Nombre { set; get; }
   public int Fuerza { set; get;}
   public int Vida { set; get; }

   public Personaje(string nombre, int fuerza, int vida)
   {
        this.Nombre = nombre;
        this. Fuerza = fuerza;
        this.Vida = vida;
   }
    
    public virtual void atacar(int harm)
    {
        Console.WriteLine($"{Nombre} ataca y su enemigo recibe {harm} de daño.");
    }
    public virtual void Harm(int harm)
    {
        Vida -= harm;
        Console.WriteLine($"Vida restante de {Nombre}: {Vida}");
    }
}