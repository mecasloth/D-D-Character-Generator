using System;

//This isn't normal spaghetti code
//this is advanced spaghetti code

//in all seriousness, this is my first c# coding experience. Largely using a lot of the brackkey's c# tutorial. It isn't much, but I like to think I'll be using at least some sort of
//version of this code in the future if I ever do an RPG. 
//This also started life as a test in making a random number generator to make d&d characters with. But as you can see, it has ballooned especially with the Overly Complex Pronoun System (OCPS).
//I think the OCPS is my favorite creation that has spawned from this, if a bit unwieldy. 

namespace Random_Number_Geneator
{
    class Program
    {
        // I put this here so everything in the class can access the same instance of Random.
        static readonly Random numberGen = new Random();

        static void Main(string[] args)
        {
            int[] bonus = {-5,-5,-4,-4,-3,-3,-2,-2,-1,-1,0,0,1,1,2,2,3,3,4,4};
            
            Console.WriteLine("Are you ready to make a character? What is your character's name?");
            string userName = Console.ReadLine();

            //we're making lists for each pronouns so that the player can just make as many pronouns they use.
            //I need to figure out how to make copies of all these lists and then capitalise them. Alas, OCPS my favored child, you will be incomplete for now. 
            Console.WriteLine("How many pronoun sets does this character use?");
            int proNounSets = Convert.ToInt32(Console.ReadLine());

            var proNouns01 = AskForPronouns("Subject Pronoun", proNounSets);
            var proNouns02 = AskForPronouns("Object Pronoun", proNounSets);
            var proNouns03 = AskForPronouns("Possessive Adjectives", proNounSets);
            var proNouns04 = AskForPronouns("Possesive Pronoun", proNounSets);
            var proNouns05 = AskForPronouns("Reflexive Pronoun", proNounSets);
            Console.WriteLine(userName + " this is a test for the array, " + proNouns01[numberGen.Next(0, proNounSets)] + ", " + proNouns02[numberGen.Next(0, proNounSets)] + ", " + proNouns03[numberGen.Next(0, proNounSets)] + ", " + proNouns04[numberGen.Next(0, proNounSets)] + ", " + proNouns05[numberGen.Next(0, proNounSets)]);


            //what I am doing here is rolling 3d6 and adding them to form the player's strength. 
            Console.ReadKey();
            int playerStr = RollStat();
            Console.WriteLine("Your strength is " + playerStr + " for this character.");
            int playerStrBonus = bonus[playerStr];
            Console.WriteLine("Your Strength Bonus is " + playerStrBonus + ".");

            //this is the player's Dex score.
            Console.ReadKey();
            int playerDex = RollStat();
            Console.WriteLine("Your dexterity is " + playerDex + " for this character.");
            int playerDexBonus = bonus[playerDex];
            Console.WriteLine("Your Dexterity Bonus is " + playerDexBonus + ".");

            //this the player's Con score      
            Console.ReadKey();
            int playerCon = RollStat();
            Console.WriteLine("Your consitution is " + playerCon + " for this character.");
            int playerConBonus = bonus[playerCon];
            Console.WriteLine("Your Consitution Bonus is " + playerConBonus + ".");

            //this is the player's Int
            Console.ReadKey();
            int playerInt = RollStat();
            Console.WriteLine("Your intelligence is " + playerInt + " for this character.");
            int playerIntBonus = bonus[playerInt];
            Console.WriteLine("Your Intelligence Bonus is " + playerIntBonus + ".");

            //this is the player's Wis score.
            Console.ReadKey();
            int playerWis = RollStat();
            Console.WriteLine("Your wisdom is " + playerWis + " for this character.");
            int playerWisBonus = bonus[playerWis];
            Console.WriteLine("Your Wisdom Bonus is " + playerWisBonus + ".");

            //this the player's Cha score                
            Console.ReadKey();
            int playerCha = RollStat();
            Console.WriteLine("Your charisma is " + playerCha + " for this character.");
            int playerChaBonus = bonus[playerCha];
            Console.WriteLine("Your Charisma Bonus is " + playerChaBonus + ".");

            Console.WriteLine(userName + "'s Stats are " + playerStr + ", " + playerDex + ", " + playerCon + ", " + playerInt + ", " + playerWis + ", " + playerCha + "; " + proNouns03[numberGen.Next(0, proNounSets)] + " ability bonsuses are " + playerStrBonus + ", " + playerDexBonus + ", " + playerConBonus + ", " + playerIntBonus + ", " + playerWisBonus + ", " + playerChaBonus + ". ");





            //this closes the program
            Console.ReadKey();
        }

        static string[] AskForPronouns(string category, int numberToRequest)
        {
            Console.WriteLine(category);
            string[] pronouns = new string[numberToRequest];
            for (int i = 0; i < numberToRequest; i++)
            {
                pronouns[i] = Console.ReadLine();
            }

            return pronouns;
        }

        static int RollStat()
        {
            var total = 0;
            var lowestRoll = int.MaxValue;    // The largest number C# can put into an int.

            for (var diceRoll = 1; diceRoll <= 4; diceRoll++)
            {
                var roll = numberGen.Next(1, 7);
                Console.WriteLine("You rolled: " + roll);
                total += roll;

                if (roll < lowestRoll)
                {
                    lowestRoll = roll;      // track the lowest roll so far
                }
            }

            Console.WriteLine("Dropping the lowest roll: " + lowestRoll);
            total -= lowestRoll;
            return total;
        }
    }
}
