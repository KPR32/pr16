using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace пр16
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //StreamWriter sw1 = new StreamWriter("t1.txt");
            //string s1 = "Слон и моська. Слон повстречал моську и СЛОН …";
            //sw1.WriteLine(s1);
            //sw1.Close();
            //StreamReader sr = new StreamReader("t1.txt");
            //string str = sr.ReadToEnd();
            //sr.Close();
            //str = str.ToLower();
            //string[] word = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Console.Write("Введите слово для поиска: ");
            //string p = Console.ReadLine();
            //var selectedWord = from k in word where k.Contains(p.ToLower()) select k;
            //if (p.Length != 0)
            //{
            //    if (selectedWord.Count() > 0)
            //    {
            //        Console.WriteLine($"Были найдены {selectedWord.Count()} вхождения(ий) слова '{p}'");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Такое слово не найдено");
            //    }
            //}
            //else
            //    Console.WriteLine("Ничего не введено");

            //2
            //Console.WriteLine("Введите строку");
            //string s2 = Console.ReadLine();
            //Console.WriteLine("Выберите что нужно сделать");
            //Console.WriteLine("1 - количество цифр и их вывод");
            //Console.WriteLine("2 - Вывод на экран всех элементов массива, пока не встретится символ “/”");
            //Console.WriteLine("3 - Вывод всех элементов массива, которые содержатся после символа “/” и с заменой регистра на противоположный");
            //int answer = Convert.ToInt32(Console.ReadLine());
            //if (answer == 1)
            //{
            //    m1();
            //}
            //if (answer == 2)
            //{
            //    m2();
            //}
            //if (answer == 3)
            //{
            //    m3();
            //}
            //if (answer != 1 && answer != 2 && answer != 3)
            //{
            //    Console.WriteLine("Неккоректный ответ");
            //}



            //void m1()
            //{
            //    char[] numbers = new char[s2.Length];
            //    for (int i = 0; i < s2.Length; i++)
            //    {
            //        if (s2[i] != ' ')
            //        {
            //            numbers[i] = s2[i];
            //        }

            //    }
            //    var selectedWord = from k in numbers where char.IsNumber(k) select k;
            //    Console.WriteLine($"Было найдено {selectedWord.Count()} цифр: ");
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] != '/')
            //        {
            //            if (char.IsNumber(numbers[i]))
            //            {
            //                Console.Write(numbers[i]);
            //            }
            //            if (char.IsLetter(numbers[i]))
            //            {

            //            }
            //        }
            //    }
            //}


            //void m2()
            //{
            //    char[] numbers = new char[s2.Length];
            //    for (int i = 0; i < s2.Length; i++)
            //    {
            //        if (s2[i] != ' ')
            //        {
            //            numbers[i] = s2[i];
            //        }
            //    }
            //    var selectedWord = from k in numbers where char.IsNumber(k) select k;
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] == '/')
            //        {
            //            i = numbers.Length;
            //        }
            //        else
            //        {
            //            if (char.IsNumber(numbers[i]))
            //            {
            //                Console.Write(numbers[i]);
            //            }
            //            if (char.IsLetter(numbers[i]))
            //            {

            //            }
            //        }
            //    }
            //}

            //void m3()
            //{
            //    string[] numbers = s2.Split(' ', StringSplitOptions.RemoveEmptyEntries);                
            //    var s4 = s2.SkipWhile(x => x !='/');
            //    var s3 = s4.Skip(1);
            //    foreach (char ch in s3)
            //    {                    
            //        {                        
            //            char reg;
            //            if (Char.IsLower(ch))
            //            {
            //                reg = Char.ToUpper(ch);
            //            }
            //            else
            //            {
            //                reg = Char.ToLower(ch);
            //            }
            //            Console.Write(reg.ToString());                        
            //        }
            //    }                
            //} 


            //3
            //double[] numbers = new double[] { 5.1, 5.1, 5.1, 3, 4, 4};            
            //Console.WriteLine("Вывод чисел и их количества в массиве");
            //for (int i=0;i<numbers.Length;i++)     
            //{
            //    var same = from k in numbers where k == numbers[i] select k;                
            //    Console.WriteLine("Число "+numbers[i]+" встретилось "+same.Count()+ " раз");
            //}
            //Console.WriteLine("Вывод чисел умноженных на их количество");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    var same = from k in numbers where k == numbers[i] select k;
            //    Console.WriteLine("Число " + numbers[i] * same.Count());
            //}
        }
    }
}        