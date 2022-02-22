
using OCPLibrary;

List<IApplicantModel> applicants = new List<IApplicantModel>()
{
    new PersonModel() { FirstName = "Claes", LastName = "Engelin"},
    new ManagerModel() { FirstName = "Anna", LastName = "Engelin"},
    new ExecutiveModel() { FirstName = "Nancy", LastName = "Roman"},
    new TechnicianModel() { FirstName = "John", LastName = "Eriksson"}
};

List<EmployeeModel> employees = new List<EmployeeModel>();


foreach (var person in applicants)
{
    employees.Add(person.AccountProcessor.Create(person));
}

foreach (var emp in employees)
{
    Console.WriteLine($"{ emp.FirstName } { emp.LastName }: {emp.EmailAddress} IsManager: { emp.IsManager }, IsExecutive: {emp.IsExecutive}, IsTechnician: {emp.IsTechnician}");
}

Console.ReadKey();