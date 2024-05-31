using System;
namespace HarmonyHaven.Models
{
	public class Cart
	{   
            public int Id { get; set; }
            public decimal CartTotal { get; set; }
            public List<CartItem> CartItems { get; set; }
       
    }

}


