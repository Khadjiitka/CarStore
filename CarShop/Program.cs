using CarShop.Data.mocks;
using CarShop.Data.Models.interfaces;

var builder = WebApplication.CreateBuilder(args);

// --- Аналог ConfigureServices ---
// Якщо в туторіалі в цей метод додадуть щось на кшталт services.AddControllers();
// ви пишете тут: builder.Services.AddControllers();
//Йдіть у метод ConfigureServices
builder.Services.AddMvc();
builder.Services.AddTransient<IAllCars, MockCars>(); //  інтерфейс IAllCars  реалізується в класі MockCars для впровадження залежностей
builder.Services.AddTransient<ICarsCategory, MockCategory>();
var app = builder.Build();

// --- Аналог Configure ---
// if (env.IsDevelopment()) { app.UseDeveloperExceptionPage(); }
//Йдіть у Configure

//  Отображение детальных ошибок при разработке
app.UseDeveloperExceptionPage();

//  Отображение текстовых статусов для ошибок (например, "404 Not Found")
app.UseStatusCodePages();

//  Поддержка статических файлов (css, js, картинки из wwwroot)
app.UseStaticFiles();

//  Поддержка MVC с маршрутом по умолчанию
app.UseMvcWithDefaultRoute();


app.Run();