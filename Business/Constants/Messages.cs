using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandsListed = "Markalar listelendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string CarAdded = "Araba eklendi.";
        public static string CarAddedFailed = "Araba ekleme işlemi başarısız.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorsListed = "Renkler listelendi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string UserAdded="Kullanıcı eklendi.";
        public static string UserDeleted="Kullanıcı silindi.";
        public static string UsersListed="Kullanıcılar listelendi.";
        public static string UserUpdated="Kullanıcı güncellendi.";
        public static string RentalsListed="Kiralamalar listelendi.";
        public static string RentalDeleted="Kiralama silindi";
        public static string RentalAdded="Yeni kiralama eklendi.";
        public static string RentalUpdated="Kiralama durumu güncellendi.";
        public static string Failed="Hata";
        public static string CarImageDeleted="Araba resmi silindi.";
        public static string CarImageAdded="Araba resmi eklendi.";
        public static string CarImageUpdated="Araba resmi güncellendi.s";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string PasswordError="Şifre Hatalı";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string UserRegistered="Üye kaydı yapıldı.";
        public static string AccessTokenCreated="Token oluşturuldu.";
        internal static string CardAlreadyExists;
        internal static string CardAdded;
        internal static string CardDeleted;
        internal static string CardUpdated;
    }
}
