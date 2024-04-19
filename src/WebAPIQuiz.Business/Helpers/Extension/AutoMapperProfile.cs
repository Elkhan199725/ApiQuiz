using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIQuiz.Business.DTOs.BlogDto;
using WebAPIQuiz.Core.Models;

namespace WebAPIQuiz.Business.Helpers.Extension;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Blog, BlogReadDto>().ReverseMap();

        CreateMap<BlogCreateDto, Blog>().ReverseMap();

        CreateMap<BlogUpdateDto, Blog>().ReverseMap();
    }
}
