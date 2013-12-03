using System.Data.Entity;
using Nancy;
using Nancy.Conventions;
using TodoApp.Models;

namespace TodoApp
{
    public class TodoAppBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            // EntityFramework のコードファースト設定。モデルに変更がある場合にDBを作り直す。
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TodoAppContext>());
        }

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
