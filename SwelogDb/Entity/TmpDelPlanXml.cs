using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpDelPlanXml
{
    public int RecNo { get; set; }

    public string? UnbAvskod { get; set; }

    public string? UnbAvskval { get; set; }

    public string? UnbMottkod { get; set; }

    public string? UnbMottkval { get; set; }

    public string? UnbRef { get; set; }

    public string? MidLevplnr { get; set; }

    public DateTime? MidDatum { get; set; }

    public string? SdtLevnr { get; set; }

    public string? BdtKundnr { get; set; }

    public string? BdtNamn { get; set; }

    public string? BdtAdr1 { get; set; }

    public string? BdtAdr2 { get; set; }

    public string? BdtAdr3 { get; set; }

    public string? BdtAdr4 { get; set; }

    public DateTime? AriFrom { get; set; }

    public DateTime? AriTom { get; set; }

    public string? CsgMottkod { get; set; }

    public string? CsgMottnamn { get; set; }

    public string? CsgMottadr1 { get; set; }

    public string? CsgMottadr2 { get; set; }

    public string? CsgMottadr3 { get; set; }

    public string? CsgMottadr4 { get; set; }

    public string? CsgPortkod { get; set; }

    public string? CsgPortadr1 { get; set; }

    public string? CsgPortadr2 { get; set; }

    public string? CsgPortadr3 { get; set; }

    public string? CsgForrkod { get; set; }

    public string? CsgForradr1 { get; set; }

    public string? CsgForradr2 { get; set; }

    public string? CsgForradr3 { get; set; }

    public string? ArdKartnr { get; set; }

    public string? ArdLartnr { get; set; }

    public string? ArdLartnr2 { get; set; }

    public decimal? ArdSumlevkv { get; set; }

    public string? ArdSort { get; set; }

    public string? ArdKordnr { get; set; }

    public DateTime? ArdKorddat { get; set; }

    public DateTime? DstAvstdat { get; set; }

    public decimal? DstAckinlev { get; set; }

    public decimal? DstBestrest { get; set; }

    public string? PdnFoljesnr { get; set; }

    public DateTime? PdnDatum { get; set; }

    public decimal? PdnKvant { get; set; }

    public decimal? PdnRkvant { get; set; }

    public DateTime? PdnDatum1 { get; set; }

    public DateTime? DelFlevdag { get; set; }

    public DateTime? DelFlevtid { get; set; }

    public DateTime? DelSlevdag { get; set; }

    public DateTime? DelSlevtid { get; set; }

    public int? DelPeriod { get; set; }

    public short? DelAntdagar { get; set; }

    public decimal? DelKvant { get; set; }

    public short? DelStatus { get; set; }
}
