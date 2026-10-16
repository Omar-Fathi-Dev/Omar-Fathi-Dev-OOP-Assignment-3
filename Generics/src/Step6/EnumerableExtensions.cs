namespace GenericStore.Step6;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> items , int pageNumber, int pageSize)
    {
        if (items is null) throw new ArgumentNullException(nameof(items));
        if (pageNumber <= 0 ) throw new ArgumentOutOfRangeException(nameof(pageNumber));
        if (pageSize <= 0 ) throw new ArgumentOutOfRangeException(nameof(pageSize));
        
        int count = 1;
        int first = (pageNumber - 1) * pageSize + 1;
        foreach (var i in items)
        {
            if (count >= first && count <= pageSize + first - 1)
            {
                yield return i;
            }
            count++;
            if(count > pageSize + first - 1)
                yield break;
        }
    }

    public static T FindById<T>(this IEnumerable<T> items, int id) where T : IHasId
    {
        if (items is null) throw new ArgumentNullException(nameof(items));

        foreach (var item in items)
            if (item.Id == id)
                return item;
        return default;
    }

    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> items) where T : IHasId
    {
        if (items is null) throw new ArgumentNullException(nameof(items));
        Dictionary<int , T> dict = new Dictionary<int, T>();
        foreach (var item in items)
            if (!dict.TryAdd(item.Id, item))
                throw new ArgumentException($"An item with Id {item.Id} already exists.", nameof(item));
            

        IReadOnlyDictionary<int, T> readOnlyItems = dict;
        return readOnlyItems;
    }
}