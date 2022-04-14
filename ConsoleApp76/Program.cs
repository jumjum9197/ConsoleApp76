using System;

namespace ConsoleApp76
{
    internal class Program
    {
        static void Main()
        {
            // int sum = 1;
            //for(int i=1; i<=5; i++)
            //{
            //     sum=sum*i;
            //   Console.WriteLine(i);

            //}
            // Console.WriteLine(sum);

            ////while (i <= 10)
            ////{
            ////    Console.WriteLine(i);
            ////    i++;
            ////}
            ////int sum =0;
            ////do
            ////{
            ////    sum = sum + i;
            ////    Console.WriteLine(i);
            ////    i++;
            ////}while(i<=10);

            ////Console.WriteLine(sum);

            //Console.WriteLine("enter a number");
            //var d =Convert.ToInt32(Console.ReadLine());
            //int sumq = 1;
            // for(int i=1; i<=d; i++)
            // {
            //    sumq = sumq * i;
            //    Console.WriteLine(i);
            // }



            // buru d change calculator to convert dollar/ euro to naira
            temi:
            double naira = 500;
            double naira2 = 600;
            Console.WriteLine("note: use '$' for dollar and 'E' euro ");
            Console.WriteLine("enter your currency ");
            string currency = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine("enter the amount");
            var amount =Convert.ToDouble(Console.ReadLine());
            switch (currency)
            {
                case "$":
                case "s":
                case " DOLLAR":
                case "d":
                case "D":

                    Console.WriteLine(amount * naira);
                    break;
                case "E":
                case "EURO":
                    
                    Console.WriteLine(amount * naira2);
                    break;
                    default:
                    Console.WriteLine("invalid currncy");
                    break;
                    
            }

            goto temi;

        }
    }
}
