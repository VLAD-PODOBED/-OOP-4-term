using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1TextCulculator
{

    static internal class Culculator
    {
        public static string ChengerText(string str, string podStr, string newPodStr)
        {
            return str.Replace(podStr, newPodStr);
        }

        public static string DeleteText(string str, string podStr)
        {
            return str.Replace(podStr, "");
        }

        public static string FindIndex(string str, string symbol)
        {
            return str.IndexOf(symbol).ToString();
        }

        public static string FindGlasniy(string str)
        {
            str = str.ToLower();
            int number = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (IsGlasniy(str[i]))
                {
                    number++;
                }
            }
            return number.ToString();
        }

        public static string FindSoglasniy(string str)
        {
            int number = str.Length - Convert.ToInt32(FindGlasniy(str));
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.' || str[i] == ',' || str[i] == ' ' || str[i] == '!' || str[i] == '?' || str[i] == ';' || str[i] == ':')
                {
                    number--;
                }
            }
            return number.ToString();
        }

        public static string CulcSentensice(string str)
        {
            bool Flag = true;
            int Number = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] == '.' && Flag) || (str[i] == '!' && Flag) || (str[i] == '?' && Flag))
                {
                    Number++;
                    Flag = false;
                }
                if (str[i] != '.' && str[i] != '!' && str[i] != '?')
                {
                    Flag = true;
                }
            }

            return Number.ToString();
        }

        public static string CulcWords(string str)
        {
            bool Flag = true;
            int Number = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] == ' ' && Flag) || (str[i] == '.' && Flag))
                {
                    Number++;
                    Flag = false;
                }
                if (str[i] != ' ' && str[i] != '.' && str[i] != '!' && str[i] != '?')
                {
                    Flag = true;
                }
            }
            if (str[str.Length - 1] != ' ' && str[str.Length - 1] != '.'
                    && str[str.Length - 1] != '!' && str[str.Length - 1] != '?')
            {
                Number++;
            }
            return Number.ToString();
        }

        public static bool IsGlasniy(char letter) =>
               letter == 'а' || letter == 'я' 
            || letter == 'у' || letter == 'ю' 
            || letter == 'о' || letter == 'е' 
            || letter == 'ё' || letter == 'ы' 
            || letter == 'э' || letter == 'и';

    }
}
