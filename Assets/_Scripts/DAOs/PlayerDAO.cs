using Postgrest.Models;
using Postgrest.Attributes;

[Table("players")]
public class PlayerDAO : BaseModel
{
    [PrimaryKey("uid")]
    public string Uid { get; set; }

    [Column("username")]
    public string Username { get; set; }

    [Column("experience")]
    public int Experience { get; set; }

    [Column("credits")]
    public int Credits { get; set; }
}
