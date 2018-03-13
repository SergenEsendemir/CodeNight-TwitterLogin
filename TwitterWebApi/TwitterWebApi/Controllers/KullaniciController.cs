using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TwitterWebApi.Models;

namespace TwitterWebApi.Controllers
{
    public class KullaniciController : ApiController
    {
        DbTwitterEntities db = new DbTwitterEntities();

        [HttpGet]
        public string Giris(string kulAd, string parola)
        {
            tblKullaniciBilgileri kul = db.tblKullaniciBilgileri.Where(k=>k.NickName == kulAd && k.KullaniciSifre == parola).FirstOrDefault();

            if (kul == null)
                return "Hatalı giriş";
            else
                return "Giriş Yapıldı:" + kul.KullaniciAdiSoyadi;

        }

        [HttpGet]
        [HttpPost]
        public IHttpActionResult test()
        {
            return Ok("12345");
        }
    }
}
