using System;

class SuperHeroe
{
    public string Nombre { get; set; }
    public string IdentidadSecreta { get; set; }
    public string Ciudad { get; set; }
    public bool PuedeVolar { get; set; }
    public SuperPoder SuperPoder { get; set; }

    public SuperHeroe(string nombre, string identidadSecreta, string ciudad, bool puedeVolar, SuperPoder superPoder)
    {
        Nombre = nombre;
        IdentidadSecreta = identidadSecreta;
        Ciudad = ciudad;
        PuedeVolar = puedeVolar;
        SuperPoder = superPoder;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre del Superhéroe: " + Nombre);
        Console.WriteLine("Identidad Secreta: " + IdentidadSecreta);
        Console.WriteLine("Ciudad: " + Ciudad);
        Console.WriteLine("Puede Volar: " + (PuedeVolar ? "Sí" : "No"));
        Console.WriteLine("Super Poder:");
        Console.WriteLine(" - Nombre: " + SuperPoder.Nombre);
        Console.WriteLine(" - Descripción: " + SuperPoder.Descripcion);
        Console.WriteLine(" - Nivel: " + SuperPoder.Nivel);
        Console.WriteLine();
    }
}

class SuperPoder
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Nivel { get; set; }

    public SuperPoder(string nombre, string descripcion, int nivel)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Nivel = nivel;
    }

    public SuperPoder()
    {
    }
}

class Program
{
    static void Main(string[] args)
    {

        SuperPoder poder1 = new()
        {
            Nombre = "Super Fuerza",
            Descripcion = "Capacidad de levantar objetos muy pesados",
            Nivel = 9
        };

        SuperPoder poder2 = new()
        {
            Nombre = "Super Velocidad",
            Descripcion = "Puede moverse a una velocidad asombrosa por efecto de la luz",
            Nivel = 5
        };

        SuperPoder poder3 = new ()
        {
            Nombre = "Resistencia sobrehumana",
            Descripcion = "Fuerza, velocidad, reflejos y resistencia sobrehumna. Proyección de energía. Inmunidad a la radiación, frío y calor.",
            Nivel = 8
        };


        SuperHeroe heroe1 = new SuperHeroe("Superman", "Clark Kent", "Metropolis", true, poder1);
        SuperHeroe heroe2 = new SuperHeroe("Flash", "Barry Allen", "Central City", false, poder2);
        SuperHeroe heroe3 = new SuperHeroe("Starfire", "Koriand'r", "La Torre de los Titanes, California", true, poder3);


        heroe1.MostrarInformacion();
        heroe2.MostrarInformacion();
        heroe3.MostrarInformacion();
    }
}