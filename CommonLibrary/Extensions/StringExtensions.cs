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
            if (subject == null) return (expected == null);
            if (expected == null) return false;
            return (subject.ToLower().Equals(expected.ToLower()));
        }

        public static bool NotLike(this string subject, string expected)
        {
            return !(subject.Like(expected));
        }
    }
}
