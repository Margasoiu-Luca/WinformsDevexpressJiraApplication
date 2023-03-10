using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFContext.Models;

namespace EFContext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new Jira_DatabaseEntities1();
            Console.WriteLine(x.JUsers.First().username);
        }
    }
}
