using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApis.Models;
[Table("TodoItems")]
public class TodoItem
{
    [Column("Id"), Key, DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Column("Name")]
    public string? Name { get; set; }

    [Column("IsComplete")]
    public bool IsComplete { get; set; }
}
