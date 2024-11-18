namespace TodoServerApp.Data.interfaces
{
	public interface IDataService
	{
		Task<IEnumerable<TaskItem>> GetTaskItemsAsync();
	}
}
