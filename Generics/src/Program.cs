namespace GenericStore;
using GenericStore.Step3;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student() { Id = 1, Name = "Omar" };
        Student student2 = new Student() { Id = 2, Name = "Amr" };

        Store<Student> studentStore = new Store<Student>();
        studentStore.Add(student1);
        studentStore.Add(student2);

        IReadOnlyDictionary<int, Student> students = studentStore.GetAll();

        Console.WriteLine("=== Students ===");

        foreach (KeyValuePair<int, Student> entry in students)
            Console.WriteLine(entry.Value);

        Console.WriteLine($"Found: {studentStore.GetById(1)}");

        Console.WriteLine($"Removed: {studentStore.Remove(1)}");

        Console.WriteLine("=== Students After Removal ===");

        foreach (KeyValuePair<int, Student> entry in studentStore.GetAll())
            Console.WriteLine(entry.Value);


        Course course1 = new Course() { Id = 1, Title = "C# Fundamentals", Price = 1500 };
        Course course2 = new Course() { Id = 2, Title = "ASP.NET Core", Price = 2500 };

        Store<Course> courseStore = new Store<Course>();
        courseStore.Add(course1);
        courseStore.Add(course2);

        IReadOnlyDictionary<int, Course> courses = courseStore.GetAll();

        Console.WriteLine("\n=== Courses ===");

        foreach (KeyValuePair<int, Course> entry in courses)
            Console.WriteLine(entry.Value);

        Console.WriteLine($"Found: {courseStore.GetById(1)}");

        Console.WriteLine($"Removed: {courseStore.Remove(1)}");

        Console.WriteLine("=== Courses After Removal ===");

        foreach (KeyValuePair<int, Course> entry in courseStore.GetAll())
            Console.WriteLine(entry.Value);
    }
}