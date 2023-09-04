using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MeetingHdr
{
    public string CompanyNo { get; set; } = null!;

    public string MeetingNo { get; set; } = null!;

    public string? MeetingName { get; set; }

    public DateTime? MeetingDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? DeletedRecord { get; set; }

    public string? BelongsToMeetingNo { get; set; }

    public virtual ICollection<MeetingDtlActivity> MeetingDtlActivities { get; } = new List<MeetingDtlActivity>();

    public virtual ICollection<MeetingDtl> MeetingDtls { get; } = new List<MeetingDtl>();
}
