using Task_2;

Employee emp1 = new FullTimeEmployee("Ahmad",1,1200);

Employee emp2 = new PartTimeEmployee("Omar", 2, 10, 40);

Employee[] employees = { emp1, emp2 };
foreach (Employee emp in employees)
{
    emp.CalculateSalary();
    emp.DisplayWorkerInfo();
    IWorkable worker = (IWorkable)emp;
    worker.Work();
    Console.WriteLine("----------------");
}