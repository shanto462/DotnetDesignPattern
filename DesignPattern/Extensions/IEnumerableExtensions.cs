using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<string> SelectCustom<T>(this IEnumerable<T> list, Func<T, string> func)
        {
            foreach (var item in list)
                yield return func(item);
        }
    }
}
