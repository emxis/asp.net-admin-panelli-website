﻿using System.ComponentModel.DataAnnotations;

namespace yaziliweb.Models.siniflar
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

    }
}