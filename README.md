# simpleToDoList

A simple, cross-platform To-Do List application built with .NET 8 and Avalonia UI.

## Features

- Add, edit, and delete tasks
- Mark tasks as completed
- Persistent storage (tasks saved locally)
- Clean, modern UI with Avalonia
- Cross-platform: Windows, macOS, Linux

## Technologies

- **.NET 8**
- **Avalonia UI** – Cross-platform XAML-based UI framework
- **CommunityToolkit.Mvvm** – MVVM pattern support
- **SkiaSharp** – Graphics rendering
- **HarfBuzzSharp** – Text shaping

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Git (optional)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/simpleToDoList.git
   cd simpleToDoList
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

### Running the Application

```bash
dotnet run --project simpleToDoList
```

The application should launch and display the main window.

## Usage

- **Add a task**: Type in the input field at the top and press Enter or click the "+" button.
- **Edit a task**: Double-click on a task item to edit its text.
- **Delete a task**: Click the trash icon (or press Delete) on a task item.
- **Mark as completed**: Click the checkbox next to a task to toggle its completion state.

## Project Structure

```
simpleToDoList/
├── Assets/                 # Application icons and resources
├── Views/                  # XAML views (UI)
│   └── MainWindow.axaml    # Main window layout
├── ViewModels/             # MVVM view models
│   └── ViewModelBase.cs    # Base view model
├── App.axaml.cs            # Application entry point
├── Program.cs              # Standard .NET entry point
├── simpleToDoList.csproj   # Project file
└── README.md
```

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

## Contact

Your Name - [your email or profile link]

Project Link: [https://github.com/yourusername/simpleToDoList](https://github.com/yourusername/simpleToDoList)