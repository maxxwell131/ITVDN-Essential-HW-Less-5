using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        /*
         Используя Visual Studio, создайте проект по шаблону Console Application.  
        Требуется:  
        Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера 
        с возможностью изменения числа строк и столбцов.  
        Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков. 
        */
        static void Main(string[] args)
        {
            MyMatrix m = new MyMatrix(4, 5);
            m.Show();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("[1][2] = {0}", m[1, 2]);
            Console.WriteLine("[6][2] = {0}", m[6, 2]);
            m[0, 0] = 11;

            Console.WriteLine(new string('-', 30));
            m.ChengeSize(7, 6);
            m.Show();

            Console.WriteLine(new string('-', 30));
            m.ShowPartly(1, 0, 4, 4);

            //Delay
            Console.ReadKey();
        }
    }
}
