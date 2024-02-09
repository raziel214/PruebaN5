using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplication.Dto.KafkaTopic;
using Confluent.Kafka;

namespace Infraestructure.Kafka
{
    public  class KafkaProducer
    {
        private readonly ProducerConfig config;
        public KafkaProducer(string bootstrapServers)
        {
            config = new ProducerConfig { BootstrapServers = bootstrapServers };
        }
        public async Task ProduceMessageAsync(string topic, KafkaTopicProducer message)
        {
            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                var value = System.Text.Json.JsonSerializer.Serialize(message);
                await producer.ProduceAsync(topic, new Message<Null, string> { Value = value });
                Console.WriteLine($"Message {message.Id} sent to {topic}");
            }
        }
    }
}
