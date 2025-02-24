## GrpcDependencies Project CHANGELOG
02/23/2025
- Add Nuget package `dotnet add .\GrpcDependencies.csproj package Grpc.Net.Client`
- Add Nuget package `dotnet add .\GrpcDependencies.csproj package Google.Protobuf`
- Add Nuget package `dotnet add .\GrpcDependencies.csproj package Grpc.Tools`
- Add Nuget package `dotnet add .\GrpcDependencies.csproj package Grpc.AspNetCore`
- Add the `Protos` folder and `greeter.proto`
- Modify `GrpcDependencies.csproj` to include Protofbuf only it will create both server and client components for Grpc
- Remove `class1.cs`