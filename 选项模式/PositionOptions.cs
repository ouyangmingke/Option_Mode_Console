using System;
using System.Collections.Generic;
using System.Text;

namespace Option_mode
{
    /// <summary>
    /// 相当于Model层 数据访问
    /// </summary>
    public class PositionOptions
    {
        /// <summary>
        /// 这是静态字段,硬编码  这个字段的用途相当于密码 因为Json 是对象 + 数组结构
        /// 当前字段的属性 是Json文件是起始字段
        /// </summary>
        public const string Position = "Position";

        public string Title { get; set; }
        public string Name { get; set; }

    }
}
