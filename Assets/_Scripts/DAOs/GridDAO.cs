using Postgrest.Models;
using Postgrest.Attributes;

[Table("restaurants")]
public class GridDAO : BaseModel
{
    [PrimaryKey("id")]
    public int Id { get; set; }

    [Column("owner")]
    public string Owner { get; set; }

    [Column("Grid")]
    public string Grid { get; set; }
}
