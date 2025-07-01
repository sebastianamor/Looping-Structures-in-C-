﻿// the ourAnimals array will store the following: 
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

    default:
    animalSpecies = "";
    animalID = "";
    animalAge = "";
    animalPhysicalDescription = "";
    animalPersonalityDescription = "";
    animalNickname = "";
    break;

}
