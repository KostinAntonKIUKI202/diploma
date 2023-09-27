using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.factory;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Interfaces.spares.sparesFrameset;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Interfaces.spares.sparesWheelset;
using TREK_Web_Diploma.Repository.factory;
using TREK_Web_Diploma.Repository.production;
using TREK_Web_Diploma.Repository.spares.sparesEquipment;
using TREK_Web_Diploma.Repository.spares.sparesFrameset;
using TREK_Web_Diploma.Repository.spares.sparesGroopset;
using TREK_Web_Diploma.Repository.spares.sparesTransmition;
using TREK_Web_Diploma.Repository.spares.sparesWheelset;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IStaffRepository, StaffRepository>();
builder.Services.AddScoped<IBikeRepository, BikeRepository>();
builder.Services.AddScoped<IFramesetRepository, FramesetRepository>();
builder.Services.AddScoped<IEquipmentRepository, EquipmentRepository>();
builder.Services.AddScoped<IGroopsetRepository, GroopsetRepository>();
builder.Services.AddScoped<IWheelsetRepository, WheelsetRepository>();

builder.Services.AddScoped<IBrakeRepository, BrakeRepository>();
builder.Services.AddScoped<IGripsRepository, GripsRepository>();
builder.Services.AddScoped<IHandlebarRepository, HandlebarRepository>();
builder.Services.AddScoped<ISaddleRepository, SaddleRepository>();
builder.Services.AddScoped<ISteeringRepository, SteeringRepository>();
builder.Services.AddScoped<IStemRepository, StemRepository>();

builder.Services.AddScoped<IBikeSizeRepository, BikeSizeRepository>();
builder.Services.AddScoped<IFrameRepository, FrameRepository>();
builder.Services.AddScoped<IForkRepository, ForkRepository>();

builder.Services.AddScoped<ICarriageRepository, CarriageRepository>();
builder.Services.AddScoped<IPedalsRepository, PedalsRepository>();
builder.Services.AddScoped<ITransmitionRepository, TransmitionRepository>();

builder.Services.AddScoped<ICassetteRepository, CassetteRepository>();
builder.Services.AddScoped<IFrontGearRepository, FrontGearRepository>();
builder.Services.AddScoped<IShifterRepository, ShifterRepository>();
builder.Services.AddScoped<ISwitchRepository, SwitchRepository>();

builder.Services.AddScoped<IHubRepository, HubRepository>();
builder.Services.AddScoped<IRimRepository, RimRepository>();
builder.Services.AddScoped<ITireRepository, TireRepository>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

if (args.Length == 1 && args[0].ToLower() == "seeddata")
{
    Seed.SeedData(app);
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
