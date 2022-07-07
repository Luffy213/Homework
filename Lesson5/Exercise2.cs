using System;
using System.Text;
using System.Collections.Generic;

namespace ClassMessage
{
    static class Message
    {
        static public string text;

        static Message()
        {
            text = "Никакого упадка нет, да и быть не может. Просто цензуру смягчили, а частию, слава богу, и вовсе упразднили, и то, что раньше мы слышали в пивных и подворотнях, сегодня услаждает наш слух, доносясь с эстрады и с телеэкранов. Мы склонны считать это наступлением бескультурья и упадком Языка, но ведь бескультурье, как и всякая разруха, не в книгах и не на театральных подмостках, оно в душах и в головах. ";
        }
        static public void GetWordsByLength(int len)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });        
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= len)
                    Console.Write(word + " ");
            }
        }
        static public void DeleteWordByEndChar(char ch)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == ch)
                {
                    Console.Write(word + " ");
                    text.Replace(word, "");
                }
            }           
        }
        static public string FindMaxLengthWord()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }        
            return maxWord;
        }

        
        static public StringBuilder GetLongWordsString()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            StringBuilder result = new StringBuilder();
            int max = Message.FindMaxLengthWord().Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            return result;
        }

      
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа демонстрации возможностей статического класса Message.");

            Console.WriteLine("\nИмеется следующий текст: \n" + Message.text);

            Console.WriteLine("\nВыведем слова текста, которые содержат не более 5 букв:");
            Message.GetWordsByLength(5);

            Console.WriteLine();
            Console.Write("\nУдалим из текста слова, заканчивающиеся на 'а': ");
            Message.DeleteWordByEndChar('а');

            Console.WriteLine();
            Console.WriteLine("\nСамое длинное слово в тексте: " + Message.FindMaxLengthWord());


            Console.WriteLine("\nСформированная строка StringBuilder из самых длинных слов сообщения: \n" + Message.GetLongWordsString());

           

            Console.ReadKey();
        }

    }




}

