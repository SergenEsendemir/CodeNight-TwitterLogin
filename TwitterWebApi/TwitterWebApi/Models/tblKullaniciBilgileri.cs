//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwitterWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblKullaniciBilgileri
    {
        public tblKullaniciBilgileri()
        {
            this.tblDM = new HashSet<tblDM>();
            this.tblKullanicilar = new HashSet<tblKullanicilar>();
            this.tblTakipci = new HashSet<tblTakipci>();
            this.tblTakipEdilen = new HashSet<tblTakipEdilen>();
            this.tblTweetler = new HashSet<tblTweetler>();
        }
    
        public int KullaniciBilgileriID { get; set; }
        public string KullaniciAdiSoyadi { get; set; }
        public int KullaniciTelefon { get; set; }
        public string KullaniciEmail { get; set; }
        public string KullaniciSifre { get; set; }
        public string NickName { get; set; }
    
        public virtual ICollection<tblDM> tblDM { get; set; }
        public virtual ICollection<tblKullanicilar> tblKullanicilar { get; set; }
        public virtual ICollection<tblTakipci> tblTakipci { get; set; }
        public virtual ICollection<tblTakipEdilen> tblTakipEdilen { get; set; }
        public virtual ICollection<tblTweetler> tblTweetler { get; set; }
    }
}
