using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MySefHostService.Servico
{
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        Customer CreateCustomer(int customerId, string name, string email);

        [OperationContract]
        Customer GetCustomerByName(string customerName);

        [OperationContract]
        Customer[] GetAllCustomers();
    }
}