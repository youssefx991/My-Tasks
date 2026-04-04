// See https://aka.ms/new-console-template for more information
using Day3;
using Day4;

Console.WriteLine("Hello, World!");
Employee[] EmpArr = new Employee[3];
SecurityPrivilege priv_dba = SecurityPrivilege.DBA;
SecurityPrivilege priv_guest = SecurityPrivilege.guest;
SecurityPrivilege priv_security = SecurityPrivilege.guest | SecurityPrivilege.developer | SecurityPrivilege.secretary | SecurityPrivilege.DBA;

for (int i=0; i< EmpArr.Length; i++)
{
    Console.Write($"Enter Employee {i+1} id: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write($"Enter Employee {i+1} Name: ");
    string name = Console.ReadLine();



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

    EmpArr[i] = new Employee(id, name, security_level, salary, date, enum_gender, priv_guest);

    Console.WriteLine("-------------------------------------------------------------------------------------");
    Console.Clear();
}

EmpArr[0].privilege = priv_dba;
EmpArr[1].privilege = priv_guest;
EmpArr[2].privilege = priv_security;


for (int i=0; i< EmpArr.Length; i++)
{
    Console.WriteLine($"Employee {i+1} data");
    Console.WriteLine(EmpArr[i].ToString());
    Console.WriteLine("-------------------------------------------------------------------------------------");
    Console.ReadLine();
}


// search
Console.WriteLine("Testing search");
Console.WriteLine("-------------------------------------------------------------------------------------");

int[] nationalIDs = { 111, 222, 333 };
EmployeeSearch search = new EmployeeSearch(nationalIDs, EmpArr);

// Search by ID
int search_id = 1;
while (true)
{
    Console.Write("Enter national id to search for (-1 to quit): ");
    search_id = int.Parse(Console.ReadLine());
    if (search_id == -1) break;
    Console.WriteLine($"Searching for national id : {search_id} = {search[search_id].ToString()}");
    Console.WriteLine("-------------------------------------------------------------------------------------");
}

// Search by Name
int search_day = 1;
int search_month = 1;
int search_year = 1;

while (true)
{
    Console.Write("Enter hiring date day to search for (-1 to quit): ");
    search_day = int.Parse(Console.ReadLine());
    if (search_day == -1) break;

    Console.Write("Enter hiring date month to search for (-1 to quit): ");
    search_month = int.Parse(Console.ReadLine());
    if (search_month == -1) break;

    Console.Write("Enter hiring date year to search for (-1 to quit): ");
    search_year = int.Parse(Console.ReadLine());
    if (search_year == -1) break;
    
    HiringDate search_date = new HiringDate(search_day, search_month, search_year);
    Console.WriteLine($"Searching for hiring date : {search_date} = {search[search_date].ToString()}");
    Console.WriteLine("-------------------------------------------------------------------------------------");
}



// Search by Name
string search_name = "";
while (true)
{
    Console.Write("Enter name to search for (-1 to quit): ");
    search_name = Console.ReadLine();
    if (search_name == "-1") break;

    Console.Write($"Searching for name : {search_name} = ");
    foreach(Employee emp in search[search_name])
    {
        Console.WriteLine(emp.ToString());
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.ReadLine();
    }
    Console.WriteLine("-------------------------------------------------------------------------------------");
}



