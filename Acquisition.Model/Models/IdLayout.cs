using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class IdLayout
{
    public int Id { get; set; }

    public int IdModelId { get; set; }

    public int Sequence { get; set; }

    /// <summary>
    /// 0:Counter,1:MaterialGroupNumber,2:MaterialGroupId,3:DateTimeTemplate,4:FreeText,5:NumericId,6:ObjectId,7:Attribute,8:MaterialNumber,9:MaterialId,10:ShiftName,11:StationParameter,12:WorkOrderNumber,13:ShiftDateTimeTemplate
    /// </summary>
    public int Type { get; set; }

    public string? Value { get; set; }

    public int MinLength { get; set; }

    public int MaxLength { get; set; }

    public string? FillCharacter { get; set; }

    /// <summary>
    /// True:Fill at prefix, False: Fill at suffix
    /// </summary>
    public bool FillPrefixOrSuffix { get; set; }

    /// <summary>
    /// 默认为False，即只允许0-9,a-z,A-Z
    /// </summary>
    public bool AllowSpecialCharacters { get; set; }

    public virtual IdModel IdModel { get; set; } = null!;
}
