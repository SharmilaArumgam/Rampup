using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sample
{
    class ExceptionSample
    {
        public static void Main(string[] args)
        {
            //Divide by zero exception

            try
            {
                try
                {
                    try
                    {

                        Console.WriteLine("Enter First Number:");
                        int FNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Second Number:");
                        int SNo = Convert.ToInt32(Console.ReadLine());

                        int Result = FNo / SNo;

                        Console.WriteLine("Result={0}", Result);

                    }
                    catch (Exception ex)
                    {
                        string filePath = @"C:\SampleFile\log.txt";
                        if (File.Exists(filePath))
                        {
                            StreamWriter sw = new StreamWriter(filePath);
                            sw.Write(ex.GetType().Name);
                            sw.WriteLine();
                            sw.Write(ex.Message);
                            sw.Close();
                            Console.WriteLine("Please try again later..");
                        }
                        else
                        {
                            throw new FileNotFoundException(filePath + "is not present" ,ex);
                        }
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Outer exception:{0}", exception.GetType().Name);
                    if (exception.InnerException.GetType().Name != null)
                    {
                        Console.WriteLine("Inner exception:{0}", exception.InnerException.GetType().Name);
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("FilePath is Empty.");
                Console.Write("CurrentException:{0}", e.GetType().Name);
            }

        }
    }
}
