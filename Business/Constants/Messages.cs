using Core.Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Hata!. Araç ismi mininum 3 karakter olmalıdır.";
        public static string CarsListed = "Araçlar listelendi";
        public static string CarPriceInvalid = "Hata!. Araç günlük fiyatı 0' dan büyük olmalıdır.";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandsListed = "Markalar listelendi";

        public static string ColorAdded = "Seçtiğiniz renk eklendi";
        public static string ColorsListed = "Renkler listelendi";

        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerUpdated = "Müşteri güncellendi";

        public static string RentalCarInvalid = "Hata!.Araç henüz teslim edilmedi.Kiralanamaz";
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalsListed = "Kiralamalar listelendi";
        public static string RentalUpdated = "Kiralama güncellendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string ImageLimit;
        public static string CarImageAdded;

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz reddedildi";
    }
}
