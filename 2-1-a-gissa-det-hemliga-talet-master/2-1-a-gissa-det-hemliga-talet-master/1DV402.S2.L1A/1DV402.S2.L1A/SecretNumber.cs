﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        private int _count;
        private int _number;
        public const int MaxNumberOfGuesses = 7;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }


        public SecretNumber()
        {
            Count = _count;
            Number = _number;
            Initialize();
        }

        public void Initialize()
        {
            Random rnd = new Random();
            _number = rnd.Next(1, 100);
            _count = 0;
        }

        public bool MakeGuess(int number)
        {

            if (_count == MaxNumberOfGuesses)
            { 
                throw new ApplicationException(); 
            }

            _count++;

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }


            if (number == Number)
            {
                Console.WriteLine("Rätt gissat! Du använde {0} gissningar.", Count);
                return true;
            }

            else if (number < Number)
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - Count));
            }

            else if (number > Number)
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - Count));
            }

            if (Count == MaxNumberOfGuesses)
            {
                Console.WriteLine("Det hemliga talet är {0}", Number);
            }

            return false;
        }


    }
 

}
