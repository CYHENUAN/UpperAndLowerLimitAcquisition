using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class RecipeItemRevisionRecord
{
    public long Id { get; set; }

    public long OldRecipeItemId { get; set; }

    public long NewRecipeItemId { get; set; }

    public int Version { get; set; }

    public DateTime EditDateTime { get; set; }

    public int UserId { get; set; }

    public virtual RecipeItem NewRecipeItem { get; set; } = null!;

    public virtual RecipeItem OldRecipeItem { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
