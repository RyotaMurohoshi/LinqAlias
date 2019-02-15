# LinqAlias

LinqAlias provides aliases of some `LINQ to Objects` methods.

# Why LinqAlias?

C# has LINQ to Objects that is great Collection methods.

But, if you have any other programming language experience, you may feel that LINQ method names strange. For example,

* `Where` method description is `Filters a sequence of values based on a predicate.`. In other programming language, this method called as `Filter`.
* `Select` method description is `Projects each element of a sequence into a new form.`. In other programming language, this method called as `Map`.

LinqAlias provides aliases of some `LINQ to Objects` methods. LinqAlias helps C# beginner with method aliases. Please do not use LinqAlias after you become familiar LINQ to Objects, Select, Where and others.

# Alias List

* Filter : [Where](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=netstandard-1.0) alias
* Map : [Select](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.select?view=netstandard-1.0) alias
* FlatMap : [SelectMany](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.selectmany?view=netstandard-1.0) alias
* ForAll : [All](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.all?view=netstandard-1.0) alias
* Exists : [Any](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.any?view=netstandard-1.0) alias
* Reduce : [Aggregate](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.aggregate?view=netstandard-1.0) alias
* Fold : [Aggregate](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.aggregate?view=netstandard-1.0) alias

# Usage

LinqAlias is available for download and installation as [NuGet packages](https://www.nuget.org/packages/LinqAlias/).

```csharp
using System;
using System.Linq;
using LinqAlias; // use LinqAlias namespace.

namespace HelloLinqAlias
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] {0, 1, 2, 3, 4};

            var message = string.Join(", ", array
                // use Map extension method as alias of Select.
                // You may be familiar Map method than Select method.
                .Map(it => it * it)
                 // use Filter extension method as alias of Where.
                 // You may be familiar Filter method than Where method.
                .Filter(it => it % 2 == 0)

                .ToArray()
            );

            Console.WriteLine(message);
        }
    }
}
```

# Author

Ryota Murohoshi is game Programmer in Japan.

* Posts:http://qiita.com/RyotaMurohoshi (JPN)
* Twitter:https://twitter.com/RyotaMurohoshi (JPN)

# License

This library is under MIT License.
