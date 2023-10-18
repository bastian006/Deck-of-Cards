public class Carta
{
    public string Nombre { get; }
    public string Pinta { get; }
    public int Valor { get; }

    public Carta(string nombre, string pinta, int valor)
    {
        Nombre = nombre;
        Pinta = pinta;
        Valor = valor;
    }

    public void Print()
    {
        Console.WriteLine($"Carta: {Nombre} de {Pinta} ({Valor})");
    }
}