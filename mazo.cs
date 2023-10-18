public class Mazo
{
    public List<Carta> Cartas { get; }

    public Mazo()
    {
        Cartas = new List<Carta>();
        ReiniciarMazo();
    }

    public void ReiniciarMazo()
    {
        Cartas.Clear();
        string[] pintas = { "Corazones", "Diamantes", "Tréboles", "Picas" };

        foreach (var pinta in pintas)
        {
            for (int valor = 1; valor <= 13; valor++)
            {
                Cartas.Add(new Carta(valor.ToString(), pinta, valor));
            }
        }
    }

    public Carta RepartirCartaMasAlta()
    {
        if (Cartas.Count == 0)
        {
            Console.WriteLine("El mazo está vacío. No se pueden repartir más cartas.");
            return null;
        }

        Carta cartaMasAlta = Cartas.MaxBy(carta => carta.Valor);
        Cartas.Remove(cartaMasAlta);
        return cartaMasAlta;
    }

    public void BarajarMazo()
    {
        Random random = new Random();
        int n = Cartas.Count;

        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Carta carta = Cartas[k];
            Cartas[k] = Cartas[n];
            Cartas[n] = carta;
        }
    }

    public void ImprimirMazo()
    {
        foreach (var carta in Cartas)
        {
            carta.Print();
        }
    }
}