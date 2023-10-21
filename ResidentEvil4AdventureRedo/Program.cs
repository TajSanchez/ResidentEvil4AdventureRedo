namespace ResidentEvil4AdventureRedo
{
    internal class Program
    {




        public static void Main(string[] args)
        {
            string mainCharacter = "Regenorator";
            string sideKick = "Novisador";
            string antagonist = "Leon S. Kennedy";
            string choice1 = "a";
            string choice2 = "b";
            string userInput = "";


            TellMessageToUser($"You are the main character you are a: {mainCharacter}: Press ENTER to continue");
            GetUserInput();
            TellMessageToUser($"You have a sidekick of type: {sideKick}: Press ENTER to continue");
            GetUserInput();
            TellMessageToUser($"You're enemy is no other than: {antagonist}: Press ENTER to continue");
            GetUserInput();
            TellMessageToUser($"To start, you are a {mainCharacter} with a {sideKick} as your teammate. Use them whenever you see fit. On your tail you have {antagonist} trying to retrieve the sample from you. Make sure he NEVER gets the sample, or else Lord Saddler will be displeased. You are in the castle, and you encounter {antagonist}! The choices to attack are between A and B, please choose now.");

            userInput = GetUserInput().ToLower();

            if (userInput == choice1)
            {

                TellMessageToUser("OH no.... You took damage from Leon's Riot Gun.");
            }
            else if (userInput == choice2)
            {

                TellMessageToUser("You get a cookie!");

            }
            else
            {
                Console.WriteLine("Try that again....");
            }





        }
        public static void TellMessageToUser(string message)
        {
            Console.WriteLine(message);
        }
        public static string GetUserInput()
        {
            return Console.ReadLine();
        }






    }
}

