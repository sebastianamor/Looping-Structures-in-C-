// Datos de mascotas
const int maxPets = 8;
string[,] ourAnimals = new string[maxPets, 6];

// Inicializar array con datos de ejemplo
for (int i = 0; i < 4; i++)
{
    ourAnimals[i, 0] = $"ID{i}";
    ourAnimals[i, 1] = i % 2 == 0 ? "Perro" : "Gato";
    ourAnimals[i, 2] = $"{i + 1} años";
    ourAnimals[i, 3] = i % 2 == 0 ? "Pequeño, pelo corto" : "Mediano, pelo largo";
    ourAnimals[i, 4] = i % 2 == 0 ? "Juguetón" : "Tranquilo";
    ourAnimals[i, 5] = $"Mascota{i}";
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
            string otraMascota;
            do
            {
                int contadorMascotas = 0;
                int nuevaPosicion = -1;

                // Contar mascotas y encontrar posición vacía
                for (int i = 0; i < maxPets; i++)
                {
                    if (!string.IsNullOrEmpty(ourAnimals[i, 0]))
                    {
                        contadorMascotas++;
                    }
                    else if (nuevaPosicion == -1)
                    {
                        nuevaPosicion = i;
                    }
                }

                if (contadorMascotas >= maxPets)
                {
                    Console.WriteLine("\n¡Hemos alcanzado el límite máximo de mascotas!");
                    break;
                }

                Console.WriteLine(
                    $"\nActualmente tenemos {contadorMascotas} mascotas. Podemos aceptar {(maxPets - contadorMascotas)} más."
                );

                // Validar especie (perro o gato)
                string animalSpecies;
                bool validEntry;
                do
                {
                    Console.Write("\nIngrese especie (perro/gato): ");
                    animalSpecies = Console.ReadLine()?.Trim().ToLower();
                    validEntry = animalSpecies == "perro" || animalSpecies == "gato";
                    if (!validEntry)
                    {
                        Console.WriteLine("Especie no válida. Por favor ingrese 'perro' o 'gato'.");
                    }
                } while (!validEntry);

                // Generar ID (P1, P2, G3, etc.)
                string animalID =
                    animalSpecies.Substring(0, 1).ToUpper() + (contadorMascotas + 1).ToString();

                // Obtener edad (puede ser ? si se desconoce)
                string animalAge;
                do
                {
                    Console.Write("Ingrese la edad de la mascota o ? si se desconoce: ");
                    animalAge = Console.ReadLine()?.Trim();
                    if (animalAge != "?")
                    {
                        validEntry = int.TryParse(animalAge, out _);
                        if (!validEntry)
                        {
                            Console.WriteLine("Edad no válida. Ingrese un número o ?.");
                        }
                    }
                    else
                    {
                        validEntry = true;
                    }
                } while (!validEntry);

                // Obtener descripción física
                Console.Write("Descripción física: ");
                string animalPhysicalDescription = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(animalPhysicalDescription))
                {
                    animalPhysicalDescription = "Por determinar";
                }

                // Obtener descripción de personalidad
                Console.Write("Descripción de personalidad (gustos, energía, etc.): ");
                string animalPersonalityDescription = Console.ReadLine()?.Trim().ToLower();
                if (string.IsNullOrEmpty(animalPersonalityDescription))
                {
                    animalPersonalityDescription = "Por determinar";
                }

                // Obtener apodo
                Console.Write("Apodo: ");
                string animalNickname = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(animalNickname))
                {
                    animalNickname = "Sin apodo";
                }

                // Guardar todos los datos
                ourAnimals[nuevaPosicion, 0] = animalID;
                ourAnimals[nuevaPosicion, 1] = animalSpecies;
                ourAnimals[nuevaPosicion, 2] = animalAge;
                ourAnimals[nuevaPosicion, 3] = animalPhysicalDescription;
                ourAnimals[nuevaPosicion, 4] = animalPersonalityDescription;
                ourAnimals[nuevaPosicion, 5] = animalNickname;

                Console.WriteLine("\n¡Mascota agregada exitosamente!");

                if (contadorMascotas + 1 < maxPets)
                {
                    Console.Write("\n¿Desea agregar otra mascota? (s/n): ");
                    otraMascota = Console.ReadLine()?.Trim().ToLower();
                }
                else
                {
                    Console.WriteLine("\n¡Hemos alcanzado el límite máximo de mascotas!");
                    otraMascota = "n";
                }
            } while (otraMascota == "s");

            Console.WriteLine("\nPresione Enter para continuar...");
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
    }
} while (menuSelection != "exit");
