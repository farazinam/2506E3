using System;
using System.Collections.Generic;

namespace TemplateEmbedding.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int? ProductPrice { get; set; }

    public string? ProductDescription { get; set; }

    public string? ProductImage { get; set; }

    public int? CatId { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? Cat { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
