namespace practica_POO;

class Guerrero2 : Personaje
{
    public Guerrero2(string nombre, int fuerza, int vida) : base(nombre, fuerza, vida)
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