string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

int maxPets = 8;
string? readResult;
string menuSelection = "";
int i = 0; // Variable añadida
string[,] ourAnimals = new string[maxPets, 6];

do
{
    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("1. Ver/Editar animal");
    Console.WriteLine("2. Salir");
    menuSelection = Console.ReadLine();

    if (menuSelection == "1")
    {
        Console.WriteLine("Ingrese número de animal (0-3):");
        if (int.TryParse(Console.ReadLine(), out i) && i >= 0 && i <= 3)
        {
            switch (i)
            {
                case 0:
                    animalSpecies = "dog";
                    animalID = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickname = "lola";
                    break;

                case 1:
                    animalSpecies = "dog";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                    animalNickname = "loki";
                    break;

                case 2:
                    animalSpecies = "cat";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "Puss";
                    break;

                case 3:
                    animalSpecies = "cat";
                    animalID = "c4";
                    animalAge = "?";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;
            }

            // Guardar en array
            ourAnimals[i, 0] = animalSpecies;
            ourAnimals[i, 1] = animalID;
            ourAnimals[i, 2] = animalAge;
            ourAnimals[i, 3] = animalPhysicalDescription;
            ourAnimals[i, 4] = animalPersonalityDescription;
            ourAnimals[i, 5] = animalNickname;

            // Mostrar datos
            Console.WriteLine($"\nAnimal {i}:");
            Console.WriteLine($"Especie: {animalSpecies}");
            Console.WriteLine($"Apodo: {animalNickname}");
        }
        else
        {
            Console.WriteLine("Número de animal inválido");
        }
    }

} while (menuSelection != "2" && menuSelection != "exit");