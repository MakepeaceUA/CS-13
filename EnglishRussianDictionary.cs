using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class EnglishRussianDictionary
    {
        private Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        public void AddWord(string ENWord, List<string> Translation)
        {
            if (!dictionary.ContainsKey(ENWord))
            {
                dictionary.Add(ENWord, Translation);
                Console.WriteLine($"Слово'{ENWord}' добавлено.");
            }
            else
            {
                Console.WriteLine($"Слово '{ENWord}' уже существует.");
            }
        }
        public void RemoveWord(string ENWord)
        {
            if (dictionary.ContainsKey(ENWord))
            {
                dictionary.Remove(ENWord);
                Console.WriteLine($"Слово '{ENWord}' удалено.");
            }
            else
            {
                Console.WriteLine($"Слово '{ENWord}' не найдено.");
            }
        }
        public void AddTranslation(string ENWord, string Translation)
        {
            if (dictionary.ContainsKey(ENWord))
            {
                dictionary[ENWord].Add(Translation);
                Console.WriteLine($"Перевод '{Translation}' к слову '{ENWord}' добавлен.");
            }
            else
            {
                Console.WriteLine($"Слово '{ENWord}' не найдено.");
            }
        }
        public void RemoveTranslation(string ENWord, string Translation)
        {
            if (dictionary.ContainsKey(ENWord))
            {
                if (dictionary[ENWord].Contains(Translation))
                {
                    dictionary[ENWord].Remove(Translation);
                    Console.WriteLine($"Перевод '{Translation}' для слова '{ENWord}' удалён.");
                }
                else
                {
                    Console.WriteLine($"Перевод '{Translation}' для слова '{ENWord}' не найдено.");
                }
            }
            else
            {
                Console.WriteLine($"Слово '{ENWord}' не найдено.");
            }
        }

        public void EditWord(string OldW, string NewW)
        {
            if (dictionary.ContainsKey(OldW))
            {
                List<string> translate = dictionary[OldW];
                dictionary.Remove(OldW);
                dictionary.Add(NewW, translate);
                Console.WriteLine($"Слово '{OldW}' изменено на '{NewW}'.");
            }
            else
            {
                Console.WriteLine($"Слово '{OldW}' не найдено.");
            }
        }
        public void EditTranslation(string ENWord, string OTranslate, string NTranslate)
        {
            if (dictionary.ContainsKey(ENWord))
            {
                if (dictionary[ENWord].Contains(OTranslate))
                {
                    int word = dictionary[ENWord].IndexOf(OTranslate);
                    dictionary[ENWord][word] = NTranslate;
                    Console.WriteLine($"Перевод '{OTranslate}' изменён на '{NTranslate}' для слова '{ENWord}'.");
                }
                else
                {
                    Console.WriteLine($"Перевод '{OTranslate}' для слова '{ENWord}' не найден.");
                }
            }
            else
            {
                Console.WriteLine($"Слово '{ENWord}' не найдено.");
            }
        }
        public void SearchTranslation(string ENWord)
        {
            if (dictionary.ContainsKey(ENWord))
            {
                Console.WriteLine($"Перевод для слова '{ENWord}':");
                foreach (var translation in dictionary[ENWord])
                {
                    Console.WriteLine(translation);
                }
            }
            else
            {
                Console.WriteLine($"Слово '{ENWord}' не найдено.");
            }
        }
    }
}
