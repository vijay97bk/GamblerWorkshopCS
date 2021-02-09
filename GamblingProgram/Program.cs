using System;

namespace GamblingProgram
{
    class Program
    {
       public static int gamblerAmountDay = 100;
        public static int gamblerHalfAmount = 50;
        public static int betEachGame = 1;
        static void Main(string[] args)
        {
            
                GamblerBet();
           
        }
     
        public static void GamblerBet()
        {
            while (gamblerAmountDay <= gamblerHalfAmount)
            {
                Random random = new Random();
                int bet = random.Next(0, 2);
                if (bet == 0)
                {
                    Console.WriteLine("lost the bet");
                    gamblerAmountDay--;

                }
                else
                {
                    Console.WriteLine("you won the bet");
                    gamblerAmountDay++;
                }
            }

         

        }
    }
}
