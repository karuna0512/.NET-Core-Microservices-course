
using System.Collections.Generic;

namespace Mango.Services.ShoppingCartAPI.Models.Dto
{
    public class CartDto
    {
        public CartHeader CartHeader { get; set; }
        public IEnumerable<CartDetailsDto> CartDetails { get; set; }
    }
}