using System;
using System.IO;//I/O读写
using Microsoft.Extensions.Configuration;

namespace Option_mode
{
    class Program
    {
        static void Main(string[] args)
        {
            // json 文件路径 这里是应用程序执行文件的所在目录  可以自己设置路径
            string _path = Directory.GetCurrentDirectory();
            var builder = new ConfigurationBuilder().SetBasePath(_path).AddJsonFile("Position.json");
            var configurationRoot = builder.Build();

            var PositionSection = configurationRoot.GetSection("Position"); //获取 Position 对象
            var Position_TitleSection = PositionSection.GetSection("Title");//通过 Position 对象获取Title对象
            var Position_NameSection = PositionSection.GetSection("Name");//通过 Position 对象获取Name对象

            Console.WriteLine($"Title: {Position_TitleSection.Value}");
            Console.WriteLine($"Name: {Position_NameSection.Value}");

            var builder1 = new ConfigurationBuilder();
            //打开 Json文件 未定义 Path  默认访问执行文件所在目录
            builder1.AddJsonFile("Position.json");
            //获取Json数据
            var configuration = builder1.Build();

            //将 数据 注入DI
            DI dI = new DI(configuration);
            dI.OnGet();
            Console.Read();
        }
    }
}
