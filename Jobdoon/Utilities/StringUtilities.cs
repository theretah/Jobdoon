using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Globalization;

namespace Jobdoon.Utilities
{
    public static class StringUtilities
    {
        public static string Divide3DigitsByComma(int input)
        {
            return input.ToString("N0");
        }
    }
}
