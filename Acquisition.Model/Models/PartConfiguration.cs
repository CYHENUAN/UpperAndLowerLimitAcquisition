using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PartConfiguration
{
    public int Id { get; set; }

    public string? FinishGoodPartNumber { get; set; }

    public string? RawMaterialPartNumber { get; set; }

    public string? FinishGoodDrawingPartNumber { get; set; }

    public string? RawMaterialDrawingPartNumber { get; set; }

    public string? VariantCode { get; set; }

    public string? FinishGoodPartDescription { get; set; }

    public string? RawMaterialPartDescription { get; set; }
}
