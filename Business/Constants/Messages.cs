using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün adı geçersiz.";
        public static string MaintenanceTime = "Sistem şuan bakımda.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bu kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExist = "Aynı isimde ürün sisteme eklenemez.";
        public static string CategoryLimitExceeded = "Kategori limiti 15'den fazla ürün ekleme işlemi yapılamaz.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Girilen şifre yanlıştır.";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı.";
        public static string UserAlreadyExists = "Daha önce bu kullanıcı ile kayıt olunmuştur.";
        public static string AccessTokenCreated = "Erişim kodu oluşturuldu.";
    }
}