# LinqAlias

LinqAlias provides aliases of next LINQ to Objects methods.

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
using LinqAlias;

namespace HelloLinqAlias
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] {0, 1, 2, 3, 4};

            var message = string.Join(", ", array
                .Map(it => it * it)
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
