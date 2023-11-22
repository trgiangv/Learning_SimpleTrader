using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;

namespace TestDataBase;

public class Program
{
    static void Main(string[] args)
    {
        IDataService<User> dataService = new GenericDataServices<User>(new SimpleTraderDbContextFactory());
        var allUsers = dataService.GetAll().Result;
        
        // add a new user
        var newUser = new User()
        {
            UserName = "gabriel",
            Email = "asdasd",
            Password = "asdasd12321"
        };
        // dataService.Create(newUser).Wait();
            
    }
}