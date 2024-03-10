// See https://aka.ms/new-console-template for more information
using OCPLibraries;


List<IPersonModel> persons = new List<IPersonModel>
{
    new PersonModel {firstName = "Abdullah", lastName = "Ghazi"},
    new ManagerModel {firstName = "Bilal", lastName = "Ghazi"}
};

List<EmployeeModel> employees = new List<EmployeeModel>();

foreach (var item in persons)
{
    employees.Add(item.accountProcessor.Create(item));
}

foreach (var item in employees)
{
    Console.WriteLine($"{item.firstName} {item.lastName}: {item.email} isManager:{item.isManager} isExecutive:{item.isExecutive}");
}
