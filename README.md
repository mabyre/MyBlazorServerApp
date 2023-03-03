
# My Blazor Server App

My Sample Balzor App to demonstate cherry picked code, that I want to look at, make it mine.

## Separate Code and View

* Look in Pages/Counter code is seperate by derivate from ComponentBase

At the begining, after using this, I gave up cause of numerous waste of time due to variables private not protected forgotten. I know use the template wich is a partial class less time wasted.

If we needed secure component most use this way of code-behind with **@inherits CounterBase**.

## Use of interface in Data Services

* To separate Code from Fetch Data View

Can be useful if another Razor page would like to display Weather data

## Add a TodoList

Sample ToDoList in Balzor
 
## Add Page WeatherForcaste

* To use EditForm capabilities of Blazor binding a form on a Model

<img style="margin: 10px" src="Images/2023-02-23_11h26_48.png" alt="TemplateVisualStudio Ribbon transform Icon Image" />

## Creation of Class Razor Librairie

First I had to find how to use "git move" to move this project to a subdirectory then to add the class blazor librairy. 

**To Be Done.**

## Blazor Dynamic Component

Dynamicly change the html content using **DynamicComponent** to load html Blazor components

<img style="margin: 10px" src="Images/2023-03-03_10h29_48.png" alt="TemplateVisualStudio Ribbon transform Icon Image" />

I say "Html component" because there is no much more in those Blazor Component sample shoud be enhanced.

## Use of appsettings.json

So easy to use \MyBlazorServerApp\wwwroot\appsettings.json

```json
{
  "h1FontSize": "50px"
}
```

```html
<h1 style="font-size:@Configuration["h1FontSize"]">
    Configuration example
</h1>
```

## Counter now demonstrate the use of ILogger in code behing

The use of **ILoggerFactory** and **ILogger** in **code-behind**.

```csharp
    [Inject]
    protected ILoggerFactory loggerFactory { get; set; }

    private ILogger<CounterBase> logger => loggerFactory.CreateLogger<CounterBase>();
```





