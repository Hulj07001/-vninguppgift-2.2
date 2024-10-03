using System;
namespace övninguppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vilket årtal är det? ");
            string årtaltext=Console.ReadLine();
            int årtal=int.Parse(årtaltext);
            int omår = 20;
            // Man kan ändra värdet på "omår" beroende på hur många år efter man vill veta
            
            int årtalom = årtal + omår;
            Console.WriteLine("Om " + omår + " år kommer prtalet vara " + årtalom + ".");
        }
    }
}