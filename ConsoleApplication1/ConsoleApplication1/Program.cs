using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            StringBuilder ob = new StringBuilder();          //Объявляем объект класса StringBuilder;
            foreach (char i in str)
            {
                ob.Append(i);                                 //Добавляем в конец строки по одному символу из массива;
            }
            Console.WriteLine("Объект класса StringBuilder,в который записан массив символов:");
            Console.WriteLine(ob);
            ob.Insert(7, "hi");   //Добавляем,начиная с 7 позиции подстроку;
            Console.WriteLine("Объект класса StringBuilder,в который вставили произвольную строку,начиная с определенной позиции:");
            Console.WriteLine(ob);
            ob.Remove(2, 5);              //Начиная со второго символа,удаляем 5 символов;
            Console.WriteLine("Объект класса StringBuilder,из которого удалили произвольный диапазон символов:");
            Console.WriteLine(ob);
            ob.Replace("a", "A");        //Заменяем один символ на другой;
            Console.WriteLine("Объект класса StringBuilder,в котором заменили один символ на другой:");
            Console.WriteLine(ob);
            Console.Read();
        }
    }
}
