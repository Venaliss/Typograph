using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Typograph
{
    public class Commands
    {
        //Правило 2 - Нельзя писать подряд более одного пробела.
        public string removeExcessiveSpaces(string text)
        {
            char behindChar = '\0';
            string result = "";

            foreach (char i in text)
            {
                if (!(i == ' ' && behindChar == ' '))
                {
                    result += i;
                }
                behindChar = i;
            }

            return result;
        }

        //Правило 16 - Между тире и предыдущим словом желательно всегда ставить непереносимый пробел...
        public string nonSpaceBeforeDash(string text)
        {
            char behindChar = '\0';
            string result = "";

            foreach (char i in text)
            {
                if (i == '-' && behindChar != ' ')
                {
                    result = result.TrimEnd() + " ";
                }
                result += i;
                behindChar = i;
            }

            return result;
        }

        //Правило 9 - Символ «плюс-минус» задаётся так: ± не нужно использовать конструкции типа «(+,−)».
        public string replacePlusMinusSymbol(string text)
        {
            return text.Replace("(+,-)", "±");
        }

        //Правило 7 - Использование дефиса при указании цифрового диапазона
        public string replaceDefisNumberRange(string text)
        {
            return Regex.Replace(text, @"\b(\d+)-(\d+)\b", "$1—$2");
        }

        //Правило 1 - Все знаки препинания пишутся слева слитно со словом, а справа отбиваются пробелом. 
        //Тире отбивается пробелами с двух сторон. 
        //Скобки и кавычки пишутся слитно со словами, которые находятся внутри них.
        public string punctuationsFix(string text)
        {
            string result = "";
            string punctuationChars = ".,:;!?()[]{}<>";

            for (int i = 0; i < text.Length; i++)
            {
                if (punctuationChars.Contains(text[i]))
                {
                    if (i > 0 && text[i - 1] != ' ')
                    {
                        result += " ";
                    }
                    result += text[i];
                    if (i < text.Length - 1)
                    {
                        result += " ";
                    }
                }
                else
                {
                    result += text[i];
                }
            }

            return result;
        }

        //Мое правило 1 - После конца предложения и начала нового, оно начинается с Заглавной буквы
        public string myRuleCapitalLetter(string text)
        {
            string result = "";

            bool capitalize = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (capitalize && char.IsLetter(text[i]))
                {
                    result += char.ToUpper(text[i]);
                    capitalize = false;
                }
                else
                {
                    result += char.ToLower(text[i]);
                }

                if (text[i] == '.')
                {
                    capitalize = true;
                }
            }

            return result;
        }

        //Мое правило 2 - Три точки заменяются на многоточие
        public string myRuleReplaceEllipsis(string text)
        {
            return text.Replace("...", "…");
        }

        //Мое абсурдное правило(Противоположно правилу 5 из списка правил)
        //Дефис пробелами не отбивается и всегда пишется слитно с частями слова или
        //цифр, которые он разделяет.
        public string myAbsurdRule(string text)
        {
            string[] words = text.Split('-');
            string result = string.Join("-", words);

            return result;
        }
    }
}
