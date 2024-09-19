using System.Collections;
using System.Threading;
using System.Linq;
public class Cliente
{
    public string Nombre { get; set; }
    public int NumeroCliente { get; set; }

    public Cliente (string nombre,int numerocliente)
    {
        Nombre = nombre;
        NumeroCliente = numerocliente;
    }

}

public class Program
{
    static void Main()
    {
        Queue<Cliente> colacliente = new Queue<Cliente>();
        int opcion;
        do
        {
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Atender Cliente");
            Console.WriteLine("3. Mostrar cola");
            Console.WriteLine("4.Volver");

            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Agregar Cliente");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Agregar Numero Cliente");
                    int numerocliente = int.Parse(Console.ReadLine());
                    Cliente c = new Cliente(nombre, numerocliente);
                    colacliente.Enqueue(c);
                    Console.WriteLine($"agregando cliente  {c}");

                    break;
                case 2:
                    if (colacliente.Count > 0)
                    {
                        
                        Cliente clienteatendido = colacliente.Dequeue();
                        Console.WriteLine($"atendiendo a {clienteatendido.Nombre},{clienteatendido.NumeroCliente} ");
                    }
                    else
                    {
                        Console.WriteLine("no hay clientes");
                    }

                    break;
                case 3:
                    Console.WriteLine("Clientes en la cola:");
                    foreach (var cliente  in colacliente)
                    {
                        Console.WriteLine($"{cliente.Nombre},{cliente.NumeroCliente}");
                    }

                    break;
            }
        }
        while (opcion != 4);

        Console.WriteLine("Pulse cualquier tecla para salir:");
        Console.ReadKey();
    }
}
    

