using System;

namespace _02.Company_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName, companyAddr, phoneNumber, faxNumber, webSite, manFname, manLname, manAge, manPhone;

            companyName = Console.ReadLine(); if (companyName.Length == 0) return;
            companyAddr = Console.ReadLine(); if(companyAddr.Length == 0) return;
            phoneNumber = Console.ReadLine(); if(phoneNumber.Length == 0) return;
            faxNumber = Console.ReadLine();
            webSite = Console.ReadLine(); if(webSite.Length == 0) return;
            manFname = Console.ReadLine(); if(manFname.Length == 0) return;
            manLname = Console.ReadLine(); if(manLname.Length == 0) return;
            manAge = Console.ReadLine(); if(manAge.Length == 0) return;
            manPhone = Console.ReadLine(); if(manPhone.Length == 0) return;

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddr);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber.Length == 0 ? "(no fax)" : faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", manFname, manLname, manAge, manPhone);
        }
    }
}
