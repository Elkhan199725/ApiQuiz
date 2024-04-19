﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIQuiz.Business.DTOs.BlogDto;

public class BlogReadDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public DateTime? CreatedDate { get; set; }
    public bool? IsActive { get; set; }
}
