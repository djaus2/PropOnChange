# PropOnChange

Demonstates how to use a C# Class **OnPrpertyChanged** to get around issue where a property Set requires an async call, especially to a database such as with Entity Framework Core. Project is a simple Console app that _simulates_ the async wait requirement by having a method that has a dsely that requires awaiting.

This is discussed in detail on the blog site at [Blazor Helpers App: 7. Async EF calls from an Entity Property](https://www.sportronics.com.au/blazor/Blazor_Helpers_App-Async_EF_calls-blazor.html)
