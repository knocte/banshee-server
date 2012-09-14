
using Nancy;

namespace Nancy
{
	public class PageModule : NancyModule
	{
		public PageModule()
		{
			Get["/"] = parameters => "Hello World";
		}
	}
}

