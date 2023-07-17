using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





public class Node
{
    public int data;
    public Node left;
    public Node right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

public class BinaryTree
{
    private Node root;

    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int data)
    {
        root = Insert(root, data);
    }

    private Node Insert(Node node, int data)
    {
        if (node == null)
        {
            node = new Node(data);
            return node;
        }

        if (data < node.data)
            node.left = Insert(node.left, data);
        else if (data > node.data)
            node.right = Insert(node.right, data);

        return node;
    }

    public void Display()
    {
        Display(root);
    }

    private void Display(Node node)
    {
        if (node == null)
            return;

        Display(node.left);
        Console.Write(node.data + " ");
        Display(node.right);
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

