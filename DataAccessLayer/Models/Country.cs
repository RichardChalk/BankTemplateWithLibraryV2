using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class Country
{
    public int Id { get; set; }

    public string CountryCode { get; set; } = null!;

    public string CountryLabel { get; set; } = null!;
}
