namespace GenericStore.Step3;

public class Store<T>  where T :class , IHasId
{
    private Dictionary<int , T> _items = new();
    public IReadOnlyDictionary<int, T> Items => _items;
    
    public void Add(T item)
    {
        if (item is null)
            throw new ArgumentNullException(nameof(item));

        if (!_items.TryAdd(item.Id, item))
            throw new ArgumentException($"An item with Id {item.Id} already exists.", nameof(item));
    }

    public T? GetById(int Id)
        => _items.TryGetValue(Id, out T? item) ? item : null;
    
    public IReadOnlyDictionary<int , T> GetAll() => Items;

    public bool Remove(int id)
        => _items.Remove(id);

}