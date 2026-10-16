namespace GenericStore;
using GenericStore.Step3;
using GenericStore.Step6;

class Program
{
    static void Main(string[] args)
    {
        Store<Student> studentStore = new Store<Student>();
        studentStore.Add(new Student { Id = 1, Name = "Omar" });
        studentStore.Add(new Student { Id = 2, Name = "Amr" });
        studentStore.Add(new Student { Id = 3, Name = "Ali" });
        studentStore.Add(new Student { Id = 4, Name = "Ahmed" });
        studentStore.Add(new Student { Id = 5, Name = "Mina" });

        Store<Course> courseStore = new Store<Course>();
        courseStore.Add(new Course { Id = 101, Title = "C#", Price = 1500 });
        courseStore.Add(new Course { Id = 102, Title = "ASP.NET Core", Price = 2500 });
        courseStore.Add(new Course { Id = 103, Title = "SQL Server", Price = 1000 });

        Student? student = studentStore.GetById(3);
        Course? course = courseStore.GetById(102);

        Console.WriteLine("=== Student ===");
        Console.WriteLine(student?.ToString() ?? "Student not found");

        Console.WriteLine("\n=== Course ===");
        Console.WriteLine(course?.ToString() ?? "Course not found");
        
        
        try
        {
            studentStore.Add(new Student { Id = 3, Name = "Duplicate Student" });
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine($"Exception: {exception.Message}");
        }
        
        
        Console.WriteLine("=== Students: Page 2 (Size 2) ===");

        foreach (Student std in studentStore.GetAll().Values.Page(2, 2))
        {
            Console.WriteLine(std);
        }

        List<Course> courses = new List<Course>
        {
            new Course { Id = 101, Title = "C#", Price = 1500 },
            new Course { Id = 102, Title = "ASP.NET Core", Price = 2500 },
            new Course { Id = 103, Title = "SQL Server", Price = 1000 }
        };

        Console.WriteLine("\n=== FindById on List<Course>: Id = 102 ===");

        Course? foundCourse = courses.FindById(102);
        Console.WriteLine(foundCourse?.ToString() ?? "Course not found");

        // new Store<string>(); // must NOT compile
    }
}