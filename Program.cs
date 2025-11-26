using System;
using System.Windows.Forms;

namespace RadioButtonsinActionPrjt
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmRadioStar());
        }
    }
}

internal static class Calculator
{
    public static int Add(int a, int b) => checked(a + b);
    public static int Subtract(int a, int b) => checked(a - b);
    public static int Multiply(int a, int b) => checked(a * b);
    public static int Divide(int a, int b) => a / b;
    public static int Modulus(int a, int b) => a % b;
}
