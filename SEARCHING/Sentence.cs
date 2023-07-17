using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sentence
{
    public string RemoveWord(string sentence, string wordToRemove)
    {
        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Equals(wordToRemove, StringComparison.OrdinalIgnoreCase))
            {
                words[i] = string.Empty; // Remove the word
            }
        }

        string result = string.Join(" ", words);
        result = result.Trim(); // Remove leading/trailing spaces

        return result;
    }
}


//            public int top = -1;
//            public char[] items = new char[100];

//            public void push(char x)
//            {
//                if (top == 99)
//                {
//                    Console.WriteLine("Stack full");
//                }
//                else
//                {
//                    items[++top] = x;
//                }
//            }

//            char pop()
//            {
//                if (top == -1)
//                {
//                    Console.WriteLine("Underflow error");
//                    return '\0';
//                }
//                else
//                {
//                    char element = items[top];
//                    top--;
//                    return element;
//                }
//            }

//            bool isEmpty()
//            {
//                return (top == -1) ? true : false;
//            }
//        }


//        public bool isMatchingPair(char character1, char character2)
//        {
//            if (character1 == '(' && character2 == ')')
//                return true;
//            else if (character1 == '{' && character2 == '}')
//                return true;
//            else if (character1 == '[' && character2 == ']')
//                return true;
//            else
//                return false;
//        }

//    public bool Balanced(char[] exp)
//    {

//        Stack<char> st = new Stack<char>();


//        for (int i = 0; i < exp.Length; i++)
//        {

//            if (exp[i] == '{' || exp[i] == '('
//                || exp[i] == '[')
//                st.Push(exp[i]);


//            if (exp[i] == '}' || exp[i] == ')'
//                || exp[i] == ']')
//            {


//                if (st.Count == 0)
//                {
//                    return false;
//                }


//                else if (!isMatchingPair(st.Pop(),
//                                         exp[i]))
//                {
//                    return false;
//                }
//            }
//        }



//        if (st.Count == 0)
//            return true;
//        else
//        {

//            return false;
//        }
//    }




//}

