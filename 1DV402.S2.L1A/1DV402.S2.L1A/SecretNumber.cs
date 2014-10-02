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


        public void Initialize()
        {
            Random myRandom = new Random();
            _number = myRandom.Next(1, 101);
            _count = 0;
            
    
        }


        public bool MakeGuess()
        {

        }

    }
}
