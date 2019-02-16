using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAlias
{
    public static class EnumerableAlias
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

        public static bool ForAll<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate
        ) => source.All(predicate);

        public static bool Exists<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> selector
        ) => source.Any(selector);

        public static TSource Reduce<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, TSource, TSource> func
        ) => source.Aggregate(func);

        public static TAccumulate Fold<TSource, TAccumulate>(
            this IEnumerable<TSource> source,
            TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func
        ) => source.Aggregate(seed, func);
    }
}
