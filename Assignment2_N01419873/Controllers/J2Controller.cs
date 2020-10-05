using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01419873.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Recieves 2 inputs: m, n and provides a message with the total possible ways of getting a sum of 10
        /// </summary>
        /// <param name="m">One dice has m sides labelled 1,2,3 ..., m</param>
        /// <param name="n">The other dice has n sides labelled 1,2,3, ...,n</param>
        /// <example>Get api/J2/DiceGame/6/8 -> "There are 5 total ways to get the sum 10."</example>
        /// <example>Get api/J2/DiceGame/5/5 -> "There is 1 total ways to get the sum 10."</example>
        /// <returns>The number of ways two dice can roll the value of 10</returns>
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string GetDiceGame(int m, int n)
        {
            int sum = 0;
            foreach(int i in Enumerable.Range(1,m))
            {
                if (10 - i <= n & 10 - i > 0)
               {
                    sum = sum + 1;
               }

            }

            string delimeter = "are";
            if (sum == 1)
            {
                delimeter = "is";
            } 

            string message = "There " + delimeter + " " + sum + " total ways to get the sum 10.";
            return message;

        }

    }
}
