using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class Gender
{
    public int Id { get; set; }

    public string GenderCode { get; set; } = null!;

    public string GenderLabel { get; set; } = null!;
}
