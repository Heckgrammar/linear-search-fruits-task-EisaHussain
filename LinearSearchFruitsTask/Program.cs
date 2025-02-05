namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };
            Console.WriteLine("What fruit do you want to find?");
            string FruitToFind = Console.ReadLine();
            bool valid = false;
            for (int i = 0; i < fruits.Length; i++)
            {
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == FruitToFind)
                {
                    Console.WriteLine("True");
                    valid = true;
                }
            }
            }
            if (valid == false)
            {
                Console.WriteLine("False");
            }
            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found
            
            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
        }
    }
}
