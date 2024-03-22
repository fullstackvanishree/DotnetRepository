//CW +tab key------Console.WriteLine()
//ctrl+Kc------Commenting lines
//ctrl+KU----Uncommenting lines
//ctrl+Kd----selelct all and do Alignment
/* this is multi line comment
    using ------
*/
namespace ConsoleAppDotnetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region variables and Datatypes
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("C# Training");
            //Console.WriteLine("Shortcutkeys");
            //declaring
            //int productId;
            //intializing variable
            //productId = 100;
            //int productId = 100;
            //string productName = "Laptop";
            //decimal productPrice = 50000m;
            //float productRating = 4.4f;

            //Implicit Type Declaration
            //var userId = 500;
            //var userName = "vanishree";
            //Console.WriteLine($"ID::{userId}\tName::{userName}");

            ////Print all the info to the console
            //Console.WriteLine($"Id::{productId}\tName::{productName}\tPrice::{productPrice}\tRating::{productRating}");
            #endregion
            #region UserInput
            //User Input
            //Console.WriteLine("Enter Your Id::");
            //int userId = int.Parse(Console.ReadLine());
            //int user_Id=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Your Name::");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"Id::{userId}\t Name::{userName}");
            #endregion
            #region Nullable Types
            // int? userId = default;
            //int? userId = null;
            ////assign nullable type to non-nullable
            //int userRollNum = userId ?? 0;
            //bool? registeredUser = default;
            //string userName = default;
            //string password = null;
            //registeredUser = null;

            //Console.WriteLine($"Default Values are::{userId},{userName}, {registeredUser}");
            #endregion
            #region Dynamic Type
            //Dynamic Type
            //dynamic variable1;
            //variable1 = 100;
           
            //Console.WriteLine(variable1.GetType());
            //// variable1 = "vanishree";

            //Console.WriteLine(variable1);
            #endregion

            //Login Function
            //Get User Input
            Console.WriteLine("Enter you Name::");
            string userName=Console.ReadLine();
            Console.WriteLine("Enter Your Password::");
            string password=Console.ReadLine();
            if (userName == "vanishree" && password == "vani@123")
            {
                Console.WriteLine("Login Successfull");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }



        }
    }
    
}

