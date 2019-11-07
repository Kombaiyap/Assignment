using System;

namespace VersionChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 ="1.4.0";
            string input2 = "2.4.0.1";

            var versionNumberObj = new VersionChecker();

            if(!versionNumberObj.IsValidVersion(input1))
            {
                Console.WriteLine($"{input1} is not a valid version number");
            }
            else if(!versionNumberObj.IsValidVersion(input2))
            {
                Console.WriteLine($"{input2} is not a valid version number");
            }
            else
            {
                Console.WriteLine(versionNumberObj.CheckVersions(input1, input2));
            }
           
        }
    }
}
