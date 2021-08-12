using System.ComponentModel.DataAnnotations;

namespace standBY_prototype.Models
{
  public class BaseModel
  {

    [Key]
    public int Id { get; set; }
  }
}