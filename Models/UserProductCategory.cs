using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class UserProductCategory {
        [Key]
        public int id { get; set; }
    }
}