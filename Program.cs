using Monedas;
using System.Timers;

class Program
{
    static void Main(String[] args)
    {
        Moneda moneda = new Moneda();
        moneda.calcularMonedas();

        Grafo grafo = new Grafo();

        grafo.AgregarArista("Arad", "Zerind", 75);
        grafo.AgregarArista("Arad", "Timisoara", 118);
        grafo.AgregarArista("Arad", "Sibiu", 140);
        grafo.AgregarArista("Zerind", "Oradea", 71);
        grafo.AgregarArista("Timisoara", "Lugoj", 111);
        grafo.AgregarArista("Oradea", "Sibiu", 151);
        grafo.AgregarArista("Lugoj", "Mehadia", 70);
        grafo.AgregarArista("Sibiu", "Rimnicu Vilcea", 80);
        grafo.AgregarArista("Sibiu", "Fagaras", 99);
        grafo.AgregarArista("Mehadia", "Drobeta", 75);
        grafo.AgregarArista("Rimnicu Vilcea", "Craiova", 146);
        grafo.AgregarArista("Craiova", "Pitesti", 138);
        grafo.AgregarArista("Pitesti", "Bucharest", 101);
        grafo.AgregarArista("Fagaras", "Bucharest", 211);
        grafo.AgregarArista("Rimnicu Vilcea", "Pitesti", 97);
        grafo.AgregarArista("Drobeta", "Craiova", 120);

        var distancias = grafo.Dijkstra("Arad");

        Console.WriteLine("Ingrese la ciudad para mostrar su recorrido:");
        string ciudad = Console.ReadLine();

        if (distancias.ContainsKey(ciudad))
        {
            var recorrido = grafo.Recorrido(ciudad, distancias);
            Console.WriteLine("Recorrido para la ciudad " + ciudad + ":");
            foreach (var c in recorrido)
                Console.Write(c + " -> ");
            Console.WriteLine("Fin");
        }
        else
        {
            Console.WriteLine("Ciudad no encontrada.");
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}


