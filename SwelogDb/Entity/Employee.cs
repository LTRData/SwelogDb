using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Employee
{
    public int EmploymentNumber { get; set; }

    public string? EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public int? EmployeeNameTxtid { get; set; }

    public string? EmployeeNameFlag { get; set; }

    public int? MailingAddressNumber { get; set; }

    public int? ElectronicAddressNumber { get; set; }

    public string? AuditStamp { get; set; }

    public string? DepartmentNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? CatPer { get; set; }

    public DateTime? ValidAsFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? CostCenter { get; set; }

    public string? CatTime { get; set; }

    public decimal? IdNo { get; set; }

    public string? FlexiTimeInd { get; set; }

    public decimal? FlexiBalance { get; set; }

    public string? ReasonReportInd { get; set; }

    public decimal? HourlyWage { get; set; }

    public decimal? TimeWage { get; set; }

    public string? PaidByHourInd { get; set; }

    public string? UserCode { get; set; }
}
