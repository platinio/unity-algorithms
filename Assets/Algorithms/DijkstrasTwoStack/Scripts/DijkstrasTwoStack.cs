using System.Text.RegularExpressions;
using System;
using UnityEngine;

namespace UnityAlgorithms
{
    public static class DijkstrasTwoStack 
    {
        private static ArrayStack<int> numbers = null;
        private static ArrayStack<string> symbols = null;        
        private static int defaultStackSize = 10;


        public static int Evaluate(string sentence)
        {
            if (IsSentenceValid( sentence ))
            {
                Initialize();
                return ResolveMathOperation(sentence);                
            }

            ArgumentException exception = new ArgumentException( "Sentence contains invalid characters", "sentence");
            throw exception;
        }

        private static bool IsSentenceValid(string sentence)
        {
            Regex regex = new Regex( "^[0-9()+* -]+$" );
            return regex.IsMatch(sentence);
        }

        private static void Initialize()
        {
            numbers = new ArrayStack<int>( defaultStackSize );
            symbols = new ArrayStack<string>( defaultStackSize );          
        }

        private static int ResolveMathOperation(string sentence)
        {
            foreach (string s in sentence.Split(' '))
            {
                ProcessChar(s);
            }

            if (!numbers.IsEmpty())
            {
                return numbers.Pop();
            }

            return 0;
        }

        private static void ProcessChar(string s)
        {
            if (s == "(")
            {
                return;
            }

            int number;

            if (int.TryParse( s, out number ))
            {
                numbers.Push( number );
            }
            else if ( IsMathSymbol( s ) )
            {
                symbols.Push( s );
            }
            else if (s == ")")
            {
                ResolveMathStack();               
            }

        }

        private static bool IsMathSymbol(string s)
        {
            return s == "+" || s == "-" || s == "*";
        }

        private static void ResolveMathStack()
        {
            while ( !symbols.IsEmpty() )
            {
                int result = ResolveOperation( numbers.Pop(), numbers.Pop(), symbols.Pop() );
                numbers.Push( result );
            }
        }

        private static int ResolveOperation(int numberA , int numberB , string symbol)
        {
            Debug.Log("Resolving " + numberA + " " + symbol + " " + numberB);

            switch (symbol)
            {
                case "+":
                {
                    return numberA + numberB;                   
                }

                case "-":
                {
                    return numberA - numberB;                   
                }

                case "*":
                {
                    return numberA * numberB;                   
                }

            }

            return 0;
        }



    }
}

