# PropOnChange

Demonstates how to use a C# Class **OnPropertyChanged** to get around issue where a property Set requires an async call, especially to a database such as with Entity Framework Core. Project is a simple Console app that _simulates_ the async wait requirement by having a method that has a dsely that requires awaiting.

This is discussed in detail on the blog site at [Blazor Helpers App: 7. Async EF calls from an Entity Property](https://davidjones.sportronics.com.au/blazor/Blazor_Helpers_App-Async_EF_calls-blazor.html)

# Running the app

1. Clone the repository
   1. Build and run from Visual Studio
   2. OR Run from VS Code
   3. OR from a Command Line
     - Open the local folder in a Terminal Window _(Right-click in File Explorer)_
     - ```dotnet run```
2. Run the Notebook from VS Code
  - Just get the **Notebook.dib** file from the repository
  - Set up VS Code for [.NET Interactive Notebooks](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode)
  - Run the app ```Run All```
