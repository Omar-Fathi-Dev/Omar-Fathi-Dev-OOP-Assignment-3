namespace GenericStore;
using GenericStore.Step3;
using GenericStore.Step6;

class Program
{
    static void Main(string[] args)
    {
        // Student student1 = new Student() { Id = 1, Name = "Omar" };
        // Student student2 = new Student() { Id = 2, Name = "Amr" };
        //
        // Store<Student> studentStore = new Store<Student>();
        // studentStore.Add(student1);
        // studentStore.Add(student2);
        //
        // IReadOnlyDictionary<int, Student> students = studentStore.GetAll();
        //
        // Console.WriteLine("=== Students ===");
        //
        // foreach (KeyValuePair<int, Student> entry in students)
        //     Console.WriteLine(entry.Value);
        //
        // Console.WriteLine($"Found: {studentStore.GetById(1)}");
        //
        // Console.WriteLine($"Removed: {studentStore.Remove(1)}");
        //
        // Console.WriteLine("=== Students After Removal ===");
        //
        // foreach (KeyValuePair<int, Student> entry in studentStore.GetAll())
        //     Console.WriteLine(entry.Value);
        //
        //
        // Course course1 = new Course() { Id = 1, Title = "C# Fundamentals", Price = 1500 };
        // Course course2 = new Course() { Id = 2, Title = "ASP.NET Core", Price = 2500 };
        //
        // Store<Course> courseStore = new Store<Course>();
        // courseStore.Add(course1);
        // courseStore.Add(course2);
        //
        // IReadOnlyDictionary<int, Course> courses = courseStore.GetAll();
        //
        // Console.WriteLine("\n=== Courses ===");
        //
        // foreach (KeyValuePair<int, Course> entry in courses)
        //     Console.WriteLine(entry.Value);
        //
        // Console.WriteLine($"Found: {courseStore.GetById(1)}");
        //
        // Console.WriteLine($"Removed: {courseStore.Remove(1)}");
        //
        // Console.WriteLine("=== Courses After Removal ===");
        //
        // foreach (KeyValuePair<int, Course> entry in courseStore.GetAll())
        //     Console.WriteLine(entry.Value);
        
        
        Student student1 = new Student() { Id = 1, Name = "Omar" };
        Student student2 = new Student() { Id = 2, Name = "Amr" };
        Student student3 = new Student() { Id = 3, Name = "Ali" };
        Student student4 = new Student() { Id = 4, Name = "Ahmed" };
        Student student5 = new Student() { Id = 5, Name = "Mina" };

        List<Student> students = new List<Student>
        {
            student1, student2, student3, student4, student5
        };

        Console.WriteLine("=== Page: Page 2, Size 2 ===");

        foreach (Student student in students.Page(2, 2))
            Console.WriteLine(student);


        Console.WriteLine("\n=== FindById: Id = 3 ===");

        Student? foundStudent = students.FindById(3);
        Console.WriteLine(foundStudent?.ToString() ?? "Student not found");


        Console.WriteLine("\n=== FindById: Id = 10 ===");

        Student? missingStudent = students.FindById(10);
        Console.WriteLine(missingStudent?.ToString() ?? "Student not found");


        Console.WriteLine("\n=== ToIdDictionary ===");

        IReadOnlyDictionary<int, Student> studentDictionary =
            students.ToIdDictionary();

        foreach (KeyValuePair<int, Student> entry in studentDictionary)
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
    }
}