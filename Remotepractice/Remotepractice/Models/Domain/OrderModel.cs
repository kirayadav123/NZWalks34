﻿using System.ComponentModel.DataAnnotations;

namespace Remotepractice.Models.Domain
{
    public class OrderModel
    {

        [Key]
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public float AmountPaid { get; set; }

        [Required]
        public string ModeOfPayment { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        public CartModel CartModel { get; set; }
    }
}
