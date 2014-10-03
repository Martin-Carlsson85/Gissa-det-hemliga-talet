using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        //Deklaration av konstant och varaibler.
        public const int MaxNumberOfGuesses = 7;
        private int _count;
        private int _number;

        //Metoden Initialize som tilldelas ett slumpat heltal i det slutna intervallet mellan 1 och 100. 
        public void Initialize()
        {
            Random myRandom = new Random();
            _number = myRandom.Next(1, 101);
            _count = 0;
            
    
        }


        public bool MakeGuess(int number)
        {
            _count++;

            int guessNumber = MaxNumberOfGuesses - _count++;

            try
            { 
            
                if (number == _number)
                {
                    Console.WriteLine("Grattis! {0} är det hemliga talet! Du klarade det på {1} antal försök", number, guessNumber);

                    return true;
                }

                if (number < _number)
                {
                    Console.WriteLine("{0} är för lågt, du har nu {1} gissningar kvar", number, guessNumber);

                    return false;
                }
                if (number > _number)
                {
                    Console.WriteLine("{0} är för högt, du har nu {1} gissningar kvar", number, guessNumber);

                    return false;
                }
                if (number )

               return false;
            

            
           
        }


        public SecretNumber()
        {

            Initialize();
        }
    }
}
