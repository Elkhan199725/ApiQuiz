using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIQuiz.Core.Models;
using WebAPIQuiz.Core.Repositories;
using WebAPIQuiz.Data.Contexts;

namespace WebAPIQuiz.Data.Repo.Implementation;

public class BlogRepository : GenericRepository<Blog>, IBlogRepository
{
    public BlogRepository(WebAPIQuizDbContext context) : base(context)
    {
    }
}
