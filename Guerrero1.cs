namespace practica_POO;

class Guerrero1 : Personaje
{
    public Guerrero1(string nombre, int fuerza, int vida) : base(nombre, fuerza, vida)
    {

    }

    public override void atacar(int harm)
    {
        base.atacar(harm);
    }

    public override void Harm(int harm)
    {
        base.Harm(harm);
    }
}
