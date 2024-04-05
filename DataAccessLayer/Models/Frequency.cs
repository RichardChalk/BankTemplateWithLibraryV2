using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class Frequency
{
    public int Id { get; set; }

    public string FrequencyCode { get; set; } = null!;

    public string FreqeuncyLabel { get; set; } = null!;
}
