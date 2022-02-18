using LinqNote.Command;
using Microsoft.Extensions.DependencyInjection;

namespace LinqNote
{
    /// <summary>
    /// 紀錄LINQ使用筆記
    /// </summary>
    class Program
    {
        public static void Main()
        {
            // 1.注入容器
            var serviceCollection = new ServiceCollection();
            // 2.增加服務
            serviceCollection.AddSingleton<Startup>();
            serviceCollection.AddSingleton<ILINQElementOperatorCommand, LINQElementOperatorCommand>();
            // 3.建置
            var serviceProvider = serviceCollection.BuildServiceProvider();
            // 4.執行主服務
            serviceProvider.GetRequiredService<Startup>().Run();
        }
    }
}
