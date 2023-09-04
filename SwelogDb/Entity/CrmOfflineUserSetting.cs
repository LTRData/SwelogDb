using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmOfflineUserSetting
{
    public string UserId { get; set; } = null!;

    public byte? OfflineFileType { get; set; }

    public string? SaveToFilename { get; set; }

    public bool? SaveCompany { get; set; }

    public bool? SaveContact { get; set; }

    public bool? SaveActivity { get; set; }

    public bool? SaveNotes { get; set; }

    public bool? SaveDocument { get; set; }

    public bool? SaveProject { get; set; }

    public bool? SaveEvent { get; set; }

    public bool? SaveTodolist { get; set; }

    public bool? SaveBasicData { get; set; }

    public bool? SaveGroupsAndUsers { get; set; }

    public bool? SaveLabels { get; set; }
}
