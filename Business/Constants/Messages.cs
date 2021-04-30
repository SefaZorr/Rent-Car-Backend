using System;
using System.Collections.Generic;
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

        internal static string RentalCarInvalid = "Hata!.Araç henüz teslim edilmedi.Kiralanamaz";
        internal static string RentalAdded = "Kiralama eklendi";
        internal static string RentalDeleted = "Kiralama silindi";
        internal static string RentalsListed = "Kiralamalar listelendi";
        internal static string RentalUpdated = "Kiralama güncellendi";

        internal static string UserAdded = "Kullanıcı eklendi";
        internal static string UserDeleted = "Kullanıcı silindi";
        internal static string UsersListed = "Kullanıcılar listelendi";
        internal static string UserUpdated = "Kullanıcı güncellendi";
        internal static string ImageLimit;
        internal static string CarImageAdded;
    }
}
