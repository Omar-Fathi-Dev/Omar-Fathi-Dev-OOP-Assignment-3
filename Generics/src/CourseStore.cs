namespace GenericStore;

public class CourseStore
{
    private List<Course> _courses = new();
    public IReadOnlyList<Course> Courses => _courses.AsReadOnly();
    
    public void Add(Course course)
    {
        if(course is  null)
            throw new ArgumentNullException(nameof(course));
        
        _courses.Add(course);
    }

    public Course? GetById(int Id)
    {
        foreach (var course in _courses)
            if (course.Id == Id)
                return course;
        
        return null;
    }
    
    public IReadOnlyList<Course> GetAll() => Courses;

    public bool Remove(int id)
    {
        Course? course = GetById(id);
        return _courses.Remove(course);
    }

}