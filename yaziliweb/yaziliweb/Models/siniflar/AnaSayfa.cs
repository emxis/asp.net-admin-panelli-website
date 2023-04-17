using System.ComponentModel.DataAnnotations;

namespace yaziliweb.Models.siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string bg1{ get; set; }
        public string baslik { get; set; }
        public string buttongiris { get; set; }
        public string baslikBg2 { get; set; }
        public string hakkimizdaAciklama { get; set; }
        public string aciklamaFoto { get; set; }
        public string baslikBg4 { get; set; }
        public string ozellik1 { get; set; }
        public string ozellik2 { get; set; }
        public string ozellik3 { get; set; }
        public string flexYazi1 { get; set; }
        public string flexYazi2 { get; set; }
        public string flexYazi3 { get; set; }
        public string flexImage1 { get; set; }
        public string flexImage2 { get; set; }
        public string flexImage3 { get; set; }
        public string amacimizYazi { get; set; }
        public string footer { get; set; }
    }
}