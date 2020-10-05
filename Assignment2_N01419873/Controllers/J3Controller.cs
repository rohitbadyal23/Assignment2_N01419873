using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Assignment2_N01419873.Controllers
{
    public class J3Controller : ApiController
    {

        /// <summary>
        ///  Recieves 2 inputs: t1 and t2 and provides the length of the sumac sequence
        /// </summary>
        /// <param name="t1">An integer number</param>
        /// <param name="t2">Another integer number</param>
        /// <example>Get api/J3/SumacSequence/120/71 -> 5</example>
        /// <returns>The length of the sumac sequence</returns>
        [Route("api/J3/SumacSequences/{t1}/{t2}")]
        public int GetSumacSequences(int t1, int t2)
        {
            int length = 2;
            while(t1>=t2 & t1>=0 & t2>= 0)
            {
                length = length + 1;
                int difference = t1 - t2;
                t1 = t2;
                t2 = difference;
            }
            return length;
        }
    }
}
