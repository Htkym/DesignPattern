using System;
using System.Collections.Generic;

namespace Command.A2
{
    public static class EnumerableExtentions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var x in source)
            {
                action(x);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T, int> func)
        {
            var i = 0;
            foreach (var x in source)
            {
                func(x, i);
                i++;
            }
        }
    }
}