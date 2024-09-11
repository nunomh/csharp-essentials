﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTutorial_freeCodeCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();

            // Data Types
            string phrase = "abc";
            char singleChar = 'a';  
            int wholeNumber = 0;
            float decimalNumber1 = 1.3F;
            double decimalNumber2 = 2.2;
            decimal decimalNumber3 = 3.2M;
            bool boolean = false;

            // Working with strings
            Console.WriteLine("new\nline");
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase[0]);

            // Convert
            int num = Convert.ToInt32("43");
            double num2 = Convert.ToDouble("43,32");

            // Arrays
            int[] arrayOfNumbers = { 4, 8, 32 };
            Console.WriteLine(arrayOfNumbers[0]);
            arrayOfNumbers[1] = 900;

            string[] arrayOfStrings = { "abc", "def", "123qwe" };
            string[] arrayOfStrings2 = new string[5];
            arrayOfStrings2[0] = "qwe";
            arrayOfStrings2[1] = "asd";
            Console.WriteLine(arrayOfStrings2[0]);

            // Multi dimentional Arrays
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            Console.WriteLine(numberGrid[0,0]);

            // Methods
            simpleMethod("John");
            Console.WriteLine(cube(5));

            // Switch
            int dayNum = 1;
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                default:
                    dayName = "Invalid";
                    break;
            }


            // While loop
            int index = 1;
            while (index < 5)
            {
                Console.WriteLine(index);
                index++;
            }

            // Do While loop - corre sempre pelo menos uma vez
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 0);


            // For loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // Error handling
            try
            {

            }
            catch (DivideByZeroException ex) // captar uma excepção especifica
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally // executa sempre não impora exista erro ou não
            {

            }

            // Classes and Objects
            // Classe é a definição do objecto (ver classe Book.cs)
            // Objecto é uma instancia da classe
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JKR";
            book1.pages = 400;
            Console.WriteLine(book1.title);

            // Constructor
            // é chamado no new Movie(), irá chamar o metodo Movie() dentro da classe
            Movie movie1 = new Movie("HP", "JKR");

            Console.ReadLine();
        }

        static void simpleMethod(string name) // void - sem retorno
        {
            Console.WriteLine("Hello " + name);
        }

        static int cube(int num) // retorna int
        {
            int result = num * num * num;
            return result;
        }
    }
}
