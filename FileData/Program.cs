using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            Printdetails(args);

        }

        public static void Printdetails(string[] a)
        {
            try
            {
                List<string> vpram = new List<string>
                {
                    "-v",
                    "--v",
                    "/v",
                    "--version"
                };
                List<string> spram = new List<string>
                {
                    "-s",
                    "--s",
                    "/s",
                    "--size"
                };

                if (a[0] == "-v")
                {
                    FileDetails fileDetails = new FileDetails();
                    Console.WriteLine(fileDetails.Version(a[1]));
                }

                if (vpram.Contains(a[0]))
                {
                    FileDetails fileDetails = new FileDetails();
                    Console.WriteLine(fileDetails.Version(a[0]));
                }
                else if (spram.Contains(a[0]))
                {
                    FileDetails fileDetails = new FileDetails();
                    Console.WriteLine(fileDetails.Size(a[0]));
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        
    }
}
