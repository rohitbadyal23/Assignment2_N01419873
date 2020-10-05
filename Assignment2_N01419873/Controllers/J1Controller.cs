using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;
using System.Web.Routing;

namespace Assignment2_N01419873.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Recieves 4 inputs of burger, drink, side and dessert choices and provides a messaging with the sum of the calories. 
        /// </summary>
        /// <param name="burger">The calorie of the burger</param>
        /// <param name="drink">The calorie of the drink</param>
        /// <param name="side">The calorie of the side</param>
        /// <param name="dessert">The calorie of the dessert</param>
        /// <example>Get api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0"</example>
        /// <example>Get api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691"</example>
        /// <returns>The total sum of all the 4 choices</returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            int calorie = 0;
            if(burger == 1)
            {
                calorie = 461;
            } else if(burger == 2)
            {
                calorie = 431;
            } else if(burger == 3)
            {
                calorie = 420;
            } else if(burger == 4)
            {
                calorie = 0;
            }

            if(drink == 1)
            {
                calorie = calorie + 130;
            } else if(drink == 2)
            {
                calorie = calorie + 160;
            } else if(drink == 3)
            {
                calorie = calorie + 118;
            } else if (drink == 4)
            {
                calorie = calorie + 0;
            }

            if (side == 1)
            {
                calorie = calorie + 100;
            }
            else if (side == 2)
            {
                calorie = calorie + 57;
            }
            else if (side == 3)
            {
                calorie = calorie + 70;
            }
            else if (side == 4)
            {
                calorie = calorie + 0;
            }

            if (dessert == 1)
            {
                calorie = calorie + 167;
            }
            else if (dessert == 2)
            {
                calorie = calorie + 266;
            }
            else if (dessert == 3)
            {
                calorie = calorie + 75;
            }
            else if (dessert == 4)
            {
                calorie = calorie + 0;
            }

            string total = "Your total calorie count is " + calorie;
            return total;
        }




    }
}
