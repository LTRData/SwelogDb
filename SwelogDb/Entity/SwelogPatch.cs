using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogPatch
{
    public string PatchNumber { get; set; } = null!;

    public DateTime? RegistrationDate { get; set; }

    public string? Description { get; set; }

    public string? ExecutedOn { get; set; }
}
