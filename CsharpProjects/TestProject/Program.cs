string[,] ourAnimals = new string[8, 6]; // 8 mascotas, 6 atributos cada una
int maxPets = 8;
string menuSelection = "";

// Inicialización de datos de ejemplo (opcional)
 for (int i = 0; i < maxPets; i++)
{
      // Solo inicializamos 4 mascotas como en tu ejemplo

    ourAnimals[i, 0] = "Perro"; // Especie
    ourAnimals[i, 1] = $"ID{i}"; // ID
    ourAnimals[i, 2] = $"{i+1} años"; // Edad
    ourAnimals[i, 3] = "Descripción física"; // Desc. física
    ourAnimals[i, 4] = "Descripción personalidad"; // Desc. personalidad
    ourAnimals[i, 5] = $"Mascota{i}"; // Apodo
}

do
{
    Console.WriteLine("\nMenú Principal:");
    Console.WriteLine("1. Ver/Editar animal");
    Console.WriteLine("2. Salir");
    Console.Write("Seleccione una opción: ");
    
    menuSelection = Console.ReadLine()?.Trim().ToLower(); // Normalizar entrada

    switch (menuSelection)
    {
        case "1":
    // List all of our current pet information
    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
    Console.WriteLine("Press the Enter key to continue.");
    readResult = Console.ReadLine();
    break;
            
        case "2":
        case "exit":
            Console.WriteLine("Saliendo del programa...");
            break;
            
        default:
            Console.WriteLine("Opción no válida. Por favor seleccione 1 o 2.");
            break;
    }
    
} while (menuSelection != "2" && menuSelection != "exit");

// Función auxiliar para nombres de campos
string GetFieldName(int fieldNumber)
{
    return fieldNumber switch
    {
        1 => "especie",
        2 => "ID",
        3 => "edad",
        4 => "descripción física",
        5 => "descripción de personalidad",
        6 => "apodo",
        _ => "campo desconocido"
    };
}