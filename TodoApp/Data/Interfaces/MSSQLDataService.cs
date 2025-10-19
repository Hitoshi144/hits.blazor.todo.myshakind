
using Microsoft.EntityFrameworkCore;

namespace TodoApp.Data.Interfaces {
    public class MSSQLDataService(ApplicationDbContext context) : IDataService {
        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            return await context.TaskItems.ToArrayAsync();
        }
    }
}
