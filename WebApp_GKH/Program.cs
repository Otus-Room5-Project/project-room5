
var builder = WebApplication.CreateBuilder(args);

// add context DatabaseContext as a service
builder.Services.AddDbContext<ApplicationDbContext>();

builder.Services.AddControllersWithViews();
// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
   
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllers();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}");
});

app.Run();
