﻿using DataAccess.ENums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class KullaniciKayitModel
    {
        [Required(ErrorMessage = "{0} zorunludur!")]
        [MinLength(3, ErrorMessage = "{0} minimum {1} karakter olmalıdır!")]
        [MaxLength(50, ErrorMessage = "{0} maksimum {1} karakter olmalıdır!")]
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "{0} zorunludur!")]
        [StringLength(10, ErrorMessage = "{0} maksimum {1} karakter olmalıdır!")]
        [DisplayName("Şifre")]

        public string Sifre { get; set; }

        [Required(ErrorMessage = "{0} zorunludur!")]
        [StringLength(10, ErrorMessage = "{0} maksimum {1} karakter olmalıdır!")]
        [DisplayName("Şifre Onay")]
        [Compare("Sifre", ErrorMessage = "Şifre ile şifre onay aynı olmalıdır!")]

        public string SifreOnay { get; set; }

        [Required(ErrorMessage = "{0} zorunludur!")]
        [StringLength(200, ErrorMessage = "{0} maksimum {1} karakter olmalıdır!")]
        [DisplayName("E-Posta")]
        public string EPosta { get; set; }

        [Required(ErrorMessage = "{0} zorunludur!")]
        public string Adres { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        [Required(ErrorMessage = "{0} zorunludur!")]
        [DisplayName("Ülke")]
        public int? UlkeId { get; set; }

        [Required(ErrorMessage = "{0} zorunludur!")]
        [DisplayName("Şehir")]
        public int? SehirId { get; set; }
    }
}
