using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SysparamGeneral
{
    public string CompanyId { get; set; } = null!;

    public string? CurrentLanguageCode { get; set; }

    public string? CountryCode { get; set; }

    public string? CurrencyCode { get; set; }

    public string? Datemask { get; set; }

    public string? AuditStamp { get; set; }

    public string? IntrastatFlag { get; set; }

    public string? InvoiceControl { get; set; }

    public string? CostAccount { get; set; }

    public string? DetailStockHandling { get; set; }

    public string? SharkStoreLoc { get; set; }

    public DateTime? ScheduleNotificationDatetime { get; set; }

    public string? ScheduleNotificationRecepients { get; set; }

    public string? SmtpServer { get; set; }

    public string? SmtpPort { get; set; }

    public string? SmtpUserId { get; set; }

    public string? SmtpPassword { get; set; }

    public string? SmtpAuth { get; set; }

    public string? SmtpEncrypt { get; set; }

    public string? SmtpSenderMail { get; set; }

    public string? RemoteConnectionUrl { get; set; }

    public string? ShowBackground { get; set; }

    public string? DemandReadReceiptYn { get; set; }

    public string? BccMailToSenderYn { get; set; }

    public string? ScheduleNotificationCase { get; set; }

    public string? ScheduleNotificationMethod { get; set; }

    public string? DoNotShowEmailWindow { get; set; }

    public bool? ShowAllPrinters { get; set; }

    public string? ConfirmBeforeClosing { get; set; }

    public short? ToastMessageWaitTime { get; set; }

    public int? SmtpVersion { get; set; }

    public int? BarcodePrefixConfigId { get; set; }
}
