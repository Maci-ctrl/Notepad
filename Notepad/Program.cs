using Microsoft.EntityFrameworkCore;
using Notepad.Data;
using Notepad.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<NotebookContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("NotepadContext")), ServiceLifetime.Transient); 
        
        builder.Services.AddDbContext<FormContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("FormContext")), ServiceLifetime.Transient);

        builder.Services.AddTransient<INoteService, NoteService>();
        builder.Services.AddTransient<IFormService, FormService>();


        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;

            var context = services.GetRequiredService<NotebookContext>();
            var context2 = services.GetRequiredService<FormContext>();
            DbInitializer.InitializeAsync(context);
            DbInitializer.InitializeAsync(context2);
        }

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}