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
    
    public partial class tblTweetler
    {
        public tblTweetler()
        {
            this.tblBegeniler = new HashSet<tblBegeniler>();
            this.tblTweetKutusu = new HashSet<tblTweetKutusu>();
        }
    
        public int TweetID { get; set; }
        public string Tweetİcerik { get; set; }
        public byte[] TweetFoto { get; set; }
        public int KullaniciBilgileriID { get; set; }
    
        public virtual ICollection<tblBegeniler> tblBegeniler { get; set; }
        public virtual tblKullaniciBilgileri tblKullaniciBilgileri { get; set; }
        public virtual ICollection<tblTweetKutusu> tblTweetKutusu { get; set; }
    }
}
