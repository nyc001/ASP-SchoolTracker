using System;
namespace Util
{
    class Console
    {
        static public string Ask(string question)
        {
            System.Console.WriteLine(question);
            return System.Console.ReadLine();
        }

        static public int AskInt(string question)
        {
            try
            {
                System.Console.WriteLine(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception ex)
            {
                throw new FormatException("No number was inputed");
            }
           
        }
    }
}
