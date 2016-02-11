using System;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Action action = () => {
                Console.WriteLine($"I am {WindowsIdentity.GetCurrent().Name}!");
            };
            
            var id = WindowsIdentity.GetCurrent() as WindowsIdentity;
            
            WindowsIdentity.RunImpersonated(id.AccessToken, action);
        }
    }
}
