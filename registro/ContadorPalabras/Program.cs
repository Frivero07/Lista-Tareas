public class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un texto");
        string texto = Console.ReadLine();

       
        IDictionary<string,int> contadorpalabras = new Dictionary<string,int>();
        string[] palabras = texto.Split('');

        foreach (string palabra in palabras)
        {
            if (contadorpalabras.ContainsKey(palabra))
            {
                contadorpalabras[palabra]++;
            }
            else
            {
                contadorpalabras.Add(palabra, 1);
            }
        }
         Console.WriteLine("Frecuencia de palabras:");
        foreach (var entrada in contadorpalabras)
        {
            Console.WriteLine($"{entrada.Key},{entrada.Value}");



        int opcion;
        do
        {
            Console.WriteLine("1. Leer cadena");
            Console.WriteLine("2. Contar");
            Console.WriteLine("3. Mostar lista");
            Console.WriteLine("4.Volver");

            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    

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
                    foreach (var cliente in colacliente)
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
