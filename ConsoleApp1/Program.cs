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
            var c = userService.GetAll().Result;
            //userService.Create(new User()
            //{
            //    UserName = "Test",
            //    Email = "Giag3",
            //    Password ="123123"
            //}).Wait();
            foreach (var item in c)
            {
                System.Console.WriteLine(item.UserName);
            }
        }
    }
}