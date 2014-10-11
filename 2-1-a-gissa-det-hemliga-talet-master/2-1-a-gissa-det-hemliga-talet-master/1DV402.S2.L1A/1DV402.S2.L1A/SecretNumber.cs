using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        private int _count;
        private int _number;
        public const int _MaxNumberOfGuesses = 7;

        public int Count
        {
            get {return _count;}
            set
            {
            }
        }

        public int Number
        {
            get {return _number;}
            set 
            {
            }
        }
        
        public SecretNumber()
        {
        }
        
        public SecretNumber( int count, int number, int MaxNumberOfGuesses )
        {
            Count = count;
            Number = number;
            Initialize();
        }

        public void Initialize()
        {
            Random _number = new Random();
            int secretNumber = _number.Next(1, 101);
            _count = 0;
        }

        public bool MakeGuess(int number)
        {

        }

        //public int Count ()
        //{
        //    Initialize();
        //}

        //public int Number()
        //{
        //    get {return _number;}
        //    set {_number = value;}
        //}

 

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

}
