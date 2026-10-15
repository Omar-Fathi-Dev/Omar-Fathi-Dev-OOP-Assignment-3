using RefactoringLab;
using RefactoringLab.Carriers;

var shipping = new ShippingCostCalculator();
Console.WriteLine($"Aramex 2kg → {shipping.Calculate(new AramexCarrier(), 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate(new FedExCarrier(), 2)}");
Console.WriteLine($"UPS (NEW Carrier) 2kg  → {shipping.Calculate(new UpsCarrier(), 2)}");
Console.WriteLine();

IEmailSender email = new SmtpEmailSender();
IOrderRepository repo = new SqlOrderRepository();

var processor = new OrderProcessor(repo , email);
processor.Process(1001, "customer@example.com");
Console.WriteLine();


new ScheduledNotification(new UrgentNotification(new EmailNotification()) ,
    DateTime.Today.AddHours(18)).Send("customer@example.com",
    "Your order ships tomorrow");

 new UrgentNotification(new SmsNotification()).Send("+201000000000", "OTP 4821");


// New Channel
 new ScheduledNotification(new UrgentNotification(new PushNotification()) ,
     DateTime.Today.AddHours(24)).Send("customer@example.com",
     "Your order ships tomorrow");
 new UrgentNotification(new PushNotification()).Send("+201000000000", "OTP 4821");
