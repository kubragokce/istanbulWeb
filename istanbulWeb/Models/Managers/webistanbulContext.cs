using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models.Managers
{
    public class webistanbulContext: DbContext
    {
        public webistanbulContext() : base("veritabaniConnection")
        {

        }
     
        public DbSet<DenizİsletmeleriBazindaYolcus> DenizİsletmeleriBazindaYolcu { get; set; }
        public DbSet<dogalgazTuketimverileris> dogalgazTuketimverileri { get; set; }
        public DbSet<GemiAtikTuruveMiktaris> GemiAtikTuruveMiktari { get; set; }
        public DbSet<GeriKazanilanatikMiktars> GeriKazanilanatikMiktar { get; set; }
        public DbSet<GunesUretimMiktarlaris> GunesUretimMiktarlari { get; set; }
        public DbSet<HalkHaneBuyukluguSayisis> HalkHaneBuyukluguSayisi { get; set; }
        public DbSet<ilceBazliOkumaYazmaBilenBilmeyenKisiSayisis> ilceBazliOkumaYazmaBilenBilmeyenKisiSayisi { get; set; }
    
        public DbSet<istasyonlars> istasyonlar { get; set; }
        public DbSet<itfaiyeKonums> itfaiyeKonum { get; set; }
        public DbSet<KarayollariBazindaAracVeHatSayisis> KarayollariBazindaAracVeHatSayisi { get; set; }
       public DbSet<KarayollariBazindaYolculukSayisis> KarayollariBazindaYolculukSayisi { get; set; }
        public DbSet<NufusBilgileris> NufusBilgileri { get; set; }
       public DbSet<OgrenciSayilaris> OgrenciSayilari { get; set; }
        public DbSet<RaylıiSisHatBazliSefers> RaylıiSisHatBazliSefer { get; set; }
        public DbSet<RayliSistemlerİnternetSiteleris> RayliSistemlerİnternetSiteleri { get; set; }
        public DbSet<RayliTamamlanmisSantiyes> RayliTamamlanmisSantiye { get; set; }
        public DbSet<SehirTiyatrolarindaSergilenenOyunlars> SehirTiyatrolarindaSergilenenOyunlar { get; set; }
        public DbSet<SonBirYildaDepremEtkenligis> SonBirYildaDepremEtkenligi { get; set; }
        public DbSet<SporOrganizasyonuveSporcuSayilaris> SporOrganizasyonuveSporcuSayilari { get; set; }
       public DbSet<TiyatroOyunSayilaris> TiyatroOyunSayilari { get; set; }
        public DbSet<ToplamatikGeriKazanimOranis> ToplamatikGeriKazanimOrani { get; set; }
        public DbSet<ToplananKatiAtikMiktarlaris> ToplananKatiAtikMiktarlari { get; set; }
        public DbSet<YangininKaynaginiGoreDagilims> YangininKaynaginiGoreDagilim { get; set; }
        public DbSet<YeniYapilanYesilAlanMiktaris> YeniYapilanYesilAlanMiktari { get; set; }
        public DbSet<YolculukTuruBazindaYolcus> YolculukTuruBazindaYolcu { get; set; }
    }
}