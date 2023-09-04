using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class IntmesgMessage
{
    public int SerialNumber { get; set; }

    public int? ParentSerialNumber { get; set; }

    public string? FromUserId { get; set; }

    public string? ToUserId { get; set; }

    public string? MessageText { get; set; }

    public DateTime? CreateDatetime { get; set; }

    public DateTime? ReadDatetime { get; set; }

    public DateTime? RepliedDatetime { get; set; }

    public DateTime? ForwardedDatetime { get; set; }

    public DateTime? DeletedDatetime { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? ShowMessage { get; set; }

    public bool? AlwaysUnread { get; set; }

    public byte? UserEmployeeFlag { get; set; }

    public bool? SecretFlag { get; set; }
}
