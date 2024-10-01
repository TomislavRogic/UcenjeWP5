using EdunovaAPP.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// dodavanje baze podataka
// dodajemo novi service
builder.Services.AddDbContext<EdunovaContext>(opcije =>
{
    opcije.UseSqlServer(builder.Configuration.GetConnectionString("EdunovaContext"));
});
// s ovom linijom koda smo dodali bazu podataka u aplikaciju, na nacin da smo dodali DbContext, a onda smo dodali DbContext
// u servise // Svi se od svuda na sve moguæe naèine mogu spojitina naš API
// Čitati https://code-maze.com/aspnetcore-webapi-best-practices/
builder.Services.AddCors(opcije =>
{
    opcije.AddPolicy("CorsPolicy",
        builder =>
            builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
    );

});





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(o =>
    {
        o.ConfigObject.AdditionalItems.Add("requestSnippetsEnabled", true);
        o.EnableTryItOutByDefault();
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("CorsPolicy");

app.Run();
