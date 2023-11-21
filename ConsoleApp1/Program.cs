using Azure.Identity;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) 
        {
            IDataService<User> userService = new GenericDataServices<User>(new SimpleTraderDbContextFactory());
            var c = userService.GetAll().Result.Count();

            Console.WriteLine(c);
            userService.Create(
                new User { 
                    UserName = "test12", Email = "ádasd", Password = "asdasd" }
                    );
            // userService.Delete(1)

            // foreach (var item in c)
            // {
            //     Console.WriteLine(item.UserName);
            // }
        }
    }
}