﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Models
{
    public class Product
    {
        public int Id { get; set; }
        //[Required]
        //[StringLength(255)]
        //public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [StringLength(255)]
        public string MainImage { get; set; }
        [Required]
        [StringLength(255)]
        public string HoverImage { get; set; }
        [Required]
        //[Column("ProductPrice",TypeName ="money")]
        [Column(TypeName = "decimal(18,2)")]
        public double Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Nullable<double> DiscountPrice { get; set; }
        public bool IsFeature { get; set; }
        public bool IsArrival { get; set; }
        public bool IsMostView { get; set; }
        //[Required]
        public Nullable<int> AuthorId { get; set; }
        //[Required]
        public Nullable<int> GenreId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
