using System.Text.RegularExpressions;
using UnityEngine;

namespace UnityAlgorithms
{
    public static class DijkstrasTwoStack 
    {
        private static ArrayStack<int> numbers = null;
        private static ArrayStack<string> symbols = null;
        private static int result = 0;

        public static int Process(string sentence)
        {
            if (IsSentenceValid( sentence ))
            {
                InitializeStacks();
                ProcessValidSentence(sentence);
                return numbers.Pop();
            }
            else
            {

            }

            return 0;
        }

        private static bool IsSentenceValid(string sentence)
        {
            //Regex regex = new Regex( "^[0-9()+-*]+$" );
            //return regex.IsMatch(sentence);
            return true;
        }

        private static void InitializeStacks()
        {
            numbers = new ArrayStack<int>( 10 );
            symbols = new ArrayStack<string>( 10 );
            result = 0;
        }

        private static void ProcessValidSentence(string sentence)
        {
            foreach (string s in sentence.Split(' '))
            {
                ProcessChar(s);
            }
        }

        private static void ProcessChar(string s)
        {
            if (s == "(")
            {
                //symbols.Push(s);
                return;
            }

            int number;

            if (int.TryParse( s, out number ))
            {
                numbers.Push( number );
            }
            else if (s == "+" || s == "-" || s == "*")
            {
                Debug.Log("push " + s);
                symbols.Push( s );
            }
            else if (s == ")")
            {
                //string symbol = symbols.Pop();

                while (symbols.head > 0)
                {
                    Debug.Log(numbers.head);
                    //ResolveEquation( numbers.Pop() , symbol );
                    numbers.Push( ResolveEquation( numbers.Pop() , numbers.Pop(), symbols.Pop() ) );                    
                }
               
            }

        }

        private static void ResolveEquation(int number , string symbol)
        {
            switch (symbol)
            {
                case "+":
                {
                    result += number;
                    break;
                }

                case "-":
                {
                    result -= number;
                    break;
                }

                case "*":
                {
                    result *= number;
                    break;
                }

            }
        }

        private static int ResolveEquation(int numberA , int numberB , string symbol)
        {
            switch (symbol)
            {
                case "+":
                {
                    return numberA + numberB;
                    break;
                }

                case "-":
                {
                    return numberA - numberB;
                    break;
                }

                case "*":
                {
                    return numberA * numberB;
                    break;
                }

            }

            return 0;
        }



    }
}

