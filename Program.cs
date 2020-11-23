using System;

namespace _07.tryFinally
{
    class Program
    {
        

        
        static void Main(string[] args)
        {

            static void Divide(int a ) 
            {
                if (a == 10)
                {
                    throw new FormatException("The input number can not be ten");
                }
                int resutl = 10 / a;
            }
            static void ReadNumber() 
            {
                int a = int.Parse(Console.ReadLine());
                Divide(a);
            }
            try
            {
                ReadNumber();
            }
            catch (Exception)// this here is a Global Exception --this is not a good practice
            {

                Console.WriteLine("Program failed, because the number was wrong");
                throw;

            }
            finally 
            {
                Console.WriteLine("always perform this  code");
            }
            Console.WriteLine("....."); // ->this code here may not be performed ->after the finally

            //catching the exceptions must be on most detailed niveu, Specific Expections ...then general exceptions
            //going down to general niveu //
            //Detailed Exception //--catehces only this detailed case exception! 
            // if i expect the code to get me back ZeroDivisionException or FormatExceptions i will do them
            //to generalize Exceptions is bad practive -example catch(Exception){to do sth}--catches allType Exceptions
            // all Exceptions to throw an adequate describable messages ! 
            //exceptions Message shoud describe and explain what causes the problem and to solve it like
            //the input number must be integer  format in a range ;
            //the exceptions lead to bad performance becasue may call lot of methods and slow the program
            //Exceptions provide flexible error handling mechanism in.Net
            //allow errors to be handeled in multiple levels
            //eache exception handler processes only erros of particular type, other types are processed by sb else later
            //unhandled exceptions cause error message /
            //try finally ensures given code will be always executerd no matter what exception  is thrown or not thronw
        }
    }
}
