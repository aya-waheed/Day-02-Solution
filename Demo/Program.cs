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
            int Id = 10;

            //PascalCase -> FirstName
            //camelCase -> firstName
            //kabab-case -> first-name[Angular Files Naming]
            //snake_case -> first_name

            Console.WriteLine(Id); 
            #endregion

        }
    }
}
