namespace Assignment
{

    public static class ArrayReplicator
    {
        public static int[] ReplicateArray(int[] original)
        {
            int content = original.Length;
            int[] copyArray = new int[content];
          

            for (int i = 0; i < content; ++i)
            {
                copyArray[i] = original[i];
            }
            return copyArray;
        }

        
        public static int AskForNumber(string text)
        {
            Console.Write(text);
            string userInput = Console.ReadLine()!; 
            int number = Convert.ToInt32(userInput);
            return number;
        }

        
        public static int AskForNumber(string text, int min, int max)
        {
            int userInput = AskForNumber(text);

            // if the number given by user is out of maximum range.
            while (userInput < min || userInput > max)
            {
                userInput = AskForNumber("Your previous input is not valid, try again.");
            }
            return userInput;
        }
    }
    static class Program
    {
        static void Main()
        {
            const int Min = 0;
            const int Max = 15;
            const int PrintOffset = 4;


            int content = ArrayReplicator.AskForNumber("Enter the array content: ", Min, Max);
            int[] real = new int[content];



            // Fill up the real array with numbers mentioned by user.
            
            for (int item = 0; item < size; ++item)
            {
                real[item] = ArrayReplicator.AskForNumber("Enter a number: ");
            }


            int[] print = ArrayReplicator.ReplicateArray(real);

            // Verifing that real and duplicated arrays are the identical

            for (int index = 0; index < size; ++index)
                Console.WriteLine($"real {real[index],-PrintOffset}  {print[index],4} print");
        }
    }
}

