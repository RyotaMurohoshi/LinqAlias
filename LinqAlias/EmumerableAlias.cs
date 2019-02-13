using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAlias
{
    public static class EmumerableAlias
    {
        public static IEnumerable<TResult> Map<TSource, TResult>(
            this IEnumerable<TSource> source, Func<TSource, TResult> selector
        ) => source.Select(selector);

        public static IEnumerable<TSource> Filter<TSource>(
            this IEnumerable<TSource> source, Func<TSource, Boolean> predicate
        ) => source.Where(predicate);

        public static IEnumerable<TResult> FlatMap<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, IEnumerable<TResult>> selector
        ) => source.SelectMany(selector);
    }
}