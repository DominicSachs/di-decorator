using System;

namespace DIDecoratorSample.Services
{
	public class HelloDateTimeAppenderDecorator : IHelloService
	{
		private readonly IHelloService _decoratee;

		public HelloDateTimeAppenderDecorator(IHelloService decoratee)
		{
			_decoratee = decoratee;
		}

		public string SayHello(string name)
		{
			var result = _decoratee.SayHello(name);

			return $"{result} It is {DateTime.Now.ToLongDateString()}.";
		}
	}
}
