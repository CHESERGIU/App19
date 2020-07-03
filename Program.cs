using System;

namespace App19
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            float suma = float.Parse(inputData);
            int priceBred = 5;
            double priceEgg = 0.5;
            int priceApple = 3;

            double numberBreds, numberEggs, numbeApples, x;
            if (suma >= priceBred)
            {
                numberBreds = suma / priceBred;
                x = suma / (2*priceBred + 10*priceEgg + 3*priceApple);
                if (numberBreds >= 2)
                {
                    numberBreds = 2;
                    if (x >= 1)
                    {
                        numberBreds = 2 * Math.Floor(x);
                        Console.WriteLine(numberBreds);
                    }
                    else
                    {
                        Console.WriteLine(numberBreds);
                    }
                    if ((suma - (2 * priceBred)) >= priceEgg)
                    {
                        numberEggs = (suma - (2 * priceBred)) / priceEgg;
                        if (numberEggs >= 10)
                        {
                            numberEggs = 10;
                            if (x >= 1)
                            {
                                numberEggs = 10 * Math.Floor(x);
                                Console.WriteLine(numberEggs);
                            }
                            else
                            {
                                Console.WriteLine(numberEggs);
                            }
                            if ((suma - (2 * priceBred) - (10 * priceEgg)) >= priceApple)
                            {
                                numbeApples = (suma - (2 * priceBred) - (10 * priceEgg)) / priceApple;
                                if (numbeApples >= 3)
                                {
                                    numbeApples = 3;
                                    if (x >= 1)
                                    {
                                        numbeApples = 3 * Math.Floor(x);
                                        Console.WriteLine(numbeApples);
                                        Console.WriteLine("DA");
                                    }
                                    else
                                    {
                                        Console.WriteLine(numbeApples);
                                        Console.WriteLine("DA");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(Math.Floor(numbeApples));
                                    Console.WriteLine("NU");
                                }

                            }
                            else
                            {
                                numbeApples = 0;
                                Console.WriteLine(numbeApples);
                                Console.WriteLine("NU");

                            }
                        }
                        else
                        {
                            numberEggs = (suma - (2 * priceBred)) / priceEgg;
                            Console.WriteLine(Math.Floor(numberEggs));
                            numbeApples = 0;
                            Console.WriteLine(numbeApples);
                            Console.WriteLine("NU");

                        }

                    }
                    else
                    {
                        numberEggs = 0;
                        Console.WriteLine(numberEggs);
                        numbeApples = 0;
                        Console.WriteLine(numbeApples);
                        Console.WriteLine("NU");
                    }
                }
                else
                {
                    numberBreds = 1;
                    Console.WriteLine(numberBreds);
                    if (suma >= priceEgg)
                    {
                        numberEggs = (suma - priceBred) / priceEgg;
                        Console.WriteLine(Math.Floor(numberEggs));
                        numbeApples = 0;
                        Console.WriteLine(numbeApples);
                        Console.WriteLine("NU");
                    }
                }
            }
            else
            {
                numberBreds = 0;
                Console.WriteLine(numberBreds);
                numberEggs = suma / priceEgg;
                Console.WriteLine(Math.Floor(numberEggs));
                numbeApples = 0;
                Console.WriteLine(numbeApples);
                Console.WriteLine("NU");

            }
        }
    }
}
