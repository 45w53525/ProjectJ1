using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01.Controllers
{
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/caloriecount/{burger}/{drink}/{order}/{dessert}")]
        public string caloriecount(int burger, int drink, int order, int dessert)
        {

           


            int burgerCol = burgerchoices(burger);
            int drinkCol = Drinkchoice(drink);
            int orderCol = orderchoice(order);
            int dessertCol = Dessertchoice(dessert);
            int Total = burgerCol + drinkCol + orderCol + dessertCol;
            return "Your Total calories " + Total.ToString();

        }




            public int burgerchoices(int val)
            {
                int burgerchoices = val;

                if (burgerchoices == 1)
                    return 461;

                if (burgerchoices == 2)
                    return 431;

                if (burgerchoices == 3)
                    return 420;

                return 0;

            }

            public int Drinkchoice(int val)
            {
                int burgerchoices = val;

                if (burgerchoices == 1)
                    return 130;

                if (burgerchoices == 2)
                    return 160;

                if (burgerchoices == 3)
                    return 118;

                return 0;


            }


            public int orderchoice(int val)
            {
                int burgerchoices = val;

                if (burgerchoices == 1)
                    return 100;

                if (burgerchoices == 2)
                    return 57;

                if (burgerchoices == 3)
                    return 70;

                return 0;

            }


            public int Dessertchoice(int val)
            {
                int burgerchoices = val;

                if (burgerchoices == 1)
                    return 167;

                if (burgerchoices == 2)
                    return 266;

                if (burgerchoices == 3)
                    return 75;

                return 0;



            }









        [HttpGet]
        [Route("api/getcombinations/{x}/{y}")]



        public string getCombinations(int x, int y)
        {

            int a = 0;

            for (int a = 1; a <= x; a++)
            {
                for (int b = y; b >= a; b--)
                {
                    int c = a + b;

                    if (c == 10) {
                        a++;

                        return "There are" + a + "total ways to get the sum 10";
                    }
                    {



                    }



                }
            }




        }

    }

























