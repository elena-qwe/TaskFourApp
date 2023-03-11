// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using System.Text.RegularExpressions;
using static System.DateTime;

namespace TaskFourApp;
 

public class Program
{
    public static void Main(string[] args)
    {
        
    }

    public static bool MethodMoreBetweenTwoNumbers(int a, int b)
    {
        if (a > b)
        {
            return true;
        }
        else return false;
    }

    public static int MethodMeterToCentimeter(int a)
    {
        return a * 100;
    }

    public static bool MethodCheckData(int d, int m)
    {
        if (DateTime.DaysInMonth(2023, m) < d)
        {
            return false;
        }
        else return true;
    }

    public static bool MethodAuthUser( string l, string p)
    {
        
        if ( l == "login" && p == "password") return true;
        else return false;
    }

    public static bool MethodRegisterUser(string l, string p, string e, string data)
    {
        string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                         @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

        DateTime date_1;
        if (l != null && p != null && Regex.IsMatch(e,  pattern, RegexOptions.IgnoreCase) && DateTime.TryParse(data, out date_1)) 
        {return true;}
        else return false;
    }
}