using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMenagerApi;
using Task = TaskMenagerApi.Task;

namespace TestProject2
{
    public class TaskManagerTest
    {
        private TaskManager _taskManager;
        [SetUp]
        public void Setup()
        {
            _taskManager = new TaskManager();
        }
        [Test]
        public void AddTask_ShouldIncreaseTaskCount()
        {
            // Arrange
            var task = new Task("Test task");
            // Act
            _taskManager.AddTask(task);
            // Assert
            Assert.AreEqual(1, _taskManager.GetTasks().Count);
        }
        [Test]
        public void RemoveTask_ExistingTask_ShouldDecreaseTaskCount()
        {
            // Arrange
            var task = new Task("Test task");
            _taskManager.AddTask(task);
            // Act
            _taskManager.RemoveTask(task.Id);
            // Assert
            Assert.AreEqual(0, _taskManager.GetTasks().Count);
        }
        [Test]
        public void RemoveTask_NonExistingTask_ShouldNotChangeTaskCount()
        {
            // Arrange
            var task = new Task("Test task");
            _taskManager.AddTask(task);
            // Act
            _taskManager.RemoveTask(task.Id);
            // Assert
            Assert.AreEqual(0, _taskManager.GetTasks().Count);
        }
    }
}
