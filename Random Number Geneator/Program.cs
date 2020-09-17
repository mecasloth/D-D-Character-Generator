using System;
using System.Collections.Generic;

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
        
        static void Main(string[] args)
        {
            

            int[] bonus= 
            {
                -5,
                -5,
                -4,
                -4,
                -3,
                -3,
                -2,
                -2,
                -1,
                -1,
                0,
                0,
                1,
                1,
                2,
                2,
                3,
                3,
                4,
                4

            }; 



            Random numberGen = new Random();             
            Console.WriteLine("Are you ready to make a character? What is your character's name?");
            string userName = Console.ReadLine();

//we're making lists for each pronouns so that the player can just make as many pronouns they use.
//I need to figure out how to make copies of all these lists and then capitalise them. Alas, OCPS my favored child, you will be incomplete for now. 
            Console.WriteLine("How many pronoun sets does this character use?");
            int proNounSets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Subject Pronoun");
            string[] proNouns01 = new string[proNounSets];
            for (int i = 0; i < proNounSets; i++)
            {
                proNouns01[i] = Console.ReadLine();
            }
            Console.WriteLine("Object Pronoun");
            string[] proNouns02 = new string[proNounSets];
            for (int i = 0; i < proNounSets; i++)
            {
                proNouns02[i] = Console.ReadLine();
            }            
            Console.WriteLine("Possessive Adjectives");
            string[] proNouns03 = new string[proNounSets];
            for (int i = 0; i < proNounSets; i++)
            {
                proNouns03[i] = Console.ReadLine();
            }   
            Console.WriteLine("Possesive Pronoun");
            string[] proNouns04 = new string[proNounSets];
            for (int i = 0; i < proNounSets; i++)
            {
                proNouns04[i] = Console.ReadLine();
            }   
            Console.WriteLine("Reflexive Pronoun");
            string[] proNouns05 = new string[proNounSets];
            for (int i = 0; i < proNounSets; i++)
            {
                proNouns05[i] = Console.ReadLine();
            }   
            Console.WriteLine(userName + " this is a test for the array, " + proNouns01[numberGen.Next(0, proNounSets)] + ", " + proNouns02[numberGen.Next(0, proNounSets)]  + ", " + proNouns03[numberGen.Next(0, proNounSets)] + ", " + proNouns04[numberGen.Next(0, proNounSets)] + ", " + proNouns05[numberGen.Next(0, proNounSets)]);

            
//what I am doing here is rolling 3d6 and adding them to form the player's strength. 
            Console.ReadKey();
            int roll01 = 0;
            int roll02 = 0;
            int roll03 = 0;
                roll01 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll01 );
                roll02 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll02 );
                roll03 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll03 );
            int playerStr = Convert.ToInt32(roll01 + roll02 + roll03);
                Console.WriteLine("Your strength is " + playerStr + " for this character.");
            int playerStrBonus = Convert.ToInt32(bonus[playerStr]);
            Console.WriteLine("Your Strength Bonus is " + playerStrBonus + ".");

//this is the player's Dex score.
                Console.ReadKey();
            int roll04 = 0;
            int roll05 = 0;
            int roll06 = 0;
                roll04 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll04 );
                roll05 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll05 );
                roll06 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll06 );
                int playerDex = Convert.ToInt32(roll04 + roll05 + roll06);
                Console.WriteLine("Your dexterity is " + playerDex + " for this character.");
                int playerDexBonus = Convert.ToInt32(bonus[playerDex]);
                Console.WriteLine("Your Dexterity Bonus is " + playerDexBonus + ".");

//this the player's Con score                
                   Console.ReadKey();
            int roll07 = 0;
            int roll08 = 0;
            int roll09 = 0;
                roll07 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll07 );
                roll08 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll08 );
                roll09 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll09 );
                int playerCon = Convert.ToInt32(roll07 + roll08 + roll09);
                Console.WriteLine("Your consitution is " + playerCon + " for this character.");
                int playerConBonus = Convert.ToInt32(bonus[playerCon]);
                Console.WriteLine("Your Consitution Bonus is " + playerConBonus + ".");

//this is the player's Int
            Console.ReadKey();
            int roll10 = 0;
            int roll11 = 0;
            int roll12 = 0;
                roll10 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll10 );
                roll11 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll11 );
                roll12 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll12 );
            int playerInt = Convert.ToInt32(roll10 + roll11 + roll12);
                Console.WriteLine("Your intelligence is " + playerInt + " for this character.");
                int playerIntBonus = Convert.ToInt32(bonus[playerInt]);
                Console.WriteLine("Your Intelligence Bonus is " + playerIntBonus + ".");

//this is the player's Wis score.
                Console.ReadKey();
            int roll13 = 0;
            int roll14 = 0;
            int roll15 = 0;
                roll13 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll13 );
                roll14 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll14 );
                roll15 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll15 );
                int playerWis = Convert.ToInt32(roll13 + roll14 + roll15);
                Console.WriteLine("Your wisdom is " + playerWis + " for this character.");
                int playerWisBonus = Convert.ToInt32(bonus[playerWis]);
                Console.WriteLine("Your Wisdom Bonus is " + playerWisBonus + ".");

//this the player's Cha score                
                   Console.ReadKey();
            int roll16 = 0;
            int roll17 = 0;
            int roll18 = 0;
                roll16 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll16 );
                roll17 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll17 );
                roll18 = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll18);
                int playerCha = Convert.ToInt32(roll16 + roll17 + roll18);
                Console.WriteLine("Your charisma is " + playerCha + " for this character.");
                int playerChaBonus = Convert.ToInt32(bonus[playerCha]);
                Console.WriteLine("Your Charisma Bonus is " + playerChaBonus + ".");
                
                Console.WriteLine(userName + "'s Stats are " + playerStr + ", "+ playerDex +", "+ playerCon + ", "+ playerInt + ", "+ playerWis + ", "+ playerCha + "; " + proNouns03[numberGen.Next(0, proNounSets)] +" ability bonsuses are " + playerStrBonus + ", " + playerDexBonus + ", " +  playerConBonus + ", " +  playerIntBonus + ", " +  playerWisBonus + ", " +  playerChaBonus + ". ");




            
            //this closes the program
            Console.ReadKey();
        }
    }
}
