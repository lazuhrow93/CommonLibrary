using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyWing.Extensions
{
    public static class StringExtensions
    {
        public static bool Like(this string subject, string expected)
        {
            return (subject.ToLower().Equals(expected.ToLower()));
        }
    }
}
