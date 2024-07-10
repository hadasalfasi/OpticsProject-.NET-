using AutoMapper;
using DAL.Dtos;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class CustumerData:ICustomer
    {
        private readonly CustomerContext _Context;
        private readonly IMapper _mapper;
        public CustumerData(CustomerContext context,IMapper mapper)
        {
            _Context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateCustomer(CustomerDto c)
        {
            await _Context.Custumers.AddAsync(_mapper.Map<Customer>(c));
            await _Context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteCustomer(long id)
        {
          Customer c=await _Context.Custumers.FindAsync(id);
            if(c==null) return false;
             _Context.Custumers.Remove(c);
            await _Context.SaveChangesAsync();
            return true;
        }

        public async Task<Customer> GetCustomer(long id)
        {

            Customer c = await _Context.Custumers.FindAsync(id);
            if (c == null) return null;
            return c;

        }

        public async Task<bool> UpdateCostumer(long id, CustomerDto updatedCustomer)
        {


            Customer existingCustomer = await _Context.Custumers.FindAsync(id);
            if (existingCustomer == null) return false;
            //if(updatedCustomer.FirstName!= null) 
            existingCustomer.FirstName = updatedCustomer.FirstName;
            existingCustomer.LastName = updatedCustomer.LastName;
            existingCustomer.Phone = updatedCustomer.Phone;
            existingCustomer.PurchaseDate = updatedCustomer.PurchaseDate;
            existingCustomer.GModel = updatedCustomer.GModel;
            existingCustomer.GPD = updatedCustomer.GPD;
            existingCustomer.GRnumber = updatedCustomer.GRnumber;
            existingCustomer.GRCyilinder = updatedCustomer.GRCyilinder;
            existingCustomer.GRAxis = updatedCustomer.GRAxis;
            existingCustomer.GRAddition = updatedCustomer.GRAddition;
            existingCustomer.GRPrizma = updatedCustomer.GRPrizma;
            existingCustomer.GRIndex = updatedCustomer.GRIndex;
            existingCustomer.GLnumber = updatedCustomer.GLnumber;
            existingCustomer.GLCyilinder = updatedCustomer.GLCyilinder;
            existingCustomer.GLRAxis = updatedCustomer.GLRAxis;
            existingCustomer.GLAddition = updatedCustomer.GLAddition;
            existingCustomer.GLPrizma = updatedCustomer.GLPrizma;
            existingCustomer.GLIndex = updatedCustomer.GLIndex;
            existingCustomer.Rnumber = updatedCustomer.Rnumber;
            existingCustomer.RCyilinder = updatedCustomer.RCyilinder;
            existingCustomer.RAxis = updatedCustomer.RAxis;
            existingCustomer.RBC = updatedCustomer.RBC;
            existingCustomer.lnumber = updatedCustomer.lnumber;
            existingCustomer.LCyilinder = updatedCustomer.LCyilinder;
            existingCustomer.LAxis = updatedCustomer.LAxis;
            existingCustomer.LBC = updatedCustomer.LBC;
            existingCustomer.PreGPD = updatedCustomer.PreGPD;
            existingCustomer.PreGRnumber = updatedCustomer.PreGRnumber;
            existingCustomer.PreGRCyilinder = updatedCustomer.PreGRCyilinder;
            existingCustomer.PreGRAxis = updatedCustomer.PreGRAxis;
            existingCustomer.PreGRAddition = updatedCustomer.PreGRAddition;
            existingCustomer.PreGRPrizma = updatedCustomer.PreGRPrizma;
            existingCustomer.PreGRIndex = updatedCustomer.PreGRIndex;
            existingCustomer.PreGLnumber = updatedCustomer.PreGLnumber;
            existingCustomer.PreGLCyilinder = updatedCustomer.PreGLCyilinder;
            existingCustomer.PreGLRAxis = updatedCustomer.PreGLRAxis;
            existingCustomer.PreGLAddition = updatedCustomer.PreGLAddition;
            existingCustomer.PreGLPrizma = updatedCustomer.PreGLPrizma;
            existingCustomer.PreGLIndex = updatedCustomer.PreGLIndex;

            await _Context.SaveChangesAsync();
            return true;


        }
    }
}
