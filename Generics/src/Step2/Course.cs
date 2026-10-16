namespace GenericStore;

public class Course : IHasId
{
    public int Id
    {
        get;
        set
        {
            if (value < 1)
                throw new ArgumentOutOfRangeException(nameof(value));
            
            field = value;
        }
    }

    public string Title
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            
            field = value;
        }
    }
    
    public decimal Price
    {
        get;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            
            field = value;
        }
    }
    
    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Price: {Price}";
    }
}