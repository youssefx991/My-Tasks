using Day10;

Department department = new() { DeptID = 1, DeptName = "HR" };
Club club = new() { ClubID = 1, ClubName = "Employees Club" };

Console.WriteLine("layoff employee - age");
Employee employee1 = new() { EmployeeID = 1, BirthDate = new DateTime(1900, 1, 1), VacationStock = 50 };
department.AddStaff(employee1);
club.AddMember(employee1);
employee1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));
employee1.EndOfYearOperation();
Console.WriteLine("\n\n\n");

Console.WriteLine("layoff employee - vacation - out of club");
Employee employee2 = new() { EmployeeID = 2, BirthDate = new DateTime(2000, 1, 1), VacationStock = 5 };
department.AddStaff(employee2);
club.AddMember(employee2);
employee2.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));
employee2.EndOfYearOperation();
Console.WriteLine("\n\n\n");



Console.WriteLine("non layoff employee");
Employee employee3 = new() { EmployeeID = 3, BirthDate = new DateTime(2000, 1, 1), VacationStock = 50 };
department.AddStaff(employee3);
club.AddMember(employee3);
employee3.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));
employee3.EndOfYearOperation();
Console.WriteLine("\n\n\n");


Console.WriteLine("layoff employee - vacation - out of club");
Employee employee4 = new() { EmployeeID = 4, BirthDate = new DateTime(2000, 1, 1), VacationStock = 5 };
department.AddStaff(employee4);
club.AddMember(employee4);
employee4.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));
employee4.EndOfYearOperation();
Console.WriteLine("\n\n\n");


Console.WriteLine("layoff Sales Person - target - out of club");
SalesPerson salesPerson1 = new() { EmployeeID = 5, BirthDate = new DateTime(1900, 1, 1), VacationStock = 5, AchievedTarget = 10 };
department.AddStaff(salesPerson1);
club.AddMember(salesPerson1);
salesPerson1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));
salesPerson1.EndOfYearOperation();
salesPerson1.CheckTarget(50);
Console.WriteLine("\n\n\n");


Console.WriteLine("non layoff Sales Person");
SalesPerson salesPerson2 = new() { EmployeeID = 6, BirthDate = new DateTime(2000, 1, 1), VacationStock = 5, AchievedTarget = 50 };
department.AddStaff(salesPerson2);
club.AddMember(salesPerson2);
salesPerson2.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));
salesPerson2.EndOfYearOperation();
salesPerson2.CheckTarget(50);
Console.WriteLine("\n\n\n");

Console.WriteLine("layoff Board Member - resign");
BoardMember boardMember1 = new() { EmployeeID = 7, BirthDate = new DateTime(1900, 1, 1), VacationStock = 5 };
department.AddStaff(boardMember1);
club.AddMember(boardMember1);
boardMember1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));
boardMember1.EndOfYearOperation();
boardMember1.Resign();
Console.WriteLine("\n\n\n");

Console.WriteLine("non layoff Board Member");
BoardMember boardMember2 = new() { EmployeeID = 8, BirthDate = new DateTime(2000, 1, 1), VacationStock = 5 };
department.AddStaff(boardMember2);
club.AddMember(boardMember2);
boardMember2.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));
boardMember2.EndOfYearOperation();
Console.WriteLine("\n\n\n");


