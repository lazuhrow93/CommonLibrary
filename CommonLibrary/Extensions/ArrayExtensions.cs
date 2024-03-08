using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Extensions
{
    public static class ArrayExtensions
    {
        public static bool IsNullOrEmpty(this object[]? array)
        {
            return (array is null || array.Length == 0);
        }
    }
}
