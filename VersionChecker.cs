using System;
using System.Collections;

namespace VersionChecker
{
    class VersionChecker
    {
        public string CheckVersions(string versionNumber1, string versionNumber2)
        {
            var number1 = Array.ConvertAll(versionNumber1.Split('.'), int.Parse);
            var number2 = Array.ConvertAll(versionNumber2.Split('.'), int.Parse);
            var smallerArray = number1.Length < number2.Length ? number1 : number2;

            var outputString = string.Empty;

         if(versionNumber1.Equals(versionNumber2))
            {
                 outputString = "equals";
            }
            else
            {
                for (int i = 0; i < smallerArray.Length; i++)
                {
                    if (number1[i] < number2[i])
                    {
                        outputString = "before";
                        break;
                    }
                    else if (number1[i] > number2[i])
                    {
                        outputString = "after";
                        break;
                    }
                }

                if(string.IsNullOrEmpty(outputString))
                {
                    outputString = number1.Length > number2.Length ? "after" : "before";
                }
            }

            return string.Format("{0} is \"{1}\" {2}", versionNumber1, outputString, versionNumber2);
        }

        public bool IsValidVersion(string versionNumber)
        {
            try
            {
                Version.Parse(versionNumber);
                return true;
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex);
                return false;
            }
        }
    }
}
