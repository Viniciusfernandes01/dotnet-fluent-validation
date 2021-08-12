using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchoolManager
{
    public static class StringExtensions
    {
        public static bool IsValidDocument(this string document)
        {
            var expression = "[0-9]{3}\\.?[0-9]{3}\\.?[0-9]{3}\\-?[0-9]{2}"; //Valida cpf

            return Regex.Match(document, expression).Success;
        }
    }
}
