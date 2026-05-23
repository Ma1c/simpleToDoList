using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using simpleToDoList.Models;
using simpleToDoList.ViewModels;

namespace simpleToDoList.Services
{
    public class JsonStorageService
    {
        private readonly string _storageDirectory;
        private readonly string _storageFilePath;

        public JsonStorageService()
        {
            // Get the path to %APPDATA%\ToDoList
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _storageDirectory = Path.Combine(appDataPath, "ToDoList");
            _storageFilePath = Path.Combine(_storageDirectory, "todoitems.json");

            // Ensure the directory exists
            Directory.CreateDirectory(_storageDirectory);
        }

        public ObservableCollection<ToDoItemViewModel> LoadToDoItems()
        {
            if (!File.Exists(_storageFilePath))
            {
                return new ObservableCollection<ToDoItemViewModel>();
            }

            try
            {
                string json = File.ReadAllText(_storageFilePath);
                var toDoItems = JsonSerializer.Deserialize<ToDoItem[]>(json) ?? Array.Empty<ToDoItem>();
                var viewModels = new ObservableCollection<ToDoItemViewModel>();

                foreach (var item in toDoItems)
                {
                    viewModels.Add(new ToDoItemViewModel(item));
                }

                return viewModels;
            }
            catch (Exception)
            {
                // If there's an error loading, return an empty collection
                return new ObservableCollection<ToDoItemViewModel>();
            }
        }

        public void SaveToDoItems(ObservableCollection<ToDoItemViewModel> toDoItems)
        {
            try
            {
                // Convert ViewModels back to Models for serialization
                var toDoItemModels = new ToDoItem[toDoItems.Count];
                int index = 0;
                foreach (var viewModel in toDoItems)
                {
                    toDoItemModels[index++] = viewModel.GetToDoItem();
                }

                // Serialize to JSON with indentation for readability
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(toDoItemModels, options);

                // Write to file
                File.WriteAllText(_storageFilePath, json);
            }
            catch (Exception)
            {
                // In a production app, you might want to log this error
                // For now, we'll just silently fail to avoid crashing the app
            }
        }
    }
}