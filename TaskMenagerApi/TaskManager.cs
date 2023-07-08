namespace TaskMenagerApi
{
    public class TaskManager
    {
        private readonly List<Task> _tasks;
        public TaskManager()
        {
            _tasks = new List<Task>();
        }
        public List<Task> GetTasks()
        {
            return _tasks;
        }
        public Task GetTaskById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }
        public void AddTask(Task task)
        {
            task.Id = GenerateNewTaskId();
            _tasks.Add(task);
        }
        public bool UpdateTask(int id, Task updatedTask)
        {
            var existingTask = _tasks.FirstOrDefault(t => t.Id == id);
            if (existingTask != null)
            {
                existingTask.Title = updatedTask.Title;
                existingTask.IsCompleted = updatedTask.IsCompleted;
                return true;
            }
            return false;
        }
        public bool MarkTaskAsCompleted(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
                return true;
            }
            return false;
        }
        public bool DeleteTask(int id)
        {
            var taskToRemove = _tasks.FirstOrDefault(t => t.Id == id);
            if (taskToRemove != null)
            {
                _tasks.Remove(taskToRemove);
                return true;
            }
            return false;
        }
        private int GenerateNewTaskId()
        {
            if (_tasks.Count > 0)
            {
                return _tasks.Max(t => t.Id) + 1;
            }
            return 1;
        }
        public bool RemoveTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
                return true;
            }
            return false;
        }
    }

}
