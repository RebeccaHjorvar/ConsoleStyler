
# Console Styler

A simple way to put some color and other personalizations to your very own C# console application.


## Features

- Change background color
- Change text color
- Edit title
- Generate a simple header
## Installation

To install ConsoleStyler, run the following command in the [Package Manager Console](https://docs.microsoft.com/en-us/ef/core/cli/powershell) 

```
Install-Package ConsoleStyler
```    
## Usage/Examples

```c#
using ConsoleStyler;

// Sets background color to magenta and font color to black
Styler.Colors("Magenta", "Black");

// Sets the title for the console app to "My First Console App"
Styler.Title("My First Console App"); 

// Generates a header with the text "Welcome to my Console App!"
Styler.Header("Welcome to my Console App!");

```


## Authors

- [@rebeccahjorvar](https://www.github.com/rebeccahjorvar)


## Contributing

Contributions are always welcome!




## License

[MIT](https://choosealicense.com/licenses/mit/)

