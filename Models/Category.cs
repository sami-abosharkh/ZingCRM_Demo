﻿using System.ComponentModel.DataAnnotations;

namespace ZingCRM_Demo.Models
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public virtual ICollection<Item> Items { get; set; }  // One to many
    }
}