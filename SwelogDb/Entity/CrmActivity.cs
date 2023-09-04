using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmActivity
{
    public int SerialNumber { get; set; }

    public string? ActivityOwnerUserid { get; set; }

    public int? CrmMasterSerialNumber { get; set; }

    public int? CrmContactSerialNumber { get; set; }

    public short? ActivityTypeCode { get; set; }

    public DateTime? StartDatetime { get; set; }

    public DateTime? EndDatetime { get; set; }

    public short? PriorityCode { get; set; }

    public bool? Completed { get; set; }

    public bool? Publish { get; set; }

    public string? ActivityDescription { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModifiedOn { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? Location { get; set; }

    public int? ParentActivitySerial { get; set; }

    public int? ProjectSerialNumber { get; set; }

    public int? EventSerialNumber { get; set; }
}
