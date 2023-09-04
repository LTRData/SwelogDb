using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogPocketSavedPicklistsDetail
{
    public int SerialNumber { get; set; }

    public int? HeaderSerialNumber { get; set; }

    public string? StoreLocation { get; set; }

    public string? ItemNumberOrEan { get; set; }

    public decimal? PickedQuantity { get; set; }

    public string? ActualItemNumber { get; set; }

    public decimal? PickedActualItemQuantity { get; set; }

    public decimal? BalanceInStoreLocation { get; set; }

    public byte? TypeOfInput { get; set; }

    public decimal? QuantityFactor { get; set; }

    public short? RowNumber { get; set; }

    public virtual SwelogPocketSavedPicklistsHeader? HeaderSerialNumberNavigation { get; set; }
}
