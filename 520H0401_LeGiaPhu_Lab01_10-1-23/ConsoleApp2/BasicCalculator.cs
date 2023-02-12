using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BasicCalculator
    {
        private String userInput = "";
        public BasicCalculator()
        {
            this.userInput = "";
        }
        public BasicCalculator(String userInput)
        {
            this.userInput = userInput.Trim().Replace(" ","");
        }
        public String getUserInput()
        {
            return userInput;
        }

        public bool containLetter(String val)
        {
            int errorCounter = Regex.Matches(val, @"[a-zA-Z]").Count;
            if(errorCounter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Prec(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
            }
            return -1;
        }
        public string infixToPostfix(string exp)
        {
            string result = "";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < exp.Length; ++i)
            {
                char c = exp[i];
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0
                           && stack.Peek() != '(')
                    {
                        result += stack.Pop();
                    }
                    if (stack.Count > 0
                        && stack.Peek() != '(')
                    {
                        return "Invalid Expression"; 
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    while (stack.Count > 0
                           && Prec(c) <= Prec(stack.Peek()))
                    {
                        result += stack.Pop();
                    }
                    stack.Push(c);
                }
            }
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }
            v = result;
            return result;
        }

        public string answer;
        public string v;
        Stack i = new Stack();
        public void expression()
        //evaluation method
        {
            int a, b, ans;
            for (int j = 0; j < v.Length; j++)
            //'v.Length' means length of the string
            {
                String c = v.Substring(j, 1);
                if (c.Equals("*"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a * b;
                    i.Push(ans.ToString());

                }
                else if (c.Equals("/"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a / b;
                    i.Push(ans.ToString());
                }
                else if (c.Equals("+"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a + b;
                    i.Push(ans.ToString());

                }
                else if (c.Equals("-"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a - b;
                    i.Push(ans.ToString());

                }
                else
                {
                    i.Push(v.Substring(j, 1));
                }
            }
            answer = (String)i.Pop();
        }
    }
}
