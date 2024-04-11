using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace INTEXteam5.Models;

public partial class LineItem
{
    //[ForeignKey("TransactionId")]
    //public int? TransactionId { get; set; }
    //public Order? Order { get; set; }

    //[ForeignKey("ProductId")]
    //public int? ProductId { get; set; }
    //public Product? Product { get; set; }
    public int? TransactionId { get; set; }
    public int? ProductId { get; set; }

    public int? Qty { get; set; }

    public int? Rating { get; set; }
}
