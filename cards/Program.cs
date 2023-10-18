class Program
{
    static void Main()
    {
        Mazo mazo = new Mazo();
        mazo.BarajarMazo();

        Jugador jugador = new Jugador("Jugador1");

        Console.WriteLine("Robando 3 cartas:");
        for (int i = 0; i < 3; i++)
        {
            Carta cartaRobada = jugador.RobarCarta(mazo);
            if (cartaRobada != null)
            {
                cartaRobada.Print();
            }
        }

        jugador.ImprimirMano();

        Console.WriteLine("\nDescartando la primera carta:");
        Carta cartaDescartada = jugador.DescartarCarta(0);
        if (cartaDescartada != null)
        {
            cartaDescartada.Print();
        }
        else
        {
            Console.WriteLine("No se pudo descartar la carta (índice no válido).");
        }

        jugador.ImprimirMano();
    }
}

