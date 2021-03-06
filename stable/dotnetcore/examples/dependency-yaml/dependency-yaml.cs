using System;
using Kubeless.Functions;
using YamlDotNet.Serialization;
using System.Threading.Tasks;

public class module
{
    public Task<object> handler(Event k8Event, Context k8Context)
    {
        var person = new Person()
        {
            Name = "Michael J. Fox",
            Age = 56
        };

        var serializer = new SerializerBuilder().Build();
        return Task.FromResult<object>(serializer.Serialize(person)); // yaml
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}