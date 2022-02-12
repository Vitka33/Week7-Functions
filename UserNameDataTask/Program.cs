using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnime tagurpidi;
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimest tähte;
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnime:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta arv '1', '2' või '3':");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            

            if (userNumber == 1)
            {
                numberOne(userName);
            }
            else if (userNumber == 2)
            {
                numberTwo(userName);
            }
            else
            {
                numberThree(userName);
            }
        }
        public static void numberOne(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
        public static void numberTwo(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }
        public static void numberThree(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk");
        }

    }
}
