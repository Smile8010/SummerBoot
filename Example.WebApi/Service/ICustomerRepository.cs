﻿using SummerBoot.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Example.WebApi.Model;

namespace Example.WebApi.Service
{
    [Repository]
    public interface ICustomerRepository : IRepository<Customer>
    {
        [Select("select * from customer where customerNo=@customerNo")]
        Task<Customer> GetCustomerByNoAsync(string customerNo);
    }
}