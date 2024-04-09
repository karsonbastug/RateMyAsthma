using AsthmaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using AsthmaAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddScoped<CityReview, IAClass>();
builder.Services.AddScoped<MaxReview, MaxReviewClass>();
builder.Services.AddScoped<IgetLocDetails, getLocDetails>();
builder.Services.AddScoped<IAvgRPSByCity, AvgRatingPerSeasonByCity>();
builder.Services.AddScoped<IGetTemp, GetTemp>();
builder.Services.AddScoped<IGetLocRate, GetLocRate>();



builder.Services.AddDbContext<DBContextClass>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMyRazorPagesApp",
        builder =>
        {
            builder.WithOrigins("https://localhost:7171")
                .AllowAnyHeader()
                .AllowAnyMethod();
        }
        );
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseCors("AllowMyRazorPagesApp");

app.UseAuthorization();

app.MapControllers();

app.Run();