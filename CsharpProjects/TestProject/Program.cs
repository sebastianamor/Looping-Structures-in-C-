string[,] ourAnimals = new string[8, 6]; // 8 mascotas, 6 atributos cada una
int maxPets = 8;
string menuSelection = "";

// Inicialización de datos de ejemplo (opcional)
for (int i = 0; i < 4; i++) // Solo inicializamos 4 mascotas como en tu ejemplo
{
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
            Console.Write("Ingrese número de animal (0-3): ");
            if (int.TryParse(Console.ReadLine(), out int petNumber) && petNumber >= 0 && petNumber <= 3)
            {
                Console.WriteLine($"\nDatos del animal {petNumber}:");
                Console.WriteLine($"1. Especie: {ourAnimals[petNumber, 0]}");
                Console.WriteLine($"2. ID: {ourAnimals[petNumber, 1]}");
                Console.WriteLine($"3. Edad: {ourAnimals[petNumber, 2]}");
                Console.WriteLine($"4. Descripción física: {ourAnimals[petNumber, 3]}");
                Console.WriteLine($"5. Descripción personalidad: {ourAnimals[petNumber, 4]}");
                Console.WriteLine($"6. Apodo: {ourAnimals[petNumber, 5]}");
                
                Console.Write("\n¿Qué campo desea editar? (1-6 o Enter para cancelar): ");
                string fieldToEdit = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(fieldToEdit) && int.TryParse(fieldToEdit, out int fieldNumber) 
                    && fieldNumber >= 1 && fieldNumber <= 6)
                {
                    Console.Write($"Ingrese nuevo valor para {GetFieldName(fieldNumber)}: ");
                    string newValue = Console.ReadLine();
                    ourAnimals[petNumber, fieldNumber - 1] = newValue;
                    Console.WriteLine("¡Cambio guardado!");
                }
            }
            else
            {
                Console.WriteLine("Número de animal inválido. Debe ser entre 0 y 3.");
            }
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