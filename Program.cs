using System;

class Mascota
{
    // Atributos
    public string nombre;
    public int edad;
    public string tipo;
    public string sonido;

    // Constructar
    public Mascota(string nom, int ed, string tp, string son)
    {
        nombre = nom;
        edad = ed;
        tipo = tp;
        sonido = son;
    }

    // Metodo para emitir sonido
    public void emitirSonido()
    {
        Console.WriteLine(sonido);
    }

    // Metodo para mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine($"nombre: {nombre}");
        Console.WriteLine($"edad: {edad}");
        Console.WriteLine($"tipo: {tipo}");
    }
}

class Program
{
    static void Main()
    {
        // Crear una mascota
        Mascota miMascota = new Mascota("Firulais", 3, "Perro", "Guau!");

        // Mostrar informacion
        miMascota.MostrarInformacion();

        // Emitir sonido
        miMascota.emitirSonido();
    }
}

