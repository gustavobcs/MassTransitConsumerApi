using MassTransit;
using System;
using System.Threading.Tasks;
using Test.Messages;

namespace MassTransitConsumerApi.Consumers
{
    public class TestConsumer : IConsumer<TestMessage>
    {
        public Task Consume(ConsumeContext<TestMessage> context)
        {
            Console.WriteLine($"Received {context.Message.Text}");
            return Task.FromResult(0);
        }
    }
}
