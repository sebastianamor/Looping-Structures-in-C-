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

                // Ingresar datos de la mascota
                Console.WriteLine("\nIngrese los datos de la nueva mascota:");
                ourAnimals[nuevaPosicion, 0] = $"ID{nuevaPosicion}";
                ourAnimals[nuevaPosicion, 1] = animalSpecies;

                Console.Write("Edad: ");
                ourAnimals[nuevaPosicion, 2] = Console.ReadLine();

                Console.Write("Descripción física: ");
                ourAnimals[nuevaPosicion, 3] = Console.ReadLine();

                Console.Write("Descripción de personalidad: ");
                ourAnimals[nuevaPosicion, 4] = Console.ReadLine();

                Console.Write("Apodo: ");
                ourAnimals[nuevaPosicion, 5] = Console.ReadLine();

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
