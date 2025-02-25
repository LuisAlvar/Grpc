﻿using System.Threading.Tasks;
using Grpc.Core;
using Greeter;

namespace BasicGrpcService.Services
{
  public class GreetingsManagerService: GreetingsManager.GreetingsManagerBase
  {
    public override Task<GreetingResponse> GenerateGreeting(GreetingRequest request, ServerCallContext context)
    {
      Console.WriteLine("Server sending reponse ... ");
      return Task.FromResult(new GreetingResponse {
        GreetingMessage = "Hello " + request.Name
      });
    }
  }
}
