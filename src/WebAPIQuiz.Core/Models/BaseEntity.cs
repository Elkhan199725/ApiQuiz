using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIQuiz.Core.Models;

public class BaseEntity
{
    public int Id { get; set; }
    public bool isActive { get; set; } = true;
    public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
    public DateTime? ModifiedTime { get; set;}

}
