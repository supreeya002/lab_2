using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("กรุณาป้อนตัวเลข (พิมพ์ -1 เพื่อหยุด):");

            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == -1)
                    break;

                numbers.Add(input);
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("ไม่มีข้อมูล");
                return;
            }

            ShowResult(numbers);
        }

        static void ShowResult(List<int> numbers)
        {
            Console.WriteLine("ค่าเฉลี่ย = " + GetAverage(numbers));
            Console.WriteLine("ค่าสูงสุด = " + GetMax(numbers));
            Console.WriteLine("ค่าต่ำสุด = " + GetMin(numbers));
            Console.WriteLine("ค่ากลางข้อมูล = " + GetMedian(numbers));

            Console.WriteLine("เรียงจากมากไปน้อย:");
            ShowDescending(numbers);

            Console.WriteLine("เรียงจากน้อยไปมาก:");
            ShowAscending(numbers);
        }

        static double GetAverage(List<int> numbers)
        {
            return numbers.Average();
        }

        static int GetMax(List<int> numbers)
        {
            return numbers.Max();
        }

        static int GetMin(List<int> numbers)
        {
            return numbers.Min();
        }

        static double GetMedian(List<int> numbers)
        {
            var sorted = numbers.OrderBy(n => n).ToList();
            int count = sorted.Count;

            if (count % 2 == 0)
                return (sorted[count / 2 - 1] + sorted[count / 2]) / 2.0;
            else
                return sorted[count / 2];
        }

        static void ShowDescending(List<int> numbers)
        {
            foreach (int n in numbers.OrderByDescending(n => n))
                Console.Write(n + " ");
            Console.WriteLine();
        }

        static void ShowAscending(List<int> numbers)
        {
            foreach (int n in numbers.OrderBy(n => n))
                Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}
    

