using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Recipe
{
    public long Id { get; set; }

    public string RecipeName { get; set; } = null!;

    public string Version { get; set; } = null!;

    public int Layer { get; set; }

    public int State { get; set; }

    public int? StationId { get; set; }

    public int? MachineId { get; set; }

    public int ProductTypeId { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual ICollection<IPQCForm> IPQCForms { get; set; } = new List<IPQCForm>();

    public virtual ICollection<IQCForm> IQCForms { get; set; } = new List<IQCForm>();

    public virtual Machine? Machine { get; set; }

    public virtual Material ProductType { get; set; } = null!;

    public virtual ICollection<RecipeItem> RecipeItems { get; set; } = new List<RecipeItem>();

    public virtual Station? Station { get; set; }
}
