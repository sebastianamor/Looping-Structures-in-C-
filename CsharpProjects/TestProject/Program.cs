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
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                  {  petCount += 1;

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
            // Lógica para agregar nueva mascota
            Console.WriteLine("\nFunción en desarrollo - próximamente");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
            break;

        case "3":
            // Lógica para editar mascota
            Console.WriteLine("\nFunción en desarrollo - próximamente");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
            break;

        case "4":
            // Lógica para buscar mascotas
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
    }
} while (menuSelection != "exit");
