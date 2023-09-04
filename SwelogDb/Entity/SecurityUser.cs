using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SecurityUser
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int UserType { get; set; }

    public string? Password { get; set; }

    public string? GroupName { get; set; }

    public int? EmployeeNo { get; set; }

    public string? LanguageCode { get; set; }

    public string? EmailId { get; set; }

    public byte? MenuOption { get; set; }

    public bool? FieldAdmin { get; set; }

    public string? TerminalFlag { get; set; }

    public string? LoginWithoutPassword { get; set; }

    public string? AllowAdvancedCoFunctions { get; set; }

    public string? SalesmanSecurityFlag { get; set; }

    public short? ToolbarDockrow { get; set; }

    public int? ToolbarOffset { get; set; }

    public string? ToolbarAlignment { get; set; }

    public bool? ToolbarVisible { get; set; }

    public int? KpiViewCount { get; set; }

    public string? ResourceTerminalFlag { get; set; }

    public bool? ToolbarShowText { get; set; }

    public int? ColorScheme { get; set; }

    public bool? ShowStartup { get; set; }

    public string? FieldLevelSecurityUbv { get; set; }

    public string? DelToCustSecurity { get; set; }

    public bool? ShowFavorites { get; set; }

    public string? ThemeColor { get; set; }

    public bool? ShowTodo { get; set; }

    public bool? SearchOnLeft { get; set; }

    public int? DbConfigId { get; set; }

    public bool? AdminFunction { get; set; }

    public string? NotApprovedForPublicSuppliers { get; set; }

    public string? UserCategory { get; set; }

    public string? HomepagePassword { get; set; }

    public virtual ICollection<MenuUserRole> MenuUserRoles { get; } = new List<MenuUserRole>();
}
