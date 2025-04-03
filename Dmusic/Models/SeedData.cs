using Dmusic.Controllers;
using Dmusic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace Dmusic.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DmusicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DmusicContext>>()))
            {
                // Kiểm tra thông tin cuốn sách đã tồn tại hay chưa
                if (context.Album.Any())
                {
                    return;   // Không thêm nếu cuốn sách đã tồn tại trong DB
                }

                context.Album.AddRange(
                    new Album
                    {
                        Title = "Atomic Habits",
                        ReleaseDate = DateTime.Parse("2018-10-16"),
                        Genre = "Self-Help",
                        Price = 11.98M
                    },
                    new Album
                    {
                        Title = "Dark Roads",
                        ReleaseDate = DateTime.Parse("2021-8-3"),
                        Genre = "Novel",
                        Price = 18.59M
                    }
                );
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}