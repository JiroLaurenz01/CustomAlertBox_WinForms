# Custom Alert Box for WinForms

An interactive WinForms application that provides customizable alert notifications for various events. Choose from different alert types such as Success, Warning, Error, and Info, each with its own visual style. The app features smooth animations and allows users to manually dismiss alerts. Enhance your user interface with this versatile alert notification system.

## Features

- Create custom alert notifications for your WinForms application.
- Choose from different alert types: Success, Warning, Error, and Info.
- Smooth animations for alert opening and closing.
- Easy-to-use interface for displaying and managing alerts.
- Manual dismissal of alerts.

## Getting Started

To use this custom alert box in your WinForms application, follow these steps:

### Prerequisites

- Visual Studio with WinForms support.
- .NET Framework.

### Installation

1. Clone or download this repository to your local machine.

2. Open the solution in Visual Studio.

3. Build and run the project.

4. Add the Guna.UI2.WinForms NuGet package manager to your project:

   ```sh
   Install-Package Guna.UI2.WinForms

5. Build and run your application with the custom alert box feature.

## Usage

1. Import the `AlertForm` class into your project.

2. Create an instance of `AlertForm`.

3. Use the `ShowAlert` method to display custom alerts with the desired message and type.

```csharp
AlertForm alert = new AlertForm();
alert.ShowAlert("This is a success message.", AlertForm.Type.Success);
```
