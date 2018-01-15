using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using Extensions;

namespace ZipCodeServiceLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTracingHost host = new MyTracingHost(typeof(ZipCodeService));
            MyStateContainer sc = new MyStateContainer("foo");
            host.Extensions.Add(sc);

            try
            {
                host.Open();
                
                Console.WriteLine("ZipCodeService is running. Press any key to exit.");
                Console.ReadKey();

                host.Close(); // successful close
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                host.Abort();
            }
        }
    }
}
