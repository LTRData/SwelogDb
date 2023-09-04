using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ElectronicAddress
{
    public int ElectronicAddressNumber { get; set; }

    public string? MainTelephoneNumber { get; set; }

    public string? MainTelephoneExtension { get; set; }

    public string? AlternateTelephoneNumber { get; set; }

    public string? AlternateTelephoneExtension { get; set; }

    public string? MainTelefaxNumber { get; set; }

    public string? AlternateTelefaxNumber { get; set; }

    public string? ModemPhoneNumber { get; set; }

    public string? CompuserveId { get; set; }

    public string? InternetId { get; set; }

    public string? AuditStamp { get; set; }

    public string? PassWord { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();
}
