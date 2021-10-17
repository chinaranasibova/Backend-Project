using Quarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quarter.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Status> Statuses { get; set; }
        public List<City> Cities { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> FeaturedProduct { get; set; }
        public List<ProductTag> ProductTags { get; set; }
        public List<Setting> Settings { get; set; }
        public List<Slider> Sliders { get; set; }

    }
}
