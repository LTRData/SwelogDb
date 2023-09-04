using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MeetingHdrTemp
{
    public int RecId { get; set; }

    public string? ParentMeetingNo { get; set; }

    public string? ParentMeetingName { get; set; }

    public string? ComponentMeetingNo { get; set; }

    public string? ComponentMeetingName { get; set; }
}
