# simpleToDoList

![GitHub repo size](https://img.shields.io/github/repo-size/yourusername/simpleToDoList)
![GitHub](https://img.shields.io/github/license/yourusername/simpleToDoList)
![GitHub issues](https://img.shields.io/github/issues/yourusername/simpleToDoList)
![GitHub pull requests](https://img.shields.io/github/issues-pr/yourusername/simpleToDoList)

A simple, cross-platform To-Do List application built with .NET 8 and Avalonia UI featuring automatic JSON persistence to `%APPDATA%\ToDoList`.

## 📋 Features

- ✅ Add, edit, and delete tasks
- ✅ Mark tasks as completed (with persistent state)
- ✅ Automatic JSON saving to local AppData folder
- ✅ Clean, modern UI with Avalonia framework
- ✅ Cross-platform: Windows, macOS, Linux
- ✅ MVVM architecture with CommunityToolkit.Mvvm
- ✅ Responsive design

## 🛠️ Technologies

- **[.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0)** - Latest LTS version
- **[Avalonia UI](https://avaloniaui.net)** - Cross-platform XAML-based UI framework
- **[CommunityToolkit.Mvvm](https://learn.microsoft.com/dotnet/communitytoolkit/mvvm/)** - MVVM pattern support
- **[SkiaSharp](https://github.com/mono/SkiaSharp)** - 2D graphics rendering
- **[HarfBuzzSharp](https://github.com/mono/HarfBuzzSharp)** - Text shaping engine
- **[System.Text.Json](https://learn.microsoft.com/dotnet/standard/serialization/system-text-json/)** - JSON serialization

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Git (optional, for cloning)

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/simpleToDoList.git
   cd simpleToDoList
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Build the project:**
   ```bash
   dotnet build
   ```

### Running the Application

```bash
dotnet run --project simpleToDoList
```

The application will launch and display the main window. Tasks are automatically saved to `%APPDATA%\ToDoList\todoitems.json` on your local machine.

## 📖 Usage

### Managing Tasks

- **Add a task**: Type in the input field at the top and press Enter or click the "+" button
- **Edit a task**: Double-click on a task item to edit its text directly
- **Delete a task**: Click the trash icon (or press Delete key) on a task item
- **Mark as completed**: Click the checkbox next to a task to toggle its completion state
- **Persistent state**: All task data (including completion status) is automatically saved to JSON

### Data Storage

Tasks are stored in:
- **Windows**: `%APPDATA%\ToDoList\todoitems.json`
- **macOS**: `$HOME/Library/Application Support/ToDoList/todoitems.json`
- **Linux**: `$XDG_DATA_HOME/ToDoList/todoitems.json` or `$HOME/.local/share/ToDoList/todoitems.json`

The JSON file contains an array of task objects with `Content` (string) and `IsChecked` (boolean) properties.

## 📂 Project Structure

```
simpleToDoList/
├── .github/                  # GitHub-specific files (ISSUE_TEMPLATE, PULL_REQUEST_TEMPLATE)
├── Assets/                   # Application icons and resources
├── Views/                    # XAML views (UI)
│   └── MainWindow.axaml      # Main window layout
├── ViewModels/               # MVVM view models
│   ├── MainWindowViewModel.cs    # Main window logic & commands
│   ├── ToDoItemViewModel.cs      # Individual task view model
│   └── ViewModelBase.cs          # Base view model with INotifyPropertyChanged
├── Models/                   # Data models
│   └── ToDoItem.cs           # Simple task model
├── Services/                 # Application services
│   └── JsonStorageService.cs     # Handles JSON persistence to AppData
├── App.axaml.cs              # Application entry point
├── Program.cs                # Standard .NET entry point
├── simpleToDoList.csproj     # Project file
├── README.md
├── LICENSE.txt
├── .gitignore
└── .gitattributes
```

## 🤝 Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

### How to Contribute

1. **Fork the Project**
2. **Create your Feature Branch** (`git checkout -b feature/AmazingFeature`)
3. **Commit your Changes** (`git commit -m 'Add some AmazingFeature'`)
4. **Push to the Branch** (`git push origin feature/AmazingFeature`)
5. **Open a Pull Request**

### Development Setup

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
2. Clone the repository: `git clone https://github.com/yourusername/simpleToDoList.git`
3. Open in your preferred IDE (Visual Studio, Rider, or VS Code with C# extension)
4. Build and run: `dotnet run --project simpleToDoList`

### Code Style

- Follow [.NET coding conventions](https://learn.microsoft.com/dotnet/standard/design-guidelines/)
- Keep methods focused and readable
- Add XML documentation for public APIs
- Write meaningful commit messages

## 📸 Screenshots

*(Add screenshots here showing the application in action)*

![Main Window](screenshots/main-window.png)
*Main window showing task list*

![Adding Task](screenshots/add-task.png)
*Adding a new task*

![Completed Tasks](screenshots/completed-tasks.png)
*Tasks with completion status*

## 📄 License

This project is licensed under the **MIT License** - see the [LICENSE.txt](LICENSE.txt) file for details.

**TL;DR**: You can do whatever you want with this code as long as you include the original copyright and license notice in any copy of the software/source.

## 👏 Acknowledgments

- [Avalonia UI Team](https://github.com/AvaloniaUI/Avalonia) for the excellent cross-platform framework
- [.NET Community Toolkit](https://learn.microsoft.com/dotnet/communitytoolkit/) for MVVM helpers
- [JetBrains](https://www.jetbrains.com/) for providing open source licenses for their IDEs
- All contributors who have helped shape this project

## 📞 Contact

Your Name - [your email or profile link]

Project Link: [https://github.com/yourusername/simpleToDoList](https://github.com/yourusername/simpleToDoList)

---

⭐ **If you found this project helpful, please consider giving it a star on GitHub!** It helps others discover the project and motivates continued development.

*Generated with ❤️ using .NET 8 and Avalonia UI*