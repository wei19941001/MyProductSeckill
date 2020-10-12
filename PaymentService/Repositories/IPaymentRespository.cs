﻿using PaymentMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentMicroService.Repositories
{
  public  interface IPaymentRespository
    {
        void Create(Payment payment);
        void Delete(Payment payment);
        void Update(Payment payment);
        bool PaymentExists(int Id);
        Payment GetPaymentById(int Id);
        IEnumerable<Payment> GetPayments();

    }
}
