
using Microsoft.EntityFrameworkCore;

namespace TodoApp.Data.Interfaces {
    public class MSSQLDataService(ApplicationDbContext context) : IDataService {
        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            return await context.TaskItems.ToArrayAsync();
        }

        public async Task SaveAsync(TaskItem item)
        {
            if (item.Id == 0)
            {
                item.CreateDate = DateTime.Now;
                await context.TaskItems.AddAsync(item);
            }
            else
            {
                context.TaskItems.Update(item);
            }
            await context.SaveChangesAsync();
        }

        public async Task<TaskItem> GetTaskAsync(int id)
        {
            return await context.TaskItems.FirstAsync(x => x.Id == id);
        }

        public async Task DeleteAsync(int id)
        {
            var taskItem = await context.TaskItems.FirstAsync(x => x.Id == id);
            context.TaskItems.Remove(taskItem);
            await context.SaveChangesAsync();
        }
    }
}
