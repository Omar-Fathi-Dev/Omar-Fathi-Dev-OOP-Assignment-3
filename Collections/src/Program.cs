namespace StringValidationExtensions;

class Program
{
    static void Main(string[] args)
    {
        List<string> egyptianPhoneNumbers = new()
        {
            "01012345678",
            "+201512345678",
            "01312345678",
            "0101234567",
            "0101234567a",
            "",
            null
            
        };
        List<string> egyptianNationalIds = new()
        {
            "29901011234567",
            "19901011234567",
            "2990101123456",
            "",
            null
            
        };

        Console.WriteLine("===== Check Egyptian Phone Numbers =====\n");
        foreach(var phone in egyptianPhoneNumbers)
            Console.WriteLine($"Phone:{phone} --->  {phone.IsValidEgyptianPhone()}");
        
        Console.WriteLine("\n===== Check Egyptian National Ids =====\n");
        foreach(var id in egyptianNationalIds)
            Console.WriteLine($"ID:{id} --->  {id.IsValidEgyptianNationalId()}");
    }
}