using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class UserFollowArtCategory {
        [Key]
        public int id { get; set; }
    }
}