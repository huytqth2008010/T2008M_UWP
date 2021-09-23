﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2008M_UWP.GroupHomework.Models
{
        public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
    }

    public class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }

    public class Categories
    {
        public Category category { get; set; }
        public List<Food> foods { get; set; }
        public List<Category> data { get; set; }
    }

    public class Root
    {
        public string message { get; set; }
        public Categories data { get; set; }
    }
   


}
