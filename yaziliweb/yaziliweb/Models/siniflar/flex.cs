using System.ComponentModel.DataAnnotations;

namespace yaziliweb.Models.siniflar
{
    public class flex
    {
        [Key]
        public int id { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public string image3 { get; set; }
        public string yazi1 { get; set; }
        public string yazi2 { get; set; }
        public string yazi3 { get; set; }
        public string ozellik1 { get; set; }
        public string ozellik2 { get; set; }
        public string ozellik3 { get; set; }
    }
}