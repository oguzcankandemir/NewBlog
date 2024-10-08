﻿using Blog.Entity;
using Blog.Entity.DTOs.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesAsync();
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
    }
}
