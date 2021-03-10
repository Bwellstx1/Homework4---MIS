using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence >>");
            string sentence = Console.ReadLine().ToLower(); ;
            // sentence = sentence.ToLower();

            int vowels = 0; 
            int consonants = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                char letter = sentence[i];
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowels++;

                }
                else if (letter == ' ' || letter == ',' || letter == '.' || letter == '?' || letter == '!' ||
                    letter == '!' || letter == '"' || letter == '1' || letter == '2' || letter == '3' ||
                    letter == '4' || letter == '5' || letter == '6' || letter == '7' || letter == '8' || letter == '9' )
                {

                }
                else 
                {
                    consonants++;
                }
            }
            Console.WriteLine($"There were {vowels.ToString("g0") } vowels in the sentence");
            Console.WriteLine($"There were {consonants.ToString("g0") } consonants in the sentence");

          
           git remote add origin https://github.com/Bwellstx1/Homework4.git
            Console.ReadKey(); 
            }
          


        }
    }

