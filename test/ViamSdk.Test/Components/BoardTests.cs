﻿using Microsoft.Extensions.Logging;
using Viam.Client.Clients;
using Viam.Client.Dialing;

namespace Viam.Core.Test.Components
{
    internal class BoardClientTests
    {
        private RobotClient? _robotClient;

        [SetUp]
        public async Task Setup()
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.SetMinimumLevel(LogLevel.Trace);
            });

            var machineAddress = Environment.GetEnvironmentVariable("ROBOT_ADDRESS")
                                 ?? throw new InvalidOperationException("Missing Environment Variable");
            var apiKey = Environment.GetEnvironmentVariable("VIAM_API_KEY") ??
                         throw new InvalidOperationException("Missing Environment Variable");
            var apiKeyId = Environment.GetEnvironmentVariable("VIAM_API_KEY_ID")
                           ?? throw new InvalidOperationException("Missing Environment Variable");

            var robotClientOptions = DialOptions
                .FromAddress(machineAddress)
                .WithLogging(loggerFactory)
                .WithApiCredentials(apiKey, apiKeyId)
                .SetDisableWebRtc();

            _robotClient = await RobotClient.AtAddressAsync(robotClientOptions);
        }

        [Test]
        public async Task Test_GetPin()
        {
            //var board = BoardClient.FromRobot(_robotClient!, "board");
            //var pin = await board.GetGpioPinByName("37");
            //try
            //{
            //    Assert.IsNotNull(pin);
            //    Assert.IsFalse(await pin.GetAsync());
            //    await pin.SetAsync(false);
            //    Assert.IsFalse(await pin.GetAsync());
            //    await pin.SetAsync(true);
            //    Assert.IsTrue(await pin.GetAsync());
            //}
            //finally
            //{
            //    await pin.SetAsync(false);
            //}
        }
    }
}