using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIQuiz.Core.Models;

public class Blog : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

}

