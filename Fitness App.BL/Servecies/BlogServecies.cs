using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.BL.Interfaces;
using Fitness_App.BL.ViewModels;
using Fitness_App.DAL.Models;
using Fitness_App.DAL.Repositories;

namespace Fitness_App.BL.Servecies
{
    public class BlogServecies
    {
        private readonly IAdminRepository<BlogViewModel> adminRepository;

        public BlogServecies(IAdminRepository<BlogViewModel> adminRepository)
        {
            this.adminRepository = adminRepository;
        }
        public void AddBlog(BlogViewModel blog)
        {
            
            adminRepository.AddBlogs(new Blogs
            {
                BlogTitle = blog.BlogTitle,
                BlogContent = blog.BlogContent
            });
        }
        public void DeleteBlog(int blogId)
        {
            // Here you would typically call a repository method to delete the blog from the database
            // For example:
            // _blogRepository.Delete(blogId);
        }
        public List<string> GetAllBlogs()
        {
            // Here you would typically call a repository method to get all blogs from the database
            // For example:
            // return _blogRepository.GetAll().Select(b => b.Title).ToList();
            return new List<string>(); // Placeholder
        }
    }
}
