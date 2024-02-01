using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Lutfee6510110408.Components.data;
using Lutfee6510110408.Components.Pages;

namespace Lutfee6510110408
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();

            builder.Services.AddDbContextFactory<BookDbContext>(opt =>
            {
                var bdPath = Path.Combine(FileSystem.AppDataDirectory, $"{nameof(BookDbContext)}.db");
                opt.UseSqlite($"Data Source={bdPath}");
                using var dbcontext = new BookDbContext(opt.Options);
                if (dbcontext.Database.EnsureCreated())
                    dbcontext.SaveChanges();
            });
#endif

            return builder.Build();
        }
    }
}
