using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace Option_mode
{

    /// <summary>
    /// 依赖注入选项模式
    /// </summary>
    public class DI
    {
        /// <summary>
        /// 创建依赖
        /// </summary>
        private readonly IConfiguration Configuration;

        /// <summary>
        /// 依赖注入（控制反转）所需要的对外方法
        /// </summary>
        /// <param name="configuration">外部提供的依赖</param>
        public DI(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void OnGet()
        {
            var positionOptions = new PositionOptions();
            Configuration.GetSection(PositionOptions.Position).Bind(positionOptions);

            Console.WriteLine($"Title: {positionOptions.Title} \n" +
                           $"Name: {positionOptions.Name}");
        }
    }
}
