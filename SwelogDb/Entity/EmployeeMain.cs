using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeMain
{
    public int EmploymentNumber { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? ReferenceId { get; set; }

    public string? EmployeeName { get; set; }

    public int? EmployeeNameTxtid { get; set; }

    public string? EmployeeNameFlag { get; set; }

    public string? EmployeeCardId { get; set; }

    public string? DepartmentNo { get; set; }

    public string? FunctionNo { get; set; }

    public int? EmployeeMailingAddressId { get; set; }

    public int? EmployeeElectronicAddressId { get; set; }

    public string? TerminalReportFlag { get; set; }

    public string? FlexiTimeOption { get; set; }

    public string? FlexiBankDisplayInd { get; set; }

    public DateTime? LastWagePrepareDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? PiReportFlag { get; set; }

    public decimal? FlexiBankTime { get; set; }

    public DateTime? CalendarLastUpdate { get; set; }

    public string? ServiceMenuOnTerminal { get; set; }

    public decimal? EmploymentPercentage { get; set; }

    public string? CapPlanOnTerm { get; set; }

    public string? OperationListId { get; set; }

    public string? ServiceMenuLevel2 { get; set; }

    public decimal? CompTimeBank { get; set; }

    public decimal? WorkTimeReductionBank { get; set; }

    public int? TextId { get; set; }

    public string? MeetingNo { get; set; }

    public string? MeetingNo2 { get; set; }

    public string? MeetingNo3 { get; set; }

    public string? MeetingNo4 { get; set; }

    public string? TerminalUserId { get; set; }

    public string? ResourceNumber { get; set; }

    public string? Preattest1 { get; set; }

    public string? Preattest2 { get; set; }

    public string? FinalAttest { get; set; }

    public string? MailAddress { get; set; }

    public string? RegistratorFlag { get; set; }

    public string? WorkOnFreedayCompSch { get; set; }

    public string? ResourceNumber2 { get; set; }

    public string? ResourceNumber3 { get; set; }

    public decimal? MaxInvAmountBcAttest { get; set; }

    public short? NoOfDaysFromArrDate { get; set; }

    public short? NoOfDaysBeforeDueDate { get; set; }

    public string? TrTerminalViewCode { get; set; }

    public string? TfqAttestUserYn { get; set; }

    public string? TfqAttestAdminYn { get; set; }

    public string? AutoCompCode { get; set; }

    public string? DonotShow { get; set; }

    public decimal? MaxPoAmountBcAttest { get; set; }

    public decimal? StopTimeBank { get; set; }
}
