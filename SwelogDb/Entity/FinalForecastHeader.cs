using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class FinalForecastHeader
{
    public string ForecastId { get; set; } = null!;

    public DateTime? RegistrationDate { get; set; }

    public string? OwnDescription { get; set; }

    public string? RegisteredBy { get; set; }

    public byte? Status { get; set; }

    public short? CorrectionPercentage { get; set; }

    public short? PriceCalculationType { get; set; }
}
