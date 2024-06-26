using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region control statment 1. conditional statments [if , swith]
            #region example 1 [numeric type]
            //Console.WriteLine("please enter an month numbers existed in 1st quarter");
            //int.TryParse(Console.ReadLine(), out int monthnumber);

            ///if (monthnumber == 1)
            ///{
            ///    Console.WriteLine("hello januwary");
            ///}
            ///else if (monthnumber == 2)
            ///{
            ///    Console.WriteLine("hello febrauray");
            ///
            ///}
            ///else if (monthnumber == 3)
            ///{
            ///    Console.WriteLine("hello march");
            ///}
            ///else {
            ///    Console.WriteLine("enterd number is not exsist in this quarter");
            ///}


            // jump table
            ///switch (monthnumber)
            ///{
            ///  case 1:
            /// Console.WriteLine("hello januwary");
            /// break;
            ///
            /// case 2: Console.WriteLine("hello febrauray");
            ///break;
            ///
            /// case 3:
            ///Console.WriteLine("hello march");
            ///break;
            ///default:
            ///Console.WriteLine("enterd number is not exsist in this quarter");
            ///break; 
            #endregion
            #endregion



            #region control statment 2. loop statments[for ,foreach,while ,do..while]
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);

            Console.WriteLine("******************");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

            }


            #endregion

            #region control statment 2.loop statment[for,foreach]
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < numbers.Length; i++) {
            //    // if (i==2)
            //    //break;
            //    numbers[i] += 10;
            //    Console.WriteLine(numbers[i]);


            //}
            //Console.WriteLine("*********************");
            //foreach(int number in numbers)
            //{
            //    //number +=10; // invalid
            //    Console.WriteLine(number);

            //}
            #endregion

            #region control statment 2.loop statment[while,do...while]
             int number;
              bool flag;

            /// do
            /// {
            ///Console.WriteLine("please enter an even number");
            ///  number = int.Parse(Console.ReadLine());
            /// flag = int.TryParse(Console.ReadLine(), out number);
            ///} while (!int.TryParse(Console.ReadLine(), out number) || number % 2 == 1); 

            /*
             sqlreader reader =new sqlreader();

            while(reader.read()){
            code
            }
             */

            ///int i= 1;
            ///while (i <= 10)
            ///{
            ///   Console.WriteLine(i);
            ///  i++;

            ///}




            #endregion

            #region string
            //string name;
            //declare for references of type string
            // this references 'name' is references to defult value of refernc = null
            //clr will allocate 4 bytes at stack for refring name
            //clr will allocate 0 bytes at heap

            //name = new string("ahmed");//clr will allocate 10 bytes at heap

            //name = "ahmed"; //syntax sugar
            //Console.WriteLine(name);

            //Console.WriteLine(name.GetHashCode());







            // string is class [reference type]
            //string is an immutable type --->cant be change [internally is an array of chars] 

            //string message = "hello";
            //Console.WriteLine($"message {message}");
            //Console.WriteLine($"hashcode {message.GetHashCode()}");

            //message += "ahmed"; Console.WriteLine("****************after change meessage");
            //Console.WriteLine($"message {message}");
            //Console.WriteLine($"hashcode {message.GetHashCode()}");


            //string name1 = "ahmed"; //has two refrences
            //string name2 = "mohamed"; //unretchable

            //name2 = name1;

            //name1 = "yassmin";

            //Console.WriteLine(name2); //ahmed







            #endregion

            #region stringbulder
            ////stringbulder is class [refernces]
            ////stringbulder is mutable string [internally,is linked-list of char]
            //StringBuilder message;
            ////declare for references of type string
            //// this references 'message' is references to defult value of refernc = null
            ////clr will allocate 4 bytes at stack for refring message
            ////clr will allocate 0 bytes at heap


            //message = new StringBuilder("hello");
            //Console.WriteLine($"message is {message}");
            //Console.WriteLine($"hashcode is {message.GetHashCode()}");
            //message.Append("ahmed");Console.WriteLine("after stringbulder changed");
            //Console.WriteLine($"message is {message}");
            //Console.WriteLine($"hashcode is {message.GetHashCode()}");
            #endregion

            #region stringbulder method
            //StringBuilder mess = new StringBuilder("hello");

            //mess.Append("ahmed");
            //mess.AppendLine("ali");
            //mess.Append("your age is 13");
            //mess.Remove(0, 5);
            //mess.Insert(0, "hi");
            //mess.Clear();

            //mess.AppendFormat("{0}  :  {1}", true, "a");
            //mess.AppendJoin(';', "ahli", "moaemd", "affg");
            //Console.WriteLine(mess);

            #endregion

        }


    }
    
}
