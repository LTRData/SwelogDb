using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class IntmesgParameter
{
    public int SerialNumber { get; set; }

    public byte? PollMessagesMinutes { get; set; }

    public bool? PromptBeforeOpening { get; set; }
}
