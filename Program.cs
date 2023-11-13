using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] studentScores = new int[3][];
            studentScores[0] =new int[3] {85,92,78};
            studentScores[1] = new int[4] { 90,87, 93, 89 };
            studentScores[2] = new int[2] { 76, 88 };


            Console.WriteLine("Displaying Scores of Each STudent: ");
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.WriteLine("Scores of the Student  " + (i + 1));
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j] + " ");
                }
                Console.WriteLine();
            }
                Console.WriteLine("********************************");
            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }
                double average = (double)sum / studentScores[i].Length;
                Console.WriteLine($"Average Score of Student {i+1} is: {average}");
            }
            Console.WriteLine("********************************");
            double totalSum = 0;
            int totalScores = 0;

            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalScores++;
                }
            }
            double TotalAverage = totalSum / totalScores;
            Console.WriteLine("Average Score of All Students is : {0}", TotalAverage);



            Console.ReadKey();



        }
    }
}
