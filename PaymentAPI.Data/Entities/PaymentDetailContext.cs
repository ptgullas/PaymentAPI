using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAPI.Data.Entities {
    public class PaymentDetailContext : DbContext {

        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options):base(options) { }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
