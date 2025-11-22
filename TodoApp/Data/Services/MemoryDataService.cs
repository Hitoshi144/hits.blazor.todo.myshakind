using TodoApp.Data.Interfaces;

namespace TodoApp.Data.Services {
    public class MemoryDataService : IDataService {
        private static IEnumerable<TaskItem> tasks = new List<TaskItem>
	{
		new TaskItem
		{
			Id = 1,
			Title = "Задача 1",
			Description = "Описание задачи 1",
			CreateDate = DateTime.Now,
		},
		new TaskItem
		{
			Id = 2,
			Title = "Задача 2",
			Description = "Описание задачи 2",
			CreateDate = DateTime.Now,
		},
		new TaskItem
        {
            Id = 3,
            Title = "Задача 3",
            Description = "Описание задачи 3",
            CreateDate = DateTime.Now,
        },
	};

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
			return await Task.FromResult(tasks);
        }

        public Task SaveAsync(TaskItem item)
        {
            throw new NotImplementedException();
        }
    }
}
