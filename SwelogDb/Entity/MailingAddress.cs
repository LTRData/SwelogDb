using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MailingAddress
{
    public int MailingAddressNumber { get; set; }

    public string? HouseNumber { get; set; }

    public string? Street { get; set; }

    public string? ExtraLineForStreet { get; set; }

    public string? PostalName { get; set; }

    public string? PostBoxNo { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? ZipCode { get; set; }

    public string? CountryCode { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual Country? CountryCodeNavigation { get; set; }

    public virtual ICollection<CustomerDeliveryAddress> CustomerDeliveryAddresses { get; } = new List<CustomerDeliveryAddress>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<CustomerReference> CustomerReferences { get; } = new List<CustomerReference>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<FreightCollectAddress> FreightCollectAddresses { get; } = new List<FreightCollectAddress>();

    public virtual ICollection<OurReference> OurReferences { get; } = new List<OurReference>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<SupplierReference> SupplierReferences { get; } = new List<SupplierReference>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();

    public virtual ICollection<TemporaryDeliveryAddress> TemporaryDeliveryAddresses { get; } = new List<TemporaryDeliveryAddress>();
}
