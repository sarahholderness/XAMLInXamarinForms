# Build a Xamarin.Forms Application with XAML

In this project we’ll take an existing XAML pages and wire them together into an application using the common page types of navigation, tabbed, coursel, and modal as well as so basic stypling to create a presentable application.

# Setup the Application

## Using Visual Studio
If you want to use Visual Studio _(highly recommended)_ follow the following steps:
-   If you already have Visual Studio installed make sure you have .NET Core installed by running the "Visual Studio Installer" and making sure ".NET Core cross-platform development" is checked.
-   If you need to install Visual Studio download it at https://visualstudio.microsoft.com/ by selecting "Community 2019" from the "Dowload Visual Studio" drop down list. _(If you're using Windows you'll want to check "ASP.NET" and ".NET Core cross-platform development" on the workloads screen during installation.)_
-   Open the .sln file in Visual Studio.
-   To run the application simply press the Start Debug button _(green arrow)_ or press F5.
-   If you're using Visual Studio on Windows, to run tests open the Test menu, click Run, then click on Run all tests. _(results will show up in the Test Explorer)_
-   If you're using Visual Studio on macOS, to run tests select the `XAMLInXamarinFormsTests` Project, then go to the Run menu, then click on Run Unit Tests. _(results will show up in the Unit Tests panel)_

_(Note: All tests should fail at this point. This is by design. As you progress through the project, more and more tests will pass. All tests should pass upon completion of the project.)_

## Using a Tool Other Than Visual Studio
If you would rather use something other than Visual Studio:
-   Install the .NET Core SDK from https://dotnet.microsoft.com/download once that installation completes, you're ready to get started!
-   To run the application go into the `XAMLInXamarinForms` project folder and type `dotnet run`.
-   To run the tests go into the `XAMLInXamarinFormsTests` project folder and type `dotnet test`.

# Features you will implement

- A Navigation Page
- A Tabbed Page
- A Carousel Page
- Basic Styling
- A Modal

## Tasks necessary to complete implementation

__Note:__ This isn't the only way to accomplish implementation. However, this is what the project's tests are expecting. Implementing the features in a different way will likely result in being marked as incomplete / incorrect.

- [ ] Create a new `TabbedPage` in the `Views/Nutrition` folder with the name `NutritionView`.
    - [ ] When you create the `TabbedPage` in Visual Studio (or similiar) the following code should be generated for you, if not you'll need to add it yourself.
      - The first line should be the `xml` tag `<?xml version="1.0" encoding="utf-8" ?>`.
      - The second line should be an openning `TabbedPage` tag with the following attributes:
        - `xmlns="http://xamarin.com/schemas/2014/forms"`
        - `xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"`
        - `xmlns:d="http://xamarin.com/schemas/2014/forms/design"`
        - `xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"`
        - `xmlns:nutritionviews="clr-namespace:XAMLInXamarinForms.Views.Nutrition"`
        - `mc:Ignorable="d"`
        - `x:Class="XAMLInXamarinForms.Views.Nutrition.NutritionView"`
      - The last line should be the closing `TabbedPage` tag.
    - [ ] Between the `TabbedPage` tags, add opening and closing `TabbedPage.Title` tags containing the value `Nutrition`.
    - [ ] After the closing `TabbedPage.Title` tags, add a new self closing tag with the of type `nutritionviews:BreakfastView`.
    - [ ] After the `nutritionviews:BreakfastView` tag, add a new self closing tag with the type `nutritionviews:LunchView`.
    - [ ] After the `nutritionviews:LunchView` tag, add a new self closing tag with the type `nutritionviews:DinnerView`.
    - [ ] After the `nutritionviews:DinnerView` tag, add a new self closing tag with the type `nutritionviews:SnackView`.
- [ ] Creat a new `CourselPage` in the `Views/Fitness` folder with the name `FitnessView`.
  - [ ] When you create the `CourselPage` in Visual Studio (or similiar)the following code should be generated for you, if not you'll need to add it yourself.
  - [ ] - The first line should be the `xml` tag `<?xml version="1.0" encoding="utf-8" ?>`.
      - The second line should be an openning `CourselPage` tag with the following attributes:
        - `xmlns="http://xamarin.com/schemas/2014/forms"`
        - `xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"`
        - `xmlns:d="http://xamarin.com/schemas/2014/forms/design"`
        - `xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"`
        - `xmlns:nutritionviews="clr-namespace:XAMLInXamarinForms.Views.Fitness"`
        - `mc:Ignorable="d"`
        - `x:Class="XAMLInXamarinForms.Views.Fitness.FitnessView"`
      - The last line should be the closing `CourselPage` tag.
      - Between the `CourselPage` tags, add opening and closing `CourselPage.Title` tags containing the value `Fitness`.
      - 
      
## What Now?

-----------------------------------------------------------------
PUT SOMETHING HERE
-----------------------------------------------------------------