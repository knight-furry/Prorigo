using System;
using System.Collections.Generic;
using System.Linq;

namespace Prorigo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber(31);                        // Check PrimeNumber

            //SumOfDigits(8125);                      // Sum of Digits

            //int[] arr = {3, 23, 11, 5, 44};
            //SecondLargestInt(arr);                  // Second Largest Element from Array

            //PalindromeString("kadak");              // Palindrome String

            //ReverseString("Hello world");           // Reverse the String

            //ReverseEachWordOnSamePosition("Welcome to CSharp corner"); // Reverse each word at same position

            //ReverseOrderWords("Welcome to CSharp corner");              // Reverse the order of words in string

            //OcuurenceCount("Hello World");                              // Calculating the occurence of Character

            //RemoveDublicateChar("csharpcorner");                        // Remove Dublicate character from string

            //AllPosibleSubStrings("abcd");                                 // All posible Sub String of String


        }

        static void PrimeNumber(int number)
        {
            int i, flag = 0;
            for (i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("NOT Prime Number");
            }
        }

        static void SumOfDigits(int number)
        {
            int i = number;
            int sum = 0;
            while(i > 0)
            {
                int rem = i % 10;
                sum += rem;
                i /= 10;
            }
            Console.WriteLine("Sum of digits: " + sum);
        }

        static void SecondLargestInt(int[] arr)
        {
            int size = arr.Length;
            int max, secondMax;
            if(arr[0] > arr[1])
            {
                max = arr[0];
                secondMax = arr[1];
            }
            else
            {
                secondMax = arr[0];
                max = arr[1];
            }

            for(int i = 2; i < size; i++)
            {
                if(max < arr[i])
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if(secondMax < arr[i])
                {
                    secondMax = arr[i];
                }
            }
            Console.WriteLine("Second Largest Element: " + secondMax);
        }

        static void PalindromeString(string str)
        {
            int i = 0, flag = 0;
            int j = str.Length - 1;
            while(i < j)
            {
                if(str[i] != str[j])
                {
                    flag = 1;
                    break;
                }
                i++;
                j--;
            }
            if(flag == 0)
            {
                Console.WriteLine("String is Palindrome\n");
            }
            else
            {
                Console.WriteLine("String is NOT Palindrome");
            }
        }

        static void ReverseString(string str)
        {
            int size = str.Length - 1;
            while(size >= 0)
            {
                Console.Write(str[size]);
                size--;
            }
            Console.WriteLine();
        }

        static void ReverseEachWordOnSamePosition(string str)
        {
            string stringReverse = "";
            foreach(var word in str.Split(' '))
            {
                string temp = "";
                foreach(var x in word.ToCharArray())
                {
                    temp = x + temp;
                }
                stringReverse = stringReverse + temp + " ";
            }
            Console.WriteLine(stringReverse);
        }

        static void ReverseOrderWords(string str)
        {
            int j = str.Length - 1;
            int length = j;
            while (j >= 0)
            {
                if(str[j] == ' ' || j == 0)
                {
                    for(int i = j; i <= length; i++)
                    {
                        if(str[i] != ' ')
                        Console.Write(str[i]);
                    }
                    Console.Write(" ");
                    length = j - 1;
                }
                j--;
            }
        }

        static void OcuurenceCount(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict = str.GroupBy(x => x).ToDictionary(gr => gr.Key, gr => gr.Count());

            foreach(KeyValuePair<char, int> pair in dict)
            {
                Console.WriteLine(pair.Key + " = " + pair.Value);
            }
        }

        static void RemoveDublicateChar(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                int flag = 0;
                for(int j = 0; j < i; j++)
                {
                    if(str[j] == str[i])
                    {
                        flag = 1;
                    }
                }
                if(flag==0)
                {
                    Console.Write(str[i]);
                }
            }    
        }

        static void AllPosibleSubStrings(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = i; j < str.Length; j++)
                {
                    for(int k = i; k <= j; k++)
                    {
                        Console.Write(str[k]);
                    }
                    Console.WriteLine();
                }
            }
        }


    }
}
