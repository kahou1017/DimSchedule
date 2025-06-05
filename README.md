# DimSchedule

This repository contains a minimal ASP.NET MVC (targeting .NET Framework 4.8) sample demonstrating a simple scheduler website. The project is located in the `Scheduler.Web` folder and can be opened with Visual Studio 2019 or later.

## Features

- Forms authentication with a basic login page (`admin` / `password`).
- Main page displayed after login.
- Ability to create a schedule item with immediate or scheduled execution time.
- Data stored in a local database using Entity Framework.
- History page that lists all created schedule items along with their execution details.

## Building

Open `DimSchedule.sln` in Visual Studio and restore NuGet packages to build and run the application. Entity Framework will automatically create a LocalDB database named `ScheduleDb` on first run using the connection string in `web.config`.
