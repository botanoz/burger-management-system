using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp
{
    public class appsetings
    {
       
        public bool langtr = true;
        public string basepath = @"C:\Users\botan\OneDrive\Masaüstü\course\BurgerApp\BurgerApp\img\";
        public int _userID;
       

        public appsetings(int uid)
        {
            _userID = uid;
        }
        public appsetings()
        {
            
        }
       


        #region lang settings

        public string sepetmsg => langtr == true ? "Seçili Ürün Yok!" : "Your cart is empty !";
        public string sepettotal => langtr == true ? "Toplam : $" : "Total : $";
        public string appclosemsg => langtr == true ? "Uygulamayı kapatmak istediğinize emin misiniz ?" : "Are you sure you want to close the application ?";
        public string appcloseheader => langtr == true ? "Uygulama Kapatılıyor" : "Application is closing";
        public string appclosebtn => langtr == true ? "Çıkış Yap" : "Logout";
        public string appname => langtr == true ? "Hamburger Sipariş Otomasyonu" : "Hamburger Order Automation";
        public string setingbtn => langtr == true ? "Ayarlar" : "Settings";
        public string ordermsg => langtr == true ? "Siparişiniz Alınmıştır! Sipariş No : " : "Your order has been received! Order No : ";
        public string giveorder => langtr == true ? "Sipariş Ver" : "Order Now";
        public string cleanorder => langtr == true ? "Sepeti Temizle" : "Clear Order";
        public string updateadress => langtr == true ? "Adresi Güncelle" : "Update Address";
        public string adress => langtr == true ? "Adres" : "Address";
        public string myallorders => langtr == true ? "Tüm Siparişlerim" : "My All Orders";
        public string myalladress => langtr == true ? "Adreslerim" : "My All Adress";
        public string save => langtr == true ? "Kaydet" : "Save";
        public string langsetings => langtr == true ? "Dil Tr/En" : "Language Tr/en";
        public string password => langtr == true ? "Şifre" : "Password";
        public string username => langtr == true ? "Kullanıcı Adı" : "Username";
        public string lastname => langtr == true ? "Soyad" : "Lastname";
        public string firstname => langtr == true ? "Ad" : "Firstname";


        #endregion
    }
}
