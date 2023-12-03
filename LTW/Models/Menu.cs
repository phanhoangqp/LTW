using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTW.Models
{
    [Table("Menu")]
    public class Menu
    {
        [Key]   
        public int MenuID { get; set; }
        public string MenuName { get; set; }    
        public string Alias { get; set; }
        public string Description
        {
            get; set;
        }
        public int Levels { get; set; }
        public int ParentID { get; set; }
        public int Posision { get; set; }
        public bool IsActive  {get; set; } 
        public int MenuOrder { get; set; }
    }
}
