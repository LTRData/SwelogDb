using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MailLog
{
    public int IdMailOutbox { get; set; }

    public string? RecipientAddress { get; set; }

    public string? RecipientName { get; set; }

    public string? CcAddress { get; set; }

    public string? CcName { get; set; }

    public string? SenderAddress { get; set; }

    public string? SenderName { get; set; }

    public string? MailSubject { get; set; }

    public string? AttachmentFilenames { get; set; }

    public DateTime? SentDate { get; set; }

    public string? SentBy { get; set; }

    public string? DocumentType { get; set; }

    public string? DocumentNumber { get; set; }
}
