using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class CustomerManager : GenericManager<Customer, DtoCustomer>, ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        //ICustomerRepository
        public IQueryable<DtoCustomer> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
