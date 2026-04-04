// See https://aka.ms/new-console-template for more information
using Day4_Red;

Console.WriteLine("Hello, World!");
Employee[] EmpArr = new Employee[3];
SecurityPrivilege priv_dba = SecurityPrivilege.DBA;
SecurityPrivilege priv_guest = SecurityPrivilege.guest;
SecurityPrivilege priv_security = SecurityPrivilege.guest | SecurityPrivilege.developer | SecurityPrivilege.secretary | SecurityPrivilege.DBA;

for (int i=0; i< EmpArr.Length; i++)
{
    int id = ReadInt($"Enter Employee {i + 1} id: ");

    string name = ReadString($"Enter Employee {i + 1} Name: ");



    int security_level = ReadInt($"Enter Employee {i + 1} Security Level: ");

    double salary = ReadDouble($"Enter Employee {i + 1} Salary: ");

    int day = ReadDay($"Enter Employee {i + 1} hire date day: ");
    
    int month = ReadMonth($"Enter Employee {i + 1} hire date month: ");
    
    int year = ReadYear($"Enter Employee {i + 1} hire date year: ");
    
    string gender = ReadString($"Enter Employee {i + 1} gender (m/f): ");
    gender = gender.ToLower();

    while (gender != "m" &&  gender != "f")
    {
        gender = ReadString($"Please enter only m or f for gender: ");
    }

    Gender enum_gender = (Gender) Enum.Parse(typeof(Gender), gender, true);

    HiringDate date = new HiringDate(day, month, year);

    EmpArr[i] = new Employee(id, name, security_level, salary, date, enum_gender, priv_guest);

    Console.WriteLine("-------------------------------------------------------------------------------------");
    Console.Clear();
}

// sort employees by hire date
int n = EmpArr.Length;
int comparisons = (n * (n - 1)) / 2;
Console.WriteLine("Sorting employees...");
BubbleSort(EmpArr);
Console.WriteLine($"number of comparisons = {comparisons}");
Console.WriteLine($"Boxing count with generics = {0}");
Console.WriteLine($"UnBoxing count with generics = {0}");
Console.WriteLine($"Boxing count without generics = {comparisons * 2}");
Console.WriteLine($"UnBoxing count without generics = {comparisons * 2}");
Console.Read();
Console.Clear();



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

#region Searching
//// search
//Console.WriteLine("Testing search");
//Console.WriteLine("-------------------------------------------------------------------------------------");

//int[] nationalIDs = { 111, 222, 333 };
//EmployeeSearch search = new EmployeeSearch(nationalIDs, EmpArr);

//// Search by ID
//int search_id = 1;
//while (true)
//{
//    Console.Write("Enter national id to search for (-1 to quit): ");
//    search_id = ReadInt(Console.ReadLine());
//    if (search_id == -1) break;
//    Console.WriteLine($"Searching for national id : {search_id} = {search[search_id].ToString()}");
//    Console.WriteLine("-------------------------------------------------------------------------------------");
//}



//// Search by date
//int search_day = 1;
//int search_month = 1;
//int search_year = 1;

//while (true)
//{
//    Console.Write("Enter hiring date day to search for (-1 to quit): ");
//    search_day = ReadInt(Console.ReadLine());
//    if (search_day == -1) break;

//    Console.Write("Enter hiring date month to search for (-1 to quit): ");
//    search_month = ReadInt(Console.ReadLine());
//    if (search_month == -1) break;

//    Console.Write("Enter hiring date year to search for (-1 to quit): ");
//    search_year = ReadInt(Console.ReadLine());
//    if (search_year == -1) break;

//    HiringDate search_date = new HiringDate(search_day, search_month, search_year);
//    Console.WriteLine($"Searching for hiring date : {search_date} = {search[search_date].ToString()}");
//    Console.WriteLine("-------------------------------------------------------------------------------------");
//}



//// Search by Name
//string search_name = "";
//while (true)
//{
//    Console.Write("Enter name to search for (-1 to quit): ");
//    search_name = Console.ReadLine();
//    if (search_name == "-1") break;

//    Console.Write($"Searching for name : {search_name} = ");
//    foreach(Employee emp in search[search_name])
//    {
//        Console.WriteLine(emp.ToString());
//        Console.WriteLine("-------------------------------------------------------------------------------------");
//        Console.ReadLine();
//    }
//    Console.WriteLine("-------------------------------------------------------------------------------------");
//} 
#endregion


int ReadInt(string message)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            return result;
        }

        Console.WriteLine("Error please enter valid integer");
    }

}

double ReadDouble(string message)
{
    while (true)
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine(), out double result))
        {
            return result;
        }

        Console.WriteLine("Error please enter valid integer");
    }

}

string ReadString(string message)
{
    while (true)
    {
        Console.Write(message);
        string s = Console.ReadLine();
        if (! string.IsNullOrEmpty(s))
            return s;
      
      Console.WriteLine("Error please enter valid string");


    }
}

int ReadDay(string message)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int result) && result >= 1 && result <= 31)
        {
            return result;
        }
        Console.WriteLine("Error please enter valid day between 1 and 31");
    }
}

int ReadMonth(string message)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int result) && result >= 1 && result <= 12)
        {
            return result;
        }
        Console.WriteLine("Error please enter valid month between 1 and 12");
    }
}

int ReadYear(string message)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int result) && result >= 1900 && result <= DateTime.Now.Year)
        {
            return result;
        }
        Console.WriteLine($"Error please enter valid year between 1900 and {DateTime.Now.Year}");
    }
}


// sort - bubble sort - number of comparisons = n*(n-1)/2
void BubbleSort(Employee[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j].CompareTo(arr[j + 1]) > 0)
            {
                // swap arr[j] and arr[j+1]
                Employee temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

