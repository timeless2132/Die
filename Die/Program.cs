using System.Security.Cryptography.X509Certificates;

namespace Die
{
    internal class Program
    {
        static void Main(string[] args)
        {
            die die1, die2;
            die1 = new die();
            die2 = new die();

            if (die1.Roll == die2.Roll)
            {
                Console.WriteLine("Doubles");
            }
            else { Console.WriteLine("Not Doubles"); }

            if (die1.Roll + die2.Roll == 7)
            {
                Console.WriteLine("They sum of the two numbers is 7");
            }
            else if (die1.Roll == 1 && die2.Roll == 1)
            {
                Console.WriteLine("Snake eyes"); 
            }
            else if (die1.Roll - 1 == die2.Roll || die1.Roll + 1 == die2.Roll || die2.Roll - 1 == die1.Roll || die2.Roll + 1 == die2.Roll)
            {
                Console.WriteLine("The numbers are sequential");
            }
            else if ((die1.Roll + die2.Roll) % 2 == 0)
            {
                Console.WriteLine("The numbers are even");
            }

            Console.WriteLine(die1);
            die1.DrawDie();
            Console.WriteLine(die2);
            die2.DrawDie();
            
            if (die1.Roll > die2.Roll)
            {
                Console.WriteLine("Die 1 is greater than die 2");
            }
            else
                Console.WriteLine("Die 2 is greater than die 1");
        }
    }

}
