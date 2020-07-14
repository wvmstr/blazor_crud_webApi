using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserNameLibrary
{
    public class UserName
    {
        public int NameId { get; set; }
        [Required]
        public string Service { get; set; }
        
        public string User { get; set; }
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        
        public string Url { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
    }
}
