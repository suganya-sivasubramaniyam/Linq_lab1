using Lab1;

List<Employee> Employees = new List<Employee>
{
    new Employee{EmployeeId = 1001,FirstName="Malcolm",LastName="Daruwalla",Tittle="Manager",DOB= new DateTime(1984,11,16),DOJ = new DateTime(2011,6,8),City="Mumbai"},
    new Employee{EmployeeId = 1002,FirstName="Asdin",LastName="Dhalla",Tittle="AsstManager",DOB= new DateTime(1984,8,20),DOJ = new DateTime(2012,7,7),City="Mumbai"},
    new Employee{EmployeeId = 1003,FirstName="Madhavi",LastName="Oza",Tittle="Consultant",DOB= new DateTime(1987,11,14),DOJ = new DateTime(2015,4,12),City="Pune"},
    new Employee{EmployeeId = 1004,FirstName="Saba",LastName="Shaikh",Tittle="SE",DOB= new DateTime(1990,6,3),DOJ = new DateTime(2016,2,2),City="Pune"},
    new Employee{EmployeeId = 1005,FirstName="Nazia",LastName="Shaikh",Tittle="SE",DOB= new DateTime(1991,3,8),DOJ = new DateTime(2016,2,2),City="Mumbai"},
    new Employee{EmployeeId = 1006,FirstName="Amit",LastName="Pathak",Tittle="Consultant",DOB= new DateTime(1989,11,7),DOJ = new DateTime(2014,8,8),City="Chennai"},
    new Employee{EmployeeId = 1007,FirstName="Vijay",LastName="Natrajan",Tittle="Consultant",DOB= new DateTime(1989,12,2),DOJ = new DateTime(2015,6,1),City="Mumbai"},
    new Employee{EmployeeId = 1008,FirstName="Rahuk",LastName="Dubey",Tittle="Associate",DOB= new DateTime(1983,11,11),DOJ = new DateTime(2014,11,6),City="Chennai"},
    new Employee{EmployeeId = 1009,FirstName="Suresh",LastName="Mistry",Tittle="Associate",DOB= new DateTime(1992,8,12),DOJ = new DateTime(2014,12,3),City="Chennai"},
    new Employee{EmployeeId = 1010,FirstName="Sumit",LastName="Shah",Tittle="Manager",DOB= new DateTime(1991,4,12),DOJ = new DateTime(2016,1,2),City="Pune"}
};


// a.Display details of all employee

Console.WriteLine(Employees.Count);
foreach (Employee emp in Employees)
{
    Console.WriteLine("EmployeeId : {0}" ,emp.EmployeeId);
    Console.WriteLine("FirstName :  {0}", emp.FirstName);
    Console.WriteLine("Lastname :   {0}", emp.LastName);
    Console.WriteLine("Tittle :     {0}", emp.Tittle);
    Console.WriteLine("DOB :        {0}", emp.DOB); 
    Console.WriteLine("DOJ :        {0}", emp.DOJ);
    Console.WriteLine("City :       {0}", emp.City);
}


//b.Who's location is not Mumbai
var EmployeeNotInMumbaio = Employees.Where(e => e.City != "Mumbai");
Console.WriteLine("Employees, Not in Mumbai");
foreach (var emp in EmployeeNotInMumbaio)
{
    Console.WriteLine("{0} {1}", emp.FirstName, emp.LastName);

}
//c.who's title is AssManager
var EmployeeTitleAssManger = Employees.Where(e => e.Tittle == "AsstManager");
Console.WriteLine("AssManagers : ");
foreach (var emp in EmployeeTitleAssManger)
{
    Console.WriteLine("{0} {1}", emp.FirstName, emp.LastName);

}

//d.lastname start with S
var LastNameStartWithS = Employees.Where(e => e.LastName.StartsWith('S'));
Console.WriteLine("Last Name Start With S : ");
foreach (var emp in LastNameStartWithS)
{
    Console.WriteLine("{0} {1}", emp.FirstName, emp.LastName);

}

//e.Display a list of all the employees who have joined before 1/1/2015

var JoinedDateFilter  = Employees.Where(e => e.DOJ<new DateTime(2015,1,1));
Console.WriteLine("Joined Filter : ");
foreach (var emp in JoinedDateFilter)
{
    Console.WriteLine("{0} {1}", emp.FirstName, emp.LastName);

}

//f.DOB is is after 1/1/1990
var DobAfter1990 = Employees.Where(e => e.DOB > new DateTime(1990, 1, 1));
Console.WriteLine("Dob After 1990 : ");
foreach (var emp in DobAfter1990)
{
    Console.WriteLine("{0} {1}", emp.FirstName, emp.LastName);

}

//g.Designation Consultant or Associate
var TitleFilter = Employees.Where(e => e.Tittle == "Consultant" || e.Tittle== "Associate");
Console.WriteLine("Employee with Title : ");
foreach (var emp in TitleFilter)
{
    Console.WriteLine("{0} {1} {2}", emp.FirstName, emp.LastName, emp.Tittle);

}

//h.Totral no of employee

Console.WriteLine("Total no of Employees :{0}", Employees.Count);

//i.total no of employees belonging to "Chennai"
var ChennaiEmployees = Employees.Where(e => e.City == "Chennai");
Console.WriteLine("No of Chennai Employee {0} : ", ChennaiEmployees.ToList().Count);

//j.highest employee id from the list
var HighestEmpId = Employees.Max(e => e.EmployeeId);
Console.WriteLine("Highest EmpId {0} : ", HighestEmpId);

//k. total employees joined after 1/1/2015
var Joinedafter2015 = Employees.Count(e => e.DOJ > new DateTime(2015, 1, 1));
 Console.WriteLine("Joined after 2015 {0} : ", Joinedafter2015);

//l.total employees whos title not Associate
var notAssociate = Employees.Count(e => e.Tittle != "Associate");
Console.WriteLine("Not Associate {0} : ", notAssociate);

//m.Total Employees based on city
var countByCity = Employees.GroupBy(e => e.City).Select(g=> new {City =g.Key,Count = g.Count() }).ToList();
foreach (var emp in countByCity)
{
    Console.WriteLine("{0} {1}", emp.City, emp.Count);

}

//n.count based on the city and title
var countByCityAndTitle = Employees.GroupBy(e => new { e.City, e.Tittle }).Select(g => new {  g.Key.City,g.Key.Tittle, Count = g.Count() }).ToList();
foreach (var emp in countByCityAndTitle)
{
    Console.WriteLine("{0} {1} {2}", emp.City,emp.Tittle, emp.Count);

}

//o.youngest Employee
var youngestEmployees =Employees.OrderByDescending(e => e.DOB).FirstOrDefault();

Console.WriteLine("Youngest Employee : {0} {1}", youngestEmployees.FirstName, youngestEmployees.LastName);