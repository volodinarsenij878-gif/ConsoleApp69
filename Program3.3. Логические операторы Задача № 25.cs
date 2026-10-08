using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Шаг 1: вычисляем отдельные сравнения
            bool part1 = 5 > 2;   // true
            bool part2 = 3 < 1;   // false

            // Шаг 2: объединяем через ИЛИ (||)
            bool inner = part1 || part2; // true || false → true

            // Шаг 3: применяем отрицание
            bool res = !inner;           // !true → false

            Console.WriteLine($"5 > 2 → {part1}");
            Console.WriteLine($"3 < 1 → {part2}");
            Console.WriteLine($"(5 > 2) || (3 < 1) = {inner}");
            Console.WriteLine($"!((5 > 2) || (3 < 1)) = {res}"); // False
        }
    }
}




