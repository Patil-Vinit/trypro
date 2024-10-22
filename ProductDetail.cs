using System;
using System.Collections.Generic;

namespace Product_Show.Models;

public partial class ProductDetail
{
    public int ProSn { get; set; }

    public string ProName { get; set; } = null!;

    public int? ProPrice { get; set; }
}
