
using Nancy.Conventions;
using TinyIoC;

namespace Nancy
{
	public class CustomBootstrapper : DefaultNancyBootstrapper
	{
		protected override void ConfigureConventions(NancyConventions nancyConventions)
		{
			nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts"));
		}

		protected override void ConfigureApplicationContainer(TinyIoCContainer container)
		{

		}
	}
}

