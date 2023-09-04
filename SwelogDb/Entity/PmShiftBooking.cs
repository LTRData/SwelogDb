using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PmShiftBooking
{
    public int IdPmShift { get; set; }

    public string UserId { get; set; } = null!;

    public string? BookingFlag { get; set; }
}
