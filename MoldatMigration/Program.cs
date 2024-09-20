using MoldatMigration.Administrativo.Context;
using Microsoft.EntityFrameworkCore;
using MoldatMigration.AdministrativoDataWarehouse.Context;
using Quartz;
using MoldatMigration.Jobs;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AdministrativoContext>(options => {
	options.UseSqlServer(builder.Configuration.GetConnectionString("AdministrativoConnection"));
});
builder.Services.AddDbContext<AdministrativoDataWarehouseContext>(options => {
	options.UseSqlServer(builder.Configuration.GetConnectionString("AdministrativoDataWarehouseConnection"));
});
//quartz
builder.Services.AddQuartz(q =>
{
	//base Quartz scheduler, job and trigger configurations
	JobKey key = new JobKey("MoldatDataWarehouseMigrationJob");
	q.AddJob<MoldatMigrationDataWarehouseJob>(jobConfig => jobConfig.WithIdentity(key));
	q.AddTrigger(opts => opts
			.ForJob(key)
			.WithIdentity("MoldatMigrationDataWarehouseJob-trigger")
		   //.WithCronSchedule(cronjobMigracionDataWarehouse)
		   .StartNow()
	);

}).AddQuartzHostedService(options => options.WaitForJobsToComplete = true);
builder.Host.ConfigureLogging(logging =>
{
	var logFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
	if(!Directory.Exists(logFolder))
	{
		Directory.CreateDirectory(logFolder);
	}

	var logFile = Path.Combine(logFolder, "moldatmigrator-.log");
	logging.AddSerilog();
	Log.Logger = new LoggerConfiguration()
		.MinimumLevel.Information()
		.MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Error)
		.MinimumLevel.Override("Microsoft.AspNetCore", Serilog.Events.LogEventLevel.Error)
		.MinimumLevel.Override("Microsoft.EntityFrameworkCore", Serilog.Events.LogEventLevel.Error)
		.WriteTo.File(logFile, rollingInterval: RollingInterval.Day)
		.CreateLogger();
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
