using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)

        {
            string userInputResponse;
            string userInputResponseDuplicate = "blank";
            string userInputHello = "hello";
            string userInputBye = "bye";
            string userInputSup = "sup";
            string userInputHelloThere = "hello there";
            bool userSaidBye = false;

            Console.WriteLine("Welcome to the Chat Room, I'm SmarterERChild :)");

            while (userSaidBye == false)
            {
                Console.Write("What would you like to say?: ");
                userInputResponse = Console.ReadLine();

                if (userInputResponse.ToLower() == userInputHello && userInputResponse.ToLower() != userInputResponseDuplicate)
                {
                    Console.WriteLine("Hi good to see you");
                    userInputResponseDuplicate = userInputHello;
                    
                }
                else if (userInputResponse.ToLower() == userInputSup && userInputResponse.ToLower() != userInputResponseDuplicate)
                {
                    Console.WriteLine("I am good");
                    userInputResponseDuplicate = userInputSup;
                }
                else if (userInputResponse.ToLower() == userInputHelloThere && userInputResponse.ToLower() != userInputResponseDuplicate)
                {
                    Console.WriteLine("General Kenobi");
                    userInputResponseDuplicate = userInputHelloThere;
                }
                else if (userInputResponse.ToLower() == userInputBye)
                {
                    Console.WriteLine("Good Bye!");
                    userSaidBye = true;     
                }
                else if (userInputResponse.ToLower() == userInputResponseDuplicate)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }




            }

        }
    }
}
