// See https://aka.ms/new-console-template for more information
using Day3;

Console.WriteLine("Hello, World!");
Employee[] EmpArr = new Employee[3];
SecurityPrivilege priv_dba = SecurityPrivilege.DBA;
SecurityPrivilege priv_guest = SecurityPrivilege.guest;
SecurityPrivilege priv_security = SecurityPrivilege.guest | SecurityPrivilege.developer | SecurityPrivilege.secretary | SecurityPrivilege.DBA;

for (int i=0; i< EmpArr.Length; i++)
{
    Console.Write($"Enter Employee {i+1} id: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write($"Enter Employee {i+1} Security Level: ");
    int security_level = int.Parse(Console.ReadLine());

    Console.Write($"Enter Employee {i+1} Salary: ");
    double salary = double.Parse(Console.ReadLine());

    Console.Write($"Enter Employee {i+1} hire date day: ");
    int day = int.Parse(Console.ReadLine());
    
    Console.Write($"Enter Employee {i+1} hire date month: ");
    int month = int.Parse(Console.ReadLine());
    
    Console.Write($"Enter Employee {i+1} hire date year: ");
    int year = int.Parse(Console.ReadLine());
    
    Console.Write($"Enter Employee {i+1} gender (m/f): ");
    string gender = Console.ReadLine();
    gender = gender.ToLower();
    while (gender != "m" &&  gender != "f")
    {
        Console.Write($"Please enter only m or f for gender: ");
        gender = Console.ReadLine();
    }

    Gender enum_gender = (Gender) Enum.Parse(typeof(Gender), gender, true);

    HiringDate date = new HiringDate(day, month, year);

    EmpArr[i] = new Employee(id, security_level, salary, date, enum_gender, priv_guest);

    Console.WriteLine("-------------------------------------------------------------------------------------");
    Console.Clear();
}

EmpArr[0].setPrivilege(priv_dba);
EmpArr[1].setPrivilege(priv_guest);
EmpArr[2].setPrivilege(priv_security);


for (int i=0; i< EmpArr.Length; i++)
{
    Console.WriteLine($"Employee {i+1} data");
    Console.WriteLine(EmpArr[i].ToString());
    Console.WriteLine("-------------------------------------------------------------------------------------");
    Console.ReadLine();
}





