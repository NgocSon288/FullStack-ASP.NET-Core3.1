using System;

namespace cShop.ViewModel.Catalog.Categories
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public string ImagePath { get; set; }

        public string Alt { get; set; }
    }
}