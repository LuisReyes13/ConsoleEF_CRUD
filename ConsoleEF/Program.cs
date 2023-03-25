// See https://aka.ms/new-console-template for more information
using ConsoleEF.Models;
using Microsoft.EntityFrameworkCore;

Console.ForegroundColor = ConsoleColor.Green;

using (var conext = new CrudContext())
{
    /*
    // Insertar
    var p = new Prueba();
    p.Nombre = "Slider";
    p.Edad = 29;
    p.Correo = "slider@gmail.com";
    conext.Pruebas.Add(p);
    conext.SaveChanges();
    */

    /*
    // Actualizar
    var p = conext.Pruebas.Find(4);
    p.Nombre = "Sli";
    p.Edad = 17;
    p.Correo = "slii12@gmail.com";
    conext.Pruebas.Entry(p).State = EntityState.Modified;
    conext.SaveChanges();
    */

    /*
    // Eliminar
    var p = conext.Pruebas.Find(2);
    conext.Remove(p);
    conext.SaveChanges();
    */

    // Recorrer registros y mostrar
    foreach (var prueba in conext.Pruebas.ToList())
    {
        Console.WriteLine($"{prueba.Id}  - {prueba.Nombre}  - {prueba.Edad}  - {prueba.Correo}");
    }

    int opcion = 0;

    do
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Insertar registro");
        Console.WriteLine("2. Actualizar registro");
        Console.WriteLine("3. Eliminar Registro");
        Console.WriteLine("4. Salir");
        Console.Write("Ingrese su opción: ");

        // Validar la entrada del usuario
        if (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Opción inválida. Ingrese un número válido.");
            Console.ReadKey();
            continue;
        }

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ha seleccionado la Opción 1");
                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("Ha seleccionado la Opción 2");
                Console.ReadKey();
                break;
            case 3:
                Console.WriteLine("Ha seleccionado la Opción 3");
                Console.ReadKey();
                break;
            case 4:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción inválida. Seleccione una opción válida.");
                Console.ReadKey();
                break;
        }

        Console.Clear(); // Limpiar la consola
    } while (opcion != 4);

    static int ValidarEntero()
    {
        int entero;

        while (!int.TryParse(Console.ReadLine(), out entero))
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.");
        
        return entero;
    }
}
