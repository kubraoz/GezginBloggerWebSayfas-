using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvc.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
       
            protected override void Seed(BlogContext context)
            {

                List<Category> kategoriler = new List<Category>() {
                    new Category() { KategoriAdi="Yemek" },
                    new Category() { KategoriAdi = "Müze" },
                    new Category() { KategoriAdi = "Eğlence" },
                    new Category() { KategoriAdi = "Şehir" },
                };
                foreach (var item in kategoriler)
                {
                    context.Kategoriler.Add(item);
                }
                context.SaveChanges();

                List<Blog> bloglar = new List<Blog>() {
                    new Blog() {Baslik="En iyi yemekler", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true, Onay=false, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=1  },
                    new Blog() {Baslik="En iyi müzeler", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true, Onay=true, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=1  },
                    new Blog() {Baslik="En iyi ", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=false, Onay=true, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=1  },
                    new Blog() {Baslik="En iyi yemekler", EklenmeTarihi=DateTime.Now.AddDays(-30),Anasayfa=true, Onay=true, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=2  },
                    new Blog() {Baslik="En iyi eğlenceler", EklenmeTarihi=DateTime.Now.AddDays(-20),Anasayfa=true, Onay=true, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=2  },
                    new Blog() {Baslik="En iyi yemekler", EklenmeTarihi=DateTime.Now.AddDays(-1),Anasayfa=false, Onay=false, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=1  },
                    new Blog() {Baslik=" iyi yemekler", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true, Onay=true, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=1  },
                    new Blog() {Baslik="En iyi yemekler", EklenmeTarihi=DateTime.Now.AddDays(-5),Anasayfa=true, Onay=true, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=1  },
                    new Blog() {Baslik="En iyi müzeler", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true, Onay=false, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=1  },
                    new Blog() {Baslik="En iyi yemekler", EklenmeTarihi=DateTime.Now.AddDays(-8),Anasayfa=true, Onay=true, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=1  },
                    new Blog() {Baslik="En iyi şehirler", EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=false, Onay=true, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=1  },
                    new Blog() {Baslik="En iyi yemekler", EklenmeTarihi=DateTime.Now.AddDays(-12),Anasayfa=true, Onay=false, Icerik="En güzel yemekler hakkında daha ayrıltılı bilgiler", Resim="1.jpg",CategoryId=1  },
                };
                foreach (var item in bloglar)
                {
                    context.Bloglar.Add(item);
                }

                context.SaveChanges();
                base.Seed(context);
            }
        
    }
}