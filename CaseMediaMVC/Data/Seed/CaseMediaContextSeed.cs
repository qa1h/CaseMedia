using CaseMediaMVC.Entities.BusinessEntities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseMediaMVC.Data.Seed
{
    public static class CaseMediaContextSeed
    {
        public static void SeedData(IMongoCollection<NewsEntity> newsCollection)
        {
            var isNewsExist = newsCollection.Find(i => true).Any();
            if (!isNewsExist)
            {
                newsCollection.InsertManyAsync(GetInitialNews());
            }
        }

        public static List<NewsEntity> GetInitialNews() 
        {
            List<NewsEntity> newsList = new List<NewsEntity>();

            NewsEntity news1 = new NewsEntity();
            news1.Id = Guid.NewGuid();
            news1.Title = "Beşiktaş - Sivasspor maçı ne zaman, saat kaçta, hangi kanalda?";
            news1.Spot = "Beşiktaş, Süper Lig'in 8. haftasında bugün Demir Grup Sivasspor'u ağırlayacak.";
            news1.PublishedTime = DateTime.Now;
            news1.CreatedTime = DateTime.Now;
            news1.NewsKeywords = new string[] { "beşiktaş", "sivasspor" };
            news1.MainCategory = new CategoryEntity() { Title = "spor", Slug = "spor" };
            news1.SourcesData = new List<SourceEntity>() { new SourceEntity() { Title = "AA" } };
            news1.PublishedAccount = new AccountEntity() { Email = "editor@ntv.com.tr" };
            news1.CreatedAccount = new AccountEntity() { Email = "editor@ntv.com.tr" };
            news1.Story = new StoryEntity()
            {
                Contents = new ContentEntity[]
                    {
                        new ContentEntity() { _t = "MongoDbTextContent", Text = "Beşiktaş, Süper Lig'in 8. haftasında bugün Demir Grup Sivasspor'u ağırlayacak." },
                        new ContentEntity() { _t = "MongoDbImageContent", ImageUrl = "https://cdn.ntvspor.net/f521d5103b984a228727d83726a832a9.jpg?&mode=crop&w=940&h=626.6666666666666" },
                        new ContentEntity() { _t = "MongoDbTextContent", Text = "Beşiktaş Süper Lig'deki 2 maçlık galibiyet hasretine son vermenin peşinde. 8. haftaya lider Fenerbahçe'nin 2 puan gerisinde giren Siyah Beyazlılar, 5 maçtır yenilmeyen Demir Grup Sivasspor'u konuk edecek.Beşiktaş'ın 11'i: Ersin, Rosier, Vida, Serdar, Rıdvan, Josef, Can, Oğuzhan, Kenan, Güven, Batshuayi Sivasspor'un 11'i: Muammer, Ahmet, Dimitrios, Caner, Uğur, Hakan, Felix, Azubuke, Pedro, Gradel, Kayode Vodafone Park'ta saat 19.00'da başlayacak mücadeleyi hakem Yaşar Kemal Uğurlu yönetecek. Karşılaşma beIN SPORTS 1'den naklen yayınlanacak."}
                    }
            };
            news1.MainArtUrl = "https://cdn.ntvspor.net/f521d5103b984a228727d83726a832a9.jpg?&mode=crop&w=940&h=626.6666666666666";
            newsList.Add(news1);


            NewsEntity news2 = new NewsEntity();
            news2.Id = Guid.NewGuid();
            news2.Title = "Beşiktaş - Sivasspor maçı ne zaman, saat kaçta, hangi kanalda?";
            news2.Spot = "Beşiktaş, Süper Lig'in 8. haftasında bugün Demir Grup Sivasspor'u ağırlayacak.";
            news2.PublishedTime = DateTime.Now;
            news2.CreatedTime = DateTime.Now;
            news2.NewsKeywords = new string[] { "beşiktaş", "sivasspor" };
            news2.MainCategory = new CategoryEntity() { Title = "spor", Slug = "spor" };
            news2.SourcesData = new List<SourceEntity>() { new SourceEntity() { Title = "AA" } };
            news2.PublishedAccount = new AccountEntity() { Email = "editor@ntv.com.tr" };
            news2.CreatedAccount = new AccountEntity() { Email = "editor@ntv.com.tr" };
            news2.Story = new StoryEntity()
            {
                Contents = new ContentEntity[]
                    {
                        new ContentEntity() { _t = "MongoDbTextContent", Text = "Beşiktaş, Süper Lig'in 8. haftasında bugün Demir Grup Sivasspor'u ağırlayacak." },
                        new ContentEntity() { _t = "MongoDbImageContent", ImageUrl = "https://cdn.ntvspor.net/f521d5103b984a228727d83726a832a9.jpg?&mode=crop&w=940&h=626.6666666666666" },
                        new ContentEntity() { _t = "MongoDbTextContent", Text = "Beşiktaş Süper Lig'deki 2 maçlık galibiyet hasretine son vermenin peşinde. 8. haftaya lider Fenerbahçe'nin 2 puan gerisinde giren Siyah Beyazlılar, 5 maçtır yenilmeyen Demir Grup Sivasspor'u konuk edecek.Beşiktaş'ın 11'i: Ersin, Rosier, Vida, Serdar, Rıdvan, Josef, Can, Oğuzhan, Kenan, Güven, Batshuayi Sivasspor'un 11'i: Muammer, Ahmet, Dimitrios, Caner, Uğur, Hakan, Felix, Azubuke, Pedro, Gradel, Kayode Vodafone Park'ta saat 19.00'da başlayacak mücadeleyi hakem Yaşar Kemal Uğurlu yönetecek. Karşılaşma beIN SPORTS 1'den naklen yayınlanacak."}
                    }
            };
            news2.MainArtUrl = "https://cdn.ntvspor.net/f521d5103b984a228727d83726a832a9.jpg?&mode=crop&w=940&h=626.6666666666666";
            newsList.Add(news2);

            NewsEntity news3 = new NewsEntity();
            news3.Id = Guid.NewGuid();
            news3.Title = "Beşiktaş - Sivasspor maçı ne zaman, saat kaçta, hangi kanalda?";
            news3.Spot = "Beşiktaş, Süper Lig'in 8. haftasında bugün Demir Grup Sivasspor'u ağırlayacak.";
            news3.PublishedTime = DateTime.Now;
            news3.CreatedTime = DateTime.Now;
            news3.NewsKeywords = new string[] { "beşiktaş", "sivasspor" };
            news3.MainCategory = new CategoryEntity() { Title = "spor", Slug = "spor" };
            news3.SourcesData = new List<SourceEntity>() { new SourceEntity() { Title = "AA" } };
            news3.PublishedAccount = new AccountEntity() { Email = "editor@ntv.com.tr" };
            news3.CreatedAccount = new AccountEntity() { Email = "editor@ntv.com.tr" };
            news3.Story = new StoryEntity()
            {
                Contents = new ContentEntity[]
                    {
                        new ContentEntity() { _t = "MongoDbTextContent", Text = "Beşiktaş, Süper Lig'in 8. haftasında bugün Demir Grup Sivasspor'u ağırlayacak." },
                        new ContentEntity() { _t = "MongoDbImageContent", ImageUrl = "https://cdn.ntvspor.net/f521d5103b984a228727d83726a832a9.jpg?&mode=crop&w=940&h=626.6666666666666" },
                        new ContentEntity() { _t = "MongoDbTextContent", Text = "Beşiktaş Süper Lig'deki 2 maçlık galibiyet hasretine son vermenin peşinde. 8. haftaya lider Fenerbahçe'nin 2 puan gerisinde giren Siyah Beyazlılar, 5 maçtır yenilmeyen Demir Grup Sivasspor'u konuk edecek.Beşiktaş'ın 11'i: Ersin, Rosier, Vida, Serdar, Rıdvan, Josef, Can, Oğuzhan, Kenan, Güven, Batshuayi Sivasspor'un 11'i: Muammer, Ahmet, Dimitrios, Caner, Uğur, Hakan, Felix, Azubuke, Pedro, Gradel, Kayode Vodafone Park'ta saat 19.00'da başlayacak mücadeleyi hakem Yaşar Kemal Uğurlu yönetecek. Karşılaşma beIN SPORTS 1'den naklen yayınlanacak."}
                    }
            };
            news3.MainArtUrl = "https://cdn.ntvspor.net/f521d5103b984a228727d83726a832a9.jpg?&mode=crop&w=940&h=626.6666666666666";
            newsList.Add(news3);

            NewsEntity news4 = new NewsEntity();
            news4.Id = Guid.NewGuid();
            news4.Title = "Beşiktaş - Sivasspor maçı ne zaman, saat kaçta, hangi kanalda?";
            news4.Spot = "Beşiktaş, Süper Lig'in 8. haftasında bugün Demir Grup Sivasspor'u ağırlayacak.";
            news4.PublishedTime = DateTime.Now;
            news4.CreatedTime = DateTime.Now;
            news4.NewsKeywords = new string[] { "beşiktaş", "sivasspor" };
            news4.MainCategory = new CategoryEntity() { Title = "spor", Slug = "spor" };
            news4.SourcesData = new List<SourceEntity>() { new SourceEntity() { Title = "AA" } };
            news4.PublishedAccount = new AccountEntity() { Email = "editor@ntv.com.tr" };
            news4.CreatedAccount = new AccountEntity() { Email = "editor@ntv.com.tr" };
            news4.Story = new StoryEntity()
            {
                Contents = new ContentEntity[]
                    {
                        new ContentEntity() { _t = "MongoDbTextContent", Text = "Beşiktaş, Süper Lig'in 8. haftasında bugün Demir Grup Sivasspor'u ağırlayacak." },
                        new ContentEntity() { _t = "MongoDbImageContent", ImageUrl = "https://cdn.ntvspor.net/f521d5103b984a228727d83726a832a9.jpg?&mode=crop&w=940&h=626.6666666666666" },
                        new ContentEntity() { _t = "MongoDbTextContent", Text = "Beşiktaş Süper Lig'deki 2 maçlık galibiyet hasretine son vermenin peşinde. 8. haftaya lider Fenerbahçe'nin 2 puan gerisinde giren Siyah Beyazlılar, 5 maçtır yenilmeyen Demir Grup Sivasspor'u konuk edecek.Beşiktaş'ın 11'i: Ersin, Rosier, Vida, Serdar, Rıdvan, Josef, Can, Oğuzhan, Kenan, Güven, Batshuayi Sivasspor'un 11'i: Muammer, Ahmet, Dimitrios, Caner, Uğur, Hakan, Felix, Azubuke, Pedro, Gradel, Kayode Vodafone Park'ta saat 19.00'da başlayacak mücadeleyi hakem Yaşar Kemal Uğurlu yönetecek. Karşılaşma beIN SPORTS 1'den naklen yayınlanacak."}
                    }
            };
            news4.MainArtUrl = "https://cdn.ntvspor.net/f521d5103b984a228727d83726a832a9.jpg?&mode=crop&w=940&h=626.6666666666666";
            newsList.Add(news4);


            NewsEntity news5 = new NewsEntity();
            news5.Id = Guid.NewGuid();
            news5.Title = "Beşiktaş - Sivasspor maçı ne zaman, saat kaçta, hangi kanalda?";
            news5.Spot = "Beşiktaş, Süper Lig'in 8. haftasında bugün Demir Grup Sivasspor'u ağırlayacak.";
            news5.PublishedTime = DateTime.Now;
            news5.CreatedTime = DateTime.Now;
            news5.NewsKeywords = new string[] { "beşiktaş", "sivasspor" };
            news5.MainCategory = new CategoryEntity() { Title = "spor", Slug = "spor" };
            news5.SourcesData = new List<SourceEntity>() { new SourceEntity() { Title = "AA" } };
            news5.PublishedAccount = new AccountEntity() { Email = "editor@ntv.com.tr" };
            news5.CreatedAccount = new AccountEntity() { Email = "editor@ntv.com.tr" };
            news5.Story = new StoryEntity()
            {
                Contents = new ContentEntity[]
                    {
                        new ContentEntity() { _t = "MongoDbTextContent", Text = "Beşiktaş, Süper Lig'in 8. haftasında bugün Demir Grup Sivasspor'u ağırlayacak." },
                        new ContentEntity() { _t = "MongoDbImageContent", ImageUrl = "https://cdn.ntvspor.net/f521d5103b984a228727d83726a832a9.jpg?&mode=crop&w=940&h=626.6666666666666" },
                        new ContentEntity() { _t = "MongoDbTextContent", Text = "Beşiktaş Süper Lig'deki 2 maçlık galibiyet hasretine son vermenin peşinde. 8. haftaya lider Fenerbahçe'nin 2 puan gerisinde giren Siyah Beyazlılar, 5 maçtır yenilmeyen Demir Grup Sivasspor'u konuk edecek.Beşiktaş'ın 11'i: Ersin, Rosier, Vida, Serdar, Rıdvan, Josef, Can, Oğuzhan, Kenan, Güven, Batshuayi Sivasspor'un 11'i: Muammer, Ahmet, Dimitrios, Caner, Uğur, Hakan, Felix, Azubuke, Pedro, Gradel, Kayode Vodafone Park'ta saat 19.00'da başlayacak mücadeleyi hakem Yaşar Kemal Uğurlu yönetecek. Karşılaşma beIN SPORTS 1'den naklen yayınlanacak."}
                    }
            };
            news5.MainArtUrl = "https://cdn.ntvspor.net/f521d5103b984a228727d83726a832a9.jpg?&mode=crop&w=940&h=626.6666666666666";
            newsList.Add(news5);

            return newsList;
        }
    }
}
