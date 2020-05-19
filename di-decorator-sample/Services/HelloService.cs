namespace DIDecoratorSample.Services
{
	public class HelloService : IHelloService
	{
		public string SayHello(string name)
		{
			return $"Hello {name}.";
		}
	}
}
