public class Tarea
{
    public string Titulo { get; private set; }
    public bool Estado { get; set; }

    public Tarea(string titulo)
    {
        Titulo = titulo;
        Estado = false;
    }
    public class Program
    {
        static void Main()
        {
            List<Tarea> Tareas = new List<Tarea>();
            int opcion;
            do
            {
                Console.WriteLine("1. AgregarTarea");
                Console.WriteLine("2. Marcar Completada");
                Console.WriteLine("3. Mostrar Pendientes");
                Console.WriteLine("4.Volver");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese titulo");
                        string titulo = Console.ReadLine();
                        Tarea tarea = new Tarea(titulo);
                        Tareas.Add(tarea);
                        break;
                    case 2:
                        Console.WriteLine("ingrese tareas");
                        int numero = int.Parse(Console.ReadLine()) - 1;
                        if (numero >= 0 && numero < Tareas.Count)
                        {
                            //elije la posicion de la mlista 
                            Tareas[numero].Estado = true;
                            Console.WriteLine("Completada");
                        }
                        else
                        {
                            Console.WriteLine("Numero invalido");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Tareas Pendientes:\n");
                        for (int i = 0; i < Tareas.Count; i++)
                        {
                            if (!Tareas[i].Estado)
                            {
                                Console.WriteLine($"{i + 1}.{Tareas[i].Titulo}");
                            }

                        }
                        break;
                }
            }
            while (opcion != 4);

            Console.WriteLine("Pulse cualquier tecla para salir:");
            Console.ReadKey();
        }
    }
}

        

    

