using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIQuiz.Business.DTOs.BlogDto;

public class BlogUpdateDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public IFormFile? ImageUrl { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public bool? IsActive { get; set; } = true;
}
