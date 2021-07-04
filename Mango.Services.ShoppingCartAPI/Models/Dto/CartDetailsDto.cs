
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ShoppingCartAPI.Models
{
    public class CartDetailsDto
    {
        public int CartDetailsId { get; set; }
        public int CartHeaderId { get; set; }

        public virtual CartHeader CartHeader { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public int Count { get; set; }
    }
}