namespace GenericStore;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student()
        {
            Id = 1,
            Name ="Omar"
        };
        Student student2 = new Student()
        {
            Id = 2,
            Name ="Amr"
        };
        StudentStore studentStore = new StudentStore();
        studentStore.Add(student1);
        studentStore.Add(student2);
        
        IReadOnlyList<Student> students = studentStore.GetAll();

        foreach (var l in students)
            Console.WriteLine(l);

        Console.WriteLine(studentStore.GetById(1));

        Console.WriteLine(studentStore.Remove(1));
        
        foreach (var l in students)
            Console.WriteLine(l);


    }
}