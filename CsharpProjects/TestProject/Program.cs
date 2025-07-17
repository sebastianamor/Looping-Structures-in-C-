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
            // ... (código existente para listar mascotas)
            break;

        case "2":
            string otraMascota = "s";
            do
            {
                int contadorMascotas = 0;
                for (int i = 0; i < maxPets; i++)
                {
                    if (!string.IsNullOrEmpty(ourAnimals[i, 0]))
                    {
                        contadorMascotas++;
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

                int nuevaPosicion = -1;
                for (int i = 0; i < maxPets; i++)
                {
                    if (string.IsNullOrEmpty(ourAnimals[i, 0]))
                    {
                        nuevaPosicion = i;
                        break;
                    }
                }

                Console.WriteLine("\nIngrese los datos de la nueva mascota:");
                Console.Write("ID: ");
                ourAnimals[nuevaPosicion, 0] = Console.ReadLine();
                Console.Write("Especie: ");
                ourAnimals[nuevaPosicion, 1] = Console.ReadLine();
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
                    Console.Write("¿Desea agregar otra mascota? (s/n): ");
                    otraMascota = Console.ReadLine()?.Trim().ToLower();
                }
                else
                {
                    Console.WriteLine("\n¡Hemos alcanzado el límite máximo de mascotas!");
                    otraMascota = "n";
                }
            } while (otraMascota == "s");
            // get species (cat or dog) - string animalSpecies is a required field 
do
{
    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        animalSpecies = readResult.ToLower();
        if (animalSpecies != "dog" && animalSpecies != "cat")
        {
            //Console.WriteLine($"You entered: {animalSpecies}.");
            validEntry = false;
        }
        else
        {
            validEntry = true;
        }
    }
} while (validEntry == false);

            Console.WriteLine("Presione Enter para continuar.");
            Console.ReadLine();
            break;

        case "3":
            // ... (código existente para editar)
            break;

        case "4":
            // ... (código existente para buscar)
            break;

        case "exit":
            Console.WriteLine("\nSaliendo del programa...");
            break;

        default:
            Console.WriteLine("\nOpción no válida. Por favor intente nuevamente.");
            break;
    }
} while (menuSelection != "exit");
