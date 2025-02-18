using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    public class Order : Base, IOrder
    {
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public PaymentMethodEnum PaymentMethod { get; set; }

        [Required]
        public double TotalItemPrice { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}