using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace ConsoleApp2
{
   class Program
    {
        static void Main(string[] args) {
            void info(string txt, ConsoleColor a)
            {
                ForegroundColor = a;
                Write(txt + "\n");
                ForegroundColor = ConsoleColor.Gray;
            }

            Dictionary<char, int> alphabet = new Dictionary<char, int>()
            {
                { 'А', 1 }, { 'Б', 2 }, { 'В', 3 }, { 'Г', 4 }, { 'Д', 5 }, { 'Е', 6 }, { 'Ё', 7 },
                { 'Ж', 8 }, { 'З', 9 }, { 'И', 10 }, { 'Й', 11 }, { 'К', 12 }, { 'Л', 13 }, { 'М', 14 },
                { 'Н', 15 }, { 'О', 16 }, { 'П', 17 }, { 'Р', 18 }, { 'С', 19 }, { 'Т', 20 }, { 'У', 21 },
                { 'Ф', 22 }, { 'Х', 23 }, { 'Ц', 24 }, { 'Ч', 25 }, { 'Ш', 26 }, { 'Щ', 27 }, { 'Ъ', 28 },
                { 'Ы', 29 }, { 'Ь', 30 }, { 'Э', 31 }, { 'Ю', 32 }, { 'Я', 33 }
            };
            Dictionary<int, char> alphabetDecode = new Dictionary<int, char>()
            {
                { 1, 'А' }, { 2, 'Б' }, { 3, 'В' }, { 4, 'Г' }, { 5, 'Д' }, { 6, 'Е' }, { 7, 'Ё' },
                { 8, 'Ж' }, { 9, 'З' }, { 10, 'И' }, { 11, 'Й' }, { 12, 'К' }, { 13, 'Л' }, { 14, 'М' },
                { 15, 'Н' }, { 16, 'О' }, { 17, 'П' }, { 18, 'Р' }, { 19, 'С' }, { 20, 'Т' }, { 21, 'У' },
                { 22, 'Ф' }, { 23, 'Х' }, { 24, 'Ц' }, { 25, 'Ч' }, { 26, 'Ш' }, { 27, 'Щ' }, { 28, 'Ъ' },
                { 29, 'Ы' }, { 30, 'Ь' }, { 31, 'Э' }, { 32, 'Ю' }, { 33, 'Я' }
            };
            string Input = "Лето и Арбалеты";

            string Encode(string text)
            {
                text = text.ToUpper();
                StringBuilder InputEncode = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    try
                    {
                        InputEncode.Append(alphabet[text[i]]);
                    }
                    catch { }
                }
                return InputEncode.ToString();
            }

            string EncodeInput = "";
            for (int i = 0; i<Input.Split(' ').Length; i++)
            {
                EncodeInput += Encode(Input.Split(' ')[i]);
                EncodeInput += Convert.ToString(Input.Split(' ')[i].Length)  +"!";
            }
            
            
            List<string> Decode(string text)
            { //1362016  ||  13 6 20 16
                string input = text;
                List<string> output = new List<string>();
                //Splitted strings
                string[] check = text.Split('!');
                for (int i = 0; i < check.Length - 1; i++)
                {
                    DecodeOneWord(check[i]);
                }
                string DecodeOneWord(string word)
                {
                    string Real_Lenght_OfWord = word.Substring(word.Length - 1, 1);
                    string outputWord = "";
                    if(word.Length == Real_Lenght_OfWord.Length)
                    {
                       for (int i = 0; i < word.Length; i++)
                       {
                           outputWord += alphabetDecode[word[i]];
                       }
                    } 
                    else if(word.Length * 2 == Real_Lenght_OfWord.Length)
                    {
                        for (int i = 0; i < word.Length; i+=2)
                        {
                            outputWord += alphabetDecode[word[i]] + alphabetDecode[word[i+1]];
                        }
                    }
                    return outputWord;
                }

                return output;
            }



            info(EncodeInput, ConsoleColor.Magenta);
            Decode(EncodeInput);


            Write("Done");
            ReadLine();
        }
    }
}
