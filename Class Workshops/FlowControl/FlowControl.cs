using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Workshops
{
    class FlowControl
    {
       
        
            public const int minimumAge = 13;
            public static int playerAge;
            public static string permission;
            public static int computerRPSRandomNum;


            public static void FCIfElse()
            {
           FCSwitchRoll();
            Console.WriteLine("Welcome to Rock Paper Scissors, what is your age?");
            playerAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Wow, You are {playerAge} years old!");


            if (playerAge >= minimumAge)
            {
                //if treu run this block of code.
                Console.WriteLine("Excellent. You are old enough to get started.");
                // add method you want to run here.
            }
            else 
            {
                //if not true run this block of code.
                Console.WriteLine($"You are not old enough to play, you must me {minimumAge} to play this game!");
                //Add new Method
                FCElseIf();
            }
           }

        public static void FCElseIf() 
        {
            Console.WriteLine("Do you have your parents permission to play? Enter Yes Or No.");
            permission = Console.ReadLine().ToLower();

            if (permission == "yes" || permission == "y")
            {
                //run a block of code
                Console.WriteLine("Great. Let's get started.");
                Console.ReadLine();
                //Input methodd here to start game
            }
            else if (permission == "no" || permission == "n")
            {
                // run a block of code
                Console.WriteLine("Well that's too bad. Try again when you're older! Press enter to exit.");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("I did not understand that answer. Please Try Again!");
                FCElseIf();
            }



        }

        public static void FCSwitchRoll()
        {
            Random computerRandomRPS = new Random();
            computerRPSRandomNum = computerRandomRPS.Next(1, 4);
            Console.WriteLine($"My Random Number is {computerRPSRandomNum}");

            switch (computerRPSRandomNum)
            {
                case 4:
                    Console.WriteLine("Oops PC rolled a 4. That wasn't suppose to happen.");
                    FCSwitchRoll();
                    break;
                case 3:
                    Console.WriteLine($"PC chose a {computerRPSRandomNum}. That is equal to Rock.");
                    break;
                case 2:
                    Console.WriteLine($"PC chose a {computerRPSRandomNum}. That is equal to Paper.");
                    break;
                case 1:
                    Console.WriteLine($"PC chose a {computerRPSRandomNum}. That is equal to Scissors");
                    break;
            }
            Console.ReadLine();
            FCSwitchRoll();



        }


        

    }
}
