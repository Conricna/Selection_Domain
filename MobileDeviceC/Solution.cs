using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MobileDeviceC
{
    internal class Solution
    {
        public static String Arg()
        {
            String answer ="Hello, World!";
            return answer;
        }
       
        public static int[] solution(string[] A, string[] B )
        {
            int[] allowed = new int[A.Length];

            for (int i = 0; i < allowed.Length; i++)
            {
                allowed[i] = i+1;
            }
            int count = 0;
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {

                    Regex regex = new Regex($@"{B[i]}");
                    MatchCollection matches = regex.Matches(A[j]);
                    if (matches.Count > 0)
                    {
                        allowed[j] = -1;                       
                        ++count;
                        break;
                    }
                }
            }
            allowed = allowed.Where(e => e != -1).ToArray();
            Array.Resize(ref allowed, A.Length - count);
            
            return allowed;
        }

        //                              Ниже тот самый фрагмент, который отвечает за выбор пользователя 
        
        public static string solutionans(string[] A, string[] B, int numarr)
        {
            string answer = "На данный момент работа завершена :)";
            int count = 0;
            string domen = "";
            for (int i = 0; i < B.Length; i++)
            {
                Regex regex = new Regex($@"{B[i]}");
                try
                {
                    MatchCollection matches = regex.Matches(A[numarr]);

                    if (matches.Count > 0)
                    {
                        domen = B[i];
                        ++count;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Вы выбрали не допустимый домен!\n");
                    ++count;
                    return answer;
                }
            }
            if (count == 0)
                Console.WriteLine("\nПереход можно выполнить\n");
            else
                Console.WriteLine($"\nДоступ к домену ограничен {domen} \n");



            return answer;
        }
    }
}
