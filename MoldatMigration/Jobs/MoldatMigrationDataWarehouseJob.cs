using MoldatMigration.Administrativo.Context;
using MoldatMigration.Administrativo.Models;
using MoldatMigration.AdministrativoDataWarehouse.Context;
using MoldatMigration.AdministrativoDataWarehouse.Models;
using Quartz;

namespace MoldatMigration.Jobs;

public class MoldatMigrationDataWarehouseJob : IJob
{
	private readonly AdministrativoContext _administrativoContext;
	private readonly AdministrativoDataWarehouseContext _administrativoDataWarehouseContext;
	private readonly ILogger<MoldatMigrationDataWarehouseJob> _logger;
	public MoldatMigrationDataWarehouseJob(AdministrativoContext administrativoContext, AdministrativoDataWarehouseContext administrativoDataWarehouseContext, ILogger<MoldatMigrationDataWarehouseJob> logger)
    {
        _administrativoContext = administrativoContext;
		_administrativoDataWarehouseContext = administrativoDataWarehouseContext;
		_logger = logger;
    }
    public Task Execute(IJobExecutionContext context)
	{
		AlmacenMigration();
		return Task.CompletedTask;
	}
	internal void AlmacenMigration()
	{
		try
		{
			var lastInserted = _administrativoDataWarehouseContext.Almacens.OrderByDescending(x=>x.CodAlmacen).FirstOrDefault();
			if (lastInserted != null)
			{
				var lastId = lastInserted.CodAlmacen;
				var newElements = _administrativoContext.Almacens.Where(x => x.CodAlmacen > lastId);
				if(newElements != null)
				{
					var ListForInsert = new List<AlmacenDW>();
					foreach(var element in newElements)
					{
						ListForInsert.Add(new AlmacenDW
						{
							CodAlmacen = element.CodAlmacen,
							Nombre = element.Nombre,
							Direccion = element.Direccion,
							CodRD = element.CodRD,
							CodUbigeo = element.CodUbigeo,
						});
					}
					_administrativoDataWarehouseContext.AddRange(ListForInsert);
					_administrativoDataWarehouseContext.SaveChanges();
				}
			}
		} catch(Exception ex)
		{
			_logger.LogError($"AlmacenMigration {ex.Message}");
		}
	}
}
