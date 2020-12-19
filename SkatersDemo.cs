using System;
using System.IO;
using System.Linq;

namespace MedalWinnersFinalProject
{
    public class SkatersDemo
    {
        public void SkatersFinalScore()
        {
            try
            {
                // Initializing array of Skaters objects and assigning 10 empty spaces.
                Skaters[] arrayOfSkaters = new Skaters[10];

                // Reading and Saving all lines as an Array
                var lines = File.ReadAllLines("/Users/douglasvinicio/Pairs.txt");

                // Index conter for arrayOfLines
                int index = 0;

                for (int i = 0; i < lines.Length; i+=5)
                {

                    var arrayOfLines = lines.Skip(i).Take(5).ToArray();
                                    
                    // Converting string to array of doubles using Array class
                    //Iterating through array and summing the fields
                    double[] technicalTotal = Array.ConvertAll(arrayOfLines[3].Split(' '), Double.Parse);
                    double technicalAverage = 0;
                    foreach (var item in technicalTotal)
                    {
                        technicalAverage += item;                 
                    }
                    technicalAverage = technicalAverage / technicalTotal.Length;



                    double[] performanceTotal = Array.ConvertAll(arrayOfLines[4].Split(' '), Double.Parse);
                    double performanceAverage = 0;
                    foreach (var item in performanceTotal)
                    {
                        performanceAverage += item;
                    }
                    performanceAverage = performanceAverage / performanceTotal.Length;




                    double finalScore = technicalAverage + performanceAverage;

                    arrayOfSkaters[index] = new Skaters(arrayOfLines[0], arrayOfLines[1], arrayOfLines[2], technicalAverage, performanceAverage,finalScore);

                    index++;                   
                }

                /* Using OrderByDescendings to sort the array from Higher to Lower final score.
                 * First filtering by final score, then by higher techical score and last but not least rechecking by higher performance score.
                 */
                var sorted = arrayOfSkaters.OrderByDescending(s => s.FinalScore).ThenBy(s => s.TechnicalScore).ThenBy(s => s.PerformanceScore).ToArray();

                // First place
                Console.WriteLine("\t####---Gold Medal---####\n");
                sorted[0].printInfo();

                // Second Place
                Console.WriteLine("\t####---Silver Medal---####\n");
                sorted[1].printInfo();

                // Third Place
                Console.WriteLine("\t####---Bronze Medal---####\n");
                sorted[2].printInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:" + e.Message);
            }
        }
    }
}


/*
foreach (var result in sorted)
                {                    
                    result.printInfo();                   
                }
*/