using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;
namespace DAL.Interface
{
    public interface ICustomer
    {

        Task<bool> CreateCustomer(CustomerDto c);
        Task<bool> DeleteCustomer(long id);
        Task<Customer> GetCustomer(long id);
        Task<bool> UpdateCostumer(long id,CustomerDto c);

    }
}
