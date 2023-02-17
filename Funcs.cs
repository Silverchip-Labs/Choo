namespace Choo;

public static class Funcs
{
    public static IEnumerable<TResult> CoolSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
    {
        var result = new List<TResult>();
        foreach (var element in source)
        {
            result.Add(selector(element));
        }

        return result;
    }

    public static IEnumerable<T> CoolWhere<T>(this IEnumerable<T> source, Func<T, bool> selector)
    {
        var result = new List<T>();
        foreach (var element in source)
        {
            if (selector(element))
            {
                result.Add(element);
            }
        }

        return result;
    }
    
    
    // CoolAggregate
    public static T CoolAggregate<T>(this IEnumerable<T> source, Func<T, T, T> func)
    {
        // todo
    } 
}