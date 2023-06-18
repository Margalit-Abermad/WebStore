using AppService;


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddAppServices();


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//app.UseCors(options =>
//{
//    options.WithOrigins("http://localhost:4000").AllowAnyHeader().AllowAnyMethod();
//});

app.UseCors((builder) =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});

//private void SetPrincipal(IPrincipal principal)
//{
//    Thread.CurrentPrincipal = principal;
//    if (HttpContext.Current != null)
//    {
//        HttpContext.Current.User = principal;
//    }
//}

app.UseRouting();

app.UseCors(builder =>
{
    builder.WithOrigins("https://http://localhost:4200")
           .AllowCredentials()
           .AllowAnyMethod()
           .AllowAnyHeader();
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapControllers();

app.Run();