using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data.interfaces;

namespace TodoServerApp.Data.Services
{
	public class MSSQLDataService (ApplicationDbContext context) : IDataService
	{
		public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
		{
			return await context.TaskItems.ToArrayAsync();
		}
	}
}
