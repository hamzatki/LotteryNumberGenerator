
namespace LotteryNumberGenerator.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Generator : IGenerator
    {

        public Generator()
        {
                
        }

        public List<int> GenerateNumbers(int totalBalls)
        {

            var randomBalls = new List<int>();

            Random r = new Random();

            //for(int i = 1; i<= totalBalls; i++)
            //{
            //    randomBalls.Add(r.Next(1, 50));
            //}

            randomBalls = Enumerable.Range(1, 49).OrderBy(x => r.Next()).Take(totalBalls).ToList();


            return randomBalls;
        }

    }
}