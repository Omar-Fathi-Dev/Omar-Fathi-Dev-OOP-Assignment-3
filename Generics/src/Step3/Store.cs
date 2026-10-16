namespace GenericStore.Step3;

public class Store<T>
{
    private List<T> _items = new();
    public IReadOnlyList<T> Items => _items.AsReadOnly();
    
    public void Add(T item)
    {
        if(item is  null)
            throw new ArgumentNullException(nameof(item));
        
        _items.Add(item);
    }

    public T? GetById(int Id)
    {
        foreach (var item in _items)
            if (item.Id == Id)
                return item;
        
        return null;
    }
    
    public IReadOnlyList<T> GetAll() => Items;

    public bool Remove(int id)
    {
        T? item = GetById(id);
        return _items.Remove(item);
    }

}