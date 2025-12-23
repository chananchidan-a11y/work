using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Function
{
    internal class Program
    {
            static void Main()
            {
                Console.WriteLine("กรุณาใส่ตัวเลข (คั่นด้วยช่องว่าง):");
                string input = Console.ReadLine();

                List<double> numbers = input
                    .Split(' ')
                    .Select(double.Parse)
                    .ToList();

                Console.WriteLine($"ค่าเฉลี่ย: {GetAverage(numbers)}");
                Console.WriteLine($"ค่าสูงสุด: {GetMax(numbers)}");
                Console.WriteLine($"ค่าต่ำสุด: {GetMin(numbers)}");
                Console.WriteLine($"ค่ากลางข้อมูล: {GetMedian(numbers)}");

                Console.WriteLine("เรียงจากมากไปน้อย:");
                ShowDescending(numbers);

                Console.WriteLine("เรียงจากน้อยไปมาก:");
                ShowAscending(numbers);
            }

            static double GetAverage(List<double> nums)
            {
                return nums.Average();
            }

            static double GetMax(List<double> nums)
            {
                return nums.Max();
            }

            static double GetMin(List<double> nums)
            {
                return nums.Min();
            }

            static double GetMedian(List<double> nums)
            {
                var sorted = nums.OrderBy(n => n).ToList();
                int count = sorted.Count;

                if (count % 2 == 0)
                    return (sorted[count / 2 - 1] + sorted[count / 2]) / 2;
                else
                    return sorted[count / 2];
            }

            static void ShowDescending(List<double> nums)
            {
                foreach (var n in nums.OrderByDescending(n => n))
                    Console.Write(n + " ");
                Console.WriteLine();
            }

            static void ShowAscending(List<double> nums)
            {
                foreach (var n in nums.OrderBy(n => n))
                    Console.Write(n + " ");
                Console.WriteLine();
            }
        }
    }
        
        
    

