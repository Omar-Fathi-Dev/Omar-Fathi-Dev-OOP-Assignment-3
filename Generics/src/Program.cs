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

        IReadOnlyList<Student> students = studentStore.GetAll();

        Console.WriteLine("=== Students ===");

        foreach (Student student in students)
            Console.WriteLine(student);

        Console.WriteLine($"Found: {studentStore.GetById(1)}");

        Console.WriteLine($"Removed: {studentStore.Remove(1)}");

        Console.WriteLine("=== Students After Removal ===");

        foreach (Student student in studentStore.GetAll())
            Console.WriteLine(student);


        Course course1 = new Course() { Id = 1, Title = "C# Fundamentals", Price = 1500 };
        Course course2 = new Course() { Id = 2, Title = "ASP.NET Core", Price = 2500 };

        Store<Course> courseStore = new Store<Course>();
        courseStore.Add(course1);
        courseStore.Add(course2);

        IReadOnlyList<Course> courses = courseStore.GetAll();

        Console.WriteLine("\n=== Courses ===");

        foreach (Course course in courses)
            Console.WriteLine(course);

        Console.WriteLine($"Found: {courseStore.GetById(1)}");

        Console.WriteLine($"Removed: {courseStore.Remove(1)}");

        Console.WriteLine("=== Courses After Removal ===");

        foreach (Course course in courseStore.GetAll())
            Console.WriteLine(course);

    }
}