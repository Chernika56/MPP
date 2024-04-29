using FakerLab.Entities;
using FakerLab.FakerLib;

var config = new FakerConfig();
config.Add<B, int, CustomIntGenerator>(b => b.Id);

var faker = new Faker(config);

faker.AddGeneratorWithPlugin("Plugins/UriGenerator.dll");
faker.AddGeneratorWithPlugin("Plugins/BoolGenerator.dll");

Console.WriteLine(faker.Create<A>());
Console.WriteLine(faker.Create<B>());
Console.WriteLine(faker.Create<OuterTestDTO>());
