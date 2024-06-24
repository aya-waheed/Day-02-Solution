namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Comments

            // Single Line Comment

            /*
             * 
             * Multi
             * Line
             * Comment
             * 
             *
             * 
             * */

            #endregion


            #region Variable Declaration
            //int Id = 10;

            ////PascalCase -> FirstName
            ////camelCase -> firstName
            ////kabab-case -> first-name[Angular Files Naming]
            ////snake_case -> first_name

            //Console.WriteLine(Id);
            #endregion


            #region ValueType
            //int X;
            ////CLR Will Allocate 4 UnInitialized Bytes at STACK
            ////int : C# Keyword

            //X = 5;

            //Int32 Y = 10;
            ////CLR Will Allocate 4 Initialized Bytes at STACK = 10
            ////Int32 : BCL

            //Y = X; //5

            //X++; //6 

            //Console.WriteLine(Y);
            #endregion



            #region ReferenceType

            Point P1;
            ///Declare of Reference of type "Point" , Refering to NULL
            ///This Reference 'P1' Can Refer to an Object from type "Point" OR Another type "Inherting from Point"
            ///CLR Will Allocate 4 Bytes For The Reference at STACK
            ///CLR Will Allocate 0 Bytes at HEAP

            P1 = new Point() /*Has 2 References[P1 , P2] (اسمين دلع)*/ ; // X = 0 , Y = 0
            ///new
            /// 1. Allocate Required Number of Bytes in Heap (Object Size + CLR Overhead Variables)
            /// 2. Initialize (cross out) Allocated Bytes With Default Values of Its DataType
            /// 3. Call User-Defined Constructor [if exists]
            /// 4.Assign The allocated Object to The Reference 'P1'



            Point P2 = new Point() /*Unreachable Object*/;

            P2 = P1;

            P2.X = 10;

            Console.WriteLine(P1.X); 
            #endregion




        }
    }
}
