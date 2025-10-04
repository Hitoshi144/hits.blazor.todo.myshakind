﻿using TodoApp.Data.Interfaces;

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
public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
			return await Task.FromResult(tasks);
        }
    }
}
