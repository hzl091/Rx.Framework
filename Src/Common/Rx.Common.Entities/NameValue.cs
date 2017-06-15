/****************************************************************************************
 * 文件名：NameValue
 * 作者：黄泽林
 * 创始时间：2017/6/15 16:24:54
 * 创建说明：
****************************************************************************************/

namespace Rx.Common.Entities
{
    /// <summary>
    /// 名称值对象
    /// </summary>
    public class NameValue<T>
    {
        public NameValue()
        {
        }

        public NameValue(string name, T value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public T Value { get; set; }
    }
}
