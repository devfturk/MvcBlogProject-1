﻿using BusinessLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject_1.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager();
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult BlogList(int page = 1)
        {
            var blogList = blogManager.GetAll().ToPagedList(page,3);
            return PartialView(blogList);
        }
        public PartialViewResult FeaturedPosts()
        {
            //1.Post
            var postTitle1 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 1).
                Select(y => y.BlogTitle).FirstOrDefault();

            var postImage1 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 1).
                Select(y => y.BlogImage).FirstOrDefault();

            var postDate1 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 1).
                Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle1 = postTitle1;
            ViewBag.postImage1 = postImage1;
            ViewBag.postDate1 = postDate1;
            //2.Post
            var postTitle2 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 2).
                Select(y => y.BlogTitle).FirstOrDefault();

            var postImage2 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 2).
                Select(y => y.BlogImage).FirstOrDefault();

            var postDate2 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 2).
                Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle2 = postTitle2;
            ViewBag.postImage2 = postImage2;
            ViewBag.postDate2 = postDate2;
            //3.Post
            var postTitle3 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 3).
                Select(y => y.BlogTitle).FirstOrDefault();

            var postImage3 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 3).
                Select(y => y.BlogImage).FirstOrDefault();

            var postDate3 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 3).
                Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle3 = postTitle3;
            ViewBag.postImage3 = postImage3;
            ViewBag.postDate3 = postDate3;
            //4.Post
            var postTitle4 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 4).
                Select(y => y.BlogTitle).FirstOrDefault();

            var postImage4 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 4).
                Select(y => y.BlogImage).FirstOrDefault();

            var postDate4 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 4).
                Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle4 = postTitle4;
            ViewBag.postImage4 = postImage4;
            ViewBag.postDate4 = postDate4;
            //ana Post
            var postTitle5 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 5).
                Select(y => y.BlogTitle).FirstOrDefault();

            var postImage5 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 5).
                Select(y => y.BlogImage).FirstOrDefault();

            var postDate5 = blogManager.GetAll().
                OrderByDescending(z => z.BlogID).
                Where(x => x.CategoryID == 5).
                Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle5 = postTitle5;
            ViewBag.postImage5 = postImage5;
            ViewBag.postDate5 = postDate5;



            return PartialView();
        }
        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }
        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }
        public ActionResult BlogDetails()
        {
            return View();
        }
        public PartialViewResult BlogCover()
        {
            return PartialView();
        }
        public PartialViewResult BlogAllContent()
        {
            return PartialView();
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }
    }
}