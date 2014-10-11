using System;
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

        //public SecretNumber(int count, int number, int MaxNumberOfGuesses)
        //{
        //    Count = count;
        //    Number = number;
        //    Initialize();
        //}

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

            if (number < Number)
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - Count));
                return false;
            }

            if (number > Number)
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - Count));
                return false;
            }

            if (number == Number)
            {
                Console.WriteLine("Rätt gissat! Du använde {0} gissningar", Count);
                return true;
            }

            return true;
        }


    




        //public bool MakeGuess(int number);
        //{            
        //    if (Count == MaxNumberOfGuesses)
        //    {
        //        Console.WriteLine("Du har inga gissningar kvar, det hemliga talet var {0}", Number);
        //        return true;
        //    }

        //    if (Count != MaxNumberOfGuesses)
        //    {
        //        Count++;
        //    }

        //    if (number == Number)
        //    {
        //        Console.WriteLine("Du gissade rätt! Det hemliga talet är {0}. Du använde {1} antal gissningar.", Number, Count);
        //        count++;
        //        return true;
        //    }

        //    if (1 > number || number > 100)
        //    {
        //        throw new ArgumentOutOfRangeException();
        //    }
        //}

        //public int Count ()
        //{
        //    Initialize();
        //}

        //public int Number()
        //{
        //    get {return _number;}
        //    set {_number = value;}
        //}

    }
 

}
