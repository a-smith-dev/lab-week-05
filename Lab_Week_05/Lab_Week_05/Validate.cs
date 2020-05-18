using System;
using System.Text.RegularExpressions;

namespace Lab_Week_05
{
    static class Validate
    {
        public static Category CategoryCheck(string response)
        {
            Category result;
            while (!Enum.TryParse<Category>(response, true, out result))
            {
                Console.Write("Please enter a valid category: ");
                response = Console.ReadLine();
            }
            return result;
        }
        public static string YesNo(string response)
        {
            response = response.ToLower();
            while (!Regex.IsMatch(response, "^[yn]$"))
            {
                Console.Write("Please enter y or n: ");
                response = Console.ReadLine().ToLower();
            }
            return response;
        }
    }
}
