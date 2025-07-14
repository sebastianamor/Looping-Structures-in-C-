// Datos de mascotas
const int maxPets = 8;
string[,] ourAnimals = new string[maxPets, 6];
string anotherPet = "y";
int petCount = 0;

// Inicializar array con datos de ejemplo
for (int i = 0; i < 4; i++) // Solo inicializamos 4 mascotas como ejemplo
{
    ourAnimals[i, 0] = $"ID{i}"; // ID
    ourAnimals[i, 1] = i % 2 == 0 ? "Perro" : "Gato"; // Especie
    ourAnimals[i, 2] = $"{i + 1} años"; // Edad
    ourAnimals[i, 3] = i % 2 == 0 ? "Pequeño, pelo corto" : "Mediano, pelo largo"; // Desc. física
    ourAnimals[i, 4] = i % 2 == 0 ? "Juguetón" : "Tranquilo"; // Desc. personalidad
    ourAnimals[i, 5] = $"Mascota{i}"; // Apodo
}

string menuSelection = "";
do
{
    Console.WriteLine("\nMenú Principal:");
    Console.WriteLine("1. Listar todas las mascotas");
    Console.WriteLine("2. Agregar nueva mascota");
    Console.WriteLine("3. Editar mascota existente");
    Console.WriteLine("4. Buscar mascotas");
    Console.WriteLine("exit - Salir del programa");
    Console.Write("Seleccione una opción: ");

    menuSelection = Console.ReadLine()?.Trim().ToLower();

    switch (menuSelection)
{
    case "1":
        Console.WriteLine("\nListado de Mascotas:");
        // Mostrar todas las mascotas existentes
        for (int i = 0; i < maxPets; i++)
        {
            if (!string.IsNullOrEmpty(ourAnimals[i, 0]))
            {
                Console.WriteLine($"\nMascota {i}:");
                Console.WriteLine($"ID: {ourAnimals[i, 0]}");
                Console.WriteLine($"Especie: {ourAnimals[i, 1]}");
                Console.WriteLine($"Edad: {ourAnimals[i, 2]}");
                Console.WriteLine($"Descripción física: {ourAnimals[i, 3]}");
                Console.WriteLine($"Personalidad: {ourAnimals[i, 4]}");
                Console.WriteLine($"Apodo: {ourAnimals[i, 5]}");
            }
        }
        Console.WriteLine("\nPresione Enter para continuar...");
        Console.ReadLine();
        break;
        
    case "2":
        // Agregar nueva mascota
        int petCount = 0;
        for (int i = 0; i < maxPets; i++)
        {
            if (!string.IsNullOrEmpty(ourAnimals[i, 0]))
            {
                petCount++;
            }
        }

        if (petCount < maxPets)
        {
            Console.WriteLine($"Actualmente tenemos {petCount} mascotas. Podemos aceptar {(maxPets - petCount)} más.");
            
            // Aquí iría el código para recolectar los datos de la nueva mascota
            Console.WriteLine("\nPor favor ingrese los datos de la nueva mascota:");
            // ... (código para ingresar cada campo)
        }
        else
        {
            Console.WriteLine("¡Hemos alcanzado el límite máximo de mascotas!");
        }
        
        Console.WriteLine("Presione Enter para continuar.");
        Console.ReadLine();
        break;

    case "3":
        Console.WriteLine("\nFunción en desarrollo - próximamente");
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
        break;

    case "4":
        Console.WriteLine("\nFunción en desarrollo - próximamente");
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
        break;

    case "exit":
        Console.WriteLine("\nSaliendo del programa...");
        break;

    default:
        Console.WriteLine("\nOpción no válida. Por favor intente nuevamente.");
        break;
}  } 
} while (menuSelection != "exit");
