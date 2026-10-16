namespace GenericStore;

public class Student : IHasId
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

    public string Name
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            
            field = value;
        }
    }
    
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
    
}