# BasicGrpc Project 
02/23/2025
- Create a new folder `BasicGrpc`
- Create a new file `New-Item CHANGELOG.md`
- Create a new solution file `dotnet new sln --name BasicGrpc`
- Create a new server project `dotnet new webapp -o BasicGrpcService -f net6.0`
- Create a new client project `dotnet new console -o BasicGrpcClient -f net6.0`
- Create a new classlibrary project `dotnet new classlib -o GrpcDependencies -f net6.0`
- Add all csproj to solution file `dotnet sln .\BasicGrpc.sln add (ls -r **/*.csproj)`
- Add `.gitignore` template file for Visual Studio 2022
- Add `wwwroot/` to the `.gitignore` file