﻿namespace TodoServerApp.Data.interfaces
{
	public interface IDataService
	{
		Task<IEnumerable<TaskItem>> GetAllAsync();
		Task SaveAsync(TaskItem item);
		Task<TaskItem> GetTaskAsync(int id);
		Task DeleteAsync(int id);
	}
}
