using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quarter.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string WebPage { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Address { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string HeaderLogo { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string FooterLogo { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Phone { get; set; }
        [Required]
        [StringLength(maximumLength: 20)]
        public string SupportPhone { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string SupportEmail { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string FacebookUrl { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string TwitterUrl { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string YoutubeUrl { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string LinkedinUrl { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string AboutUsTitle { get; set; }
        [StringLength(maximumLength: 1000)]
        public string AboutUsDescription { get; set; }
    }
}
