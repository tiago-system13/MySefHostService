using MySefHostService.Servico;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MySefHostService
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CustomerService), new Uri[] { });
            host.Open();
            Console.WriteLine("Serviço rodando...");
            Console.WriteLine("Tecle  para finalizar.");
            Console.ReadKey();
            host.Close();
        }
    }
}