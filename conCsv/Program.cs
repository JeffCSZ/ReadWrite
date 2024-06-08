
using conCsv;
using conCsv.Data;
using conCsv.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;





IHostBuilder CreateHostBuilder(string[] strings)
{
    return Host.CreateDefaultBuilder()
        .ConfigureServices((_, services) =>
        {
            services.AddSingleton<IEmployee, EmployeeRepo>();
            services.AddSingleton<AppDBContext>();
          
        });
}


Console.WriteLine("Program Running");


//read Data
Console.WriteLine("Read All Data....");
var r = new ReadData();
r.ReadALlData();



var db = new EmployeeRepo(new AppDBContext());


Console.WriteLine("Save All Data to In Memory Database...");
//save all data to In memory database 
foreach(var employee in r.employees)
{
    db.AddEmployee(new Employee(employee));
}




//Now Read back all Data From Database
Console.WriteLine("Read back data from database....");
var emps = db.GetEmployees();
foreach(var e in emps)
{
    Console.WriteLine($"{e.Id}- {e.Name}");
}

Console.WriteLine("Program Exiting");

Console.ReadLine();


