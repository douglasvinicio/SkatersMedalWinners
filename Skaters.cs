using System;
using System.Collections.Generic;

namespace MedalWinnersFinalProject
{
    public class Skaters
    {
        // Constructor Parameter
        public Skaters(string firstSkater, string secondSkater, string country, double technicalScore, double performanceScore,double finalScore)
        {
            FirstSkater = firstSkater;
            SecondSkater = secondSkater;
            Country = country;
            TechnicalScore = technicalScore;
            PerformanceScore = performanceScore;
            FinalScore = finalScore;
        }

        // Getters and Setters
        private string FirstSkater { get; set; }

        private string SecondSkater { get; set; }

        private string Country { get; set; }

        public double TechnicalScore { get; set; }

        public double PerformanceScore { get; set; }

        public double FinalScore { get; set; }

        // Print info method
        public void printInfo()
        {
            Console.WriteLine("\tSkaters: " + FirstSkater.ToUpper() + " and " + SecondSkater.ToUpper());
            Console.WriteLine("\tCountry: " + Country.ToUpper());
            Console.WriteLine("\tTotal Techical: " + TechnicalScore);
            Console.WriteLine("\tTotal Performance: " + PerformanceScore);
            Console.WriteLine("\tFinal Score: " + FinalScore);
            Console.WriteLine("\n");
        }
    }
}

