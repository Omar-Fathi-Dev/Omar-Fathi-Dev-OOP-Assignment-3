namespace GenericStore;

public class StudentStore
{
    private List<Student> _students = new();
    public IReadOnlyList<Student> Students => _students.AsReadOnly();
    
    public void Add(Student student)
    {
        if(student is  null)
            throw new ArgumentNullException(nameof(student));
        
        _students.Add(student);
    }

    public Student? GetById(int Id)
    {
        foreach (var std in _students)
            if (std.Id == Id)
                return std;
        
        return null;
    }
    
    public IReadOnlyList<Student> GetAll() => Students;

    public bool Remove(int id)
    {
        Student? student = GetById(id);
        return _students.Remove(student);
    }
    
}