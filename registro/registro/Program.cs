public class Program
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();

        int opcion;

        do
        {
            Console.WriteLine("1.visitar nueva pagina");
            Console.WriteLine("2.Retroceder");
            Console.WriteLine("3.Mostrar actual");
            Console.WriteLine("4.Volver");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese URl");
                    string url = Console.ReadLine();
                    stack.Push(url);
                    Console.WriteLine($"Visitando {url}");
                    break;
                case 2:
                    if (stack.Count > 0)
                    {
                        string paginaanterir = stack.Pop();
                        Console.WriteLine($"Retrocediendo desde {paginaanterir}");
                    }
                    else
                    {
                        Console.WriteLine("no hay paginas");
                    }
                    break;
                case 3:
                    Console.WriteLine("Historial:\n");
                    foreach (var pagina in stack)
                    {
                        Console.WriteLine(pagina);
                    }
                    break;
            }
        }
        while (opcion != 4);

        Console.WriteLine("Pulse cualquier tecla para salir:");
        Console.ReadKey();
        
    }
}
