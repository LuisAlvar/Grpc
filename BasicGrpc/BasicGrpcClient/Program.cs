﻿using Greeter;
using Grpc.Net.Client;

// The port number(5001) must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:5001");

var client = new GreetingsManager.GreetingsManagerClient(channel);

var reply = await client.GenerateGreetingAsync(new GreetingRequest
{
  Name = "BasicGrpcClient"
});

Console.WriteLine($"Greeting: {reply.GreetingMessage}");
Console.WriteLine("Press any key to exit ...");
Console.ReadKey();