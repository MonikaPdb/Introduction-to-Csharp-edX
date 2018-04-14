using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2_variable_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student information
            string SFirstName = "";
            string SLastName = "";
            DateTime SBirthDate;
            string SAddressLine1 = "";
            string SAddressLine2 = "";
            string SCity = "";
            string SState = "";
            int SPostalCode = 0;
            string SCountry = "";

            // Teacher information
            string TFirstName = "";
            string TLastName = "";
            DateTime TBirthDate;
            string TAddressLine1 = "";
            string TAddressLine2 = "";
            string TCity = "";
            string TState = "";
            int TPostalCode = 0;
            string TCountry = "";

            // Program Information
            string ProgramName = "";
            string DepartmentHead = "";
            string Degree = "";

            // Degree information
            string DegreeName = "";
            int CreditsRequired = 0;

            // Course information
            string CourseName = "";
            int Credits = 0;
            int DurInWeeks = 0;
            string Teacher = "";

            // Assigning values to variables
            SFirstName = "Monika";
            SLastName = "Pdb";
            SBirthDate = new DateTime(1992, 5, 17);
            SAddressLine1 = "Polni";
            SAddressLine2 = "27";
            SCity = "Brno";
            SState = "Moravia";
            SPostalCode = 63900;
            SCountry = "Czechia";

            // Console output
            Console.WriteLine(SFirstName);
            Console.WriteLine(SLastName);
            Console.WriteLine(SBirthDate);
            Console.WriteLine(SAddressLine1);
            Console.WriteLine(SAddressLine2);
            Console.WriteLine(SCity);
            Console.WriteLine(SState);
            Console.WriteLine(SPostalCode);
            Console.WriteLine(SCountry);

            Console.WriteLine("Enter input name:");
            TFirstName = Console.ReadLine();
            Console.WriteLine("Enter input last name:");
            TLastName = Console.ReadLine();
            Console.WriteLine("Enter input date of birth:");
            DateTime.TryParse(Console.ReadLine(), out TBirthDate);
            Console.WriteLine("Enter input address line 1:");
            TAddressLine1 = Console.ReadLine();
            Console.WriteLine("Enter input address line 2:");
            TAddressLine2 = Console.ReadLine();
            Console.WriteLine("Enter input city:");
            TCity = Console.ReadLine();
            Console.WriteLine("Enter input state or province:");
            TState = Console.ReadLine();
            Console.WriteLine("Enter input postal code:");
            TPostalCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter input country:");
            TCountry = Console.ReadLine();


            Console.WriteLine(TFirstName);
            Console.WriteLine(TLastName);
            Console.WriteLine(TBirthDate);
            Console.WriteLine(TAddressLine1);
            Console.WriteLine(TAddressLine2);
            Console.WriteLine(TCity);
            Console.WriteLine(TState);
            Console.WriteLine(TPostalCode);
            Console.WriteLine(TCountry);
        }
    }
}
