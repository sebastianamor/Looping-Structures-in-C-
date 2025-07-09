// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

string[][] jaggedArray = new string[][]
{
    new string[] { "one1", "two1", "three1", "four1", "five1", "six1" },
    new string[] { "one2", "two2", "three2", "four2", "five2", "six2" },
    new string[] { "one3", "two3", "three3", "four3", "five3", "six3" },
    new string[] { "one4", "two4", "three4", "four4", "five4", "six4" },
    new string[] { "one5", "two5", "three5", "four5", "five5", "six5" },
    new string[] { "one6", "two6", "three6", "four6", "five6", "six6" },
    new string[] { "one7", "two7", "three7", "four7", "five7", "six7" },
    new string[] { "one8", "two8", "three8", "four8", "five8", "six8" }
};

do
{

for (int i = 0; i < maxPets; i++) {


if (ourAnimals[i, 0] != "ID #: ")
    {
        Console.WriteLine(ourAnimals[i, 0]);

switch (menuSelection)
{
    case "1":
        // List all of our current pet information
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "2":
        // List all of our current pet information
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

       case "3":
       Console.WriteLine("Challenge Project - please check back soon to see progress.");
       Console.WriteLine("Press the Enter key to continue.");
       readResult = Console.ReadLine();

        break;

    case "4":
    Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
    Console.WriteLine("Press the Enter key to continue.");
    readResult = Console.ReadLine();

        break;

     default:
        break;
      }
         }
         }

          } while (menuSelection != "exit");

// Inicialización de datos de ejemplo (opcional)




