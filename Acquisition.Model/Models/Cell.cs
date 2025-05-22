using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Cell
{
    public int Id { get; set; }

    public string? CellNumber { get; set; }

    public string Description { get; set; } = null!;

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int? FactoryId { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int State { get; set; }

    public virtual ICollection<Cell_Station> Cell_Stations { get; set; } = new List<Cell_Station>();

    public virtual User? Creator { get; set; }

    public virtual ICollection<CurrentActivedWorkOrderInformation> CurrentActivedWorkOrderInformations { get; set; } = new List<CurrentActivedWorkOrderInformation>();

    public virtual ICollection<EDocument_Relationship> EDocument_Relationships { get; set; } = new List<EDocument_Relationship>();

    public virtual User? Editor { get; set; }

    public virtual Factory? Factory { get; set; }

    public virtual ICollection<UPH> UPHs { get; set; } = new List<UPH>();

    public virtual ICollection<WMSWorkOrder> WMSWorkOrders { get; set; } = new List<WMSWorkOrder>();

    public virtual ICollection<WorkOrder_Cell> WorkOrder_Cells { get; set; } = new List<WorkOrder_Cell>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
