
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 10000;

bool isAuthenticated = false;
Console.WriteLine(message1);

// condition
if (isAuthenticated)
{
    Console.WriteLine("Hoşgeldin Burak");
}
else
{
    Console.WriteLine("Sisteme Giriş Yap");
}

string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5" };

// Start
for (int i = 0; i < loans.Length; i++)
{
    Console.Write(loans[i]);
}

CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);

}


IndividualCustomer customer = new IndividualCustomer();
customer.Id = 1;
customer.NationalIdentity = "26405710245";
customer.FirstName = "Burak";
customer.LastName = "KARABAŞ";
customer.CustomerNumber = "123456";

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 2;
customer1.NationalIdentity = "26405710287";
customer1.FirstName = "Özgür";
customer1.LastName = "Atılgan";
customer1.CustomerNumber = "123459";

CorporateCustomer corporateCustomer = new CorporateCustomer();
corporateCustomer.Id = 3;
corporateCustomer.Name = "Kodlamaio";
corporateCustomer.CustomerNumber = "654778";
corporateCustomer.TaxIdentity = "12345678987";

CorporateCustomer corporateCustomer1 = new CorporateCustomer();
corporateCustomer1.Id = 4;
corporateCustomer1.Name = "Repkon";
corporateCustomer1.CustomerNumber = "654779";
corporateCustomer1.TaxIdentity = "12345678990";

int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

BaseCustomer[] customers = { customer, customer1, corporateCustomer, corporateCustomer1 };

foreach (BaseCustomer model in customers)
{
    Console.WriteLine(model.CustomerNumber);
}
