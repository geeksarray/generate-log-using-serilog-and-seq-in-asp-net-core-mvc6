using Serilog;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Host.UseSerilog((ctx, lc) => lc.ReadFrom.Configuration(ctx.Configuration));

//var _logger = new LoggerConfiguration()
//                .Enrich.FromGlobalLogContext()
//                .WriteTo.File("./logs/log-.txt", rollingInterval: RollingInterval.Day)
//                .WriteTo.Seq("http://localhost:5341", Serilog.Events.LogEventLevel.Warning)
//                .Enrich.WithProperty("ServiceName", "SomeConsumer")
//                .MinimumLevel.Debug()
//                .CreateLogger();

//var _logger = new LoggerConfiguration()
//    .Enrich.FromLogContext()
//    .Enrich.WithProcessId()
//    .Enrich.WithProcessName()
//    .Enrich.WithProperty("CustomerKey", "ABC123")
//    .WriteTo.File("./logs/log-.txt", rollingInterval: RollingInterval.Day) 
//    .CreateLogger();


//var _logger = new LoggerConfiguration()
//    .Enrich.FromLogContext()
//    .Enrich.WithProcessId()
//    .Enrich.WithProcessName()
//    .Enrich.WithProperty("CustomerKey", "ABC123")
//    .Enrich.WithProperty("PID", Process.GetCurrentProcess().Id) // 9840
//    .WriteTo.File("./logs/log-.txt", rollingInterval: RollingInterval.Day,
//        outputTemplate: "{Timestamp:HH:mm:ss} {Message} {CustomerKey} {PID}{NewLine}{Exception}"
//    )
//    .CreateLogger();


//builder.Logging.AddSerilog(_logger);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSerilogRequestLogging();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
