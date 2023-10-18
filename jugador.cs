public class Jugador
{
    public string Nombre { get; }
    public List<Carta> Mano { get; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
        Mano = new List<Carta>();
    }

    public Carta RobarCarta(Mazo mazo)
    {
        Carta cartaRobada = mazo.RepartirCartaMasAlta();

        if (cartaRobada != null)
        {
            Mano.Add(cartaRobada);
        }

        return cartaRobada;
    }

    public Carta DescartarCarta(int indice)
    {
        if (indice >= 0 && indice < Mano.Count)
        {
            Carta cartaDescartada = Mano[indice];
            Mano.RemoveAt(indice);
            return cartaDescartada;
        }

        return null;
    }

    public void ImprimirMano()
    {
        Console.WriteLine($"Mano de {Nombre}:");
        foreach (var carta in Mano)
        {
            carta.Print();
        }
    }
}