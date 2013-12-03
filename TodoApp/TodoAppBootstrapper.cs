using Nancy;
using Nancy.Conventions;

namespace TodoApp
{
    public class TodoAppBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            // Scriptsディレクトリ以下のファイルを静的コンテンツとして扱うようにする。
            nancyConventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("Scripts")    
            );
        }
    }
}
