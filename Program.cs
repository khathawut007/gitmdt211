using System;

namespace finals
{
    class Program
    {
        static void AddNode(ref Node node)
        {
            Console.WriteLine("Input skill name:");
            Console.WriteLine("Add dependency for Fire Bolt?");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'Y')
            {
                string message = Console.ReadLine();
                node = new Question(message);
                AddNode(ref (node as Question).Left);
                AddNode(ref (node as Question).Right);
            }
            else
            {
                string message = Console.ReadLine();
                node = new DeceaseNode(message);
            }


        }
        static void Main(string[] args)
        {
            Node root = null;
            AddNode(ref root);

            Node ptr = root;
            while (true)
            {
                 Console.WriteLine(ptr.Message);
                 if (ptr is Question)
                 {
                     char answer = char.Parse(Console.ReadLine());
                     if (answer == 'Y')
                     {
                         ptr = (ptr as Question).Left;
                     }
                     else
                     {
                        ptr = (ptr as Question).Right;
                     }
                 }
                 else
                 {
                     break;
                 }
            }
        }
    }
}
