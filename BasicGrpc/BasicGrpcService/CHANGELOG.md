## BasicGrpcService Project CHANGELOG
02/23/2025
- Add Nuget package `dotnet add .\BasicGrpcService.csproj package Grpc.AspNetCore`
- Remove Nuget package due to the class library for Grpc 
- Add a new folder `Services`
- Add a new file `GreetingsManagerService.cs`
- Modify `Program.cs` file to add gPRC service and middleware
- Add Project reference to GrpcDependencies.csproj
- Modify `launchSettings.json` the solution ports "applicationUrl": "https://localhost:5001;http://localhost:5000",