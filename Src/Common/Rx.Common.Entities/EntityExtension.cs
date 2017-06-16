/****************************************************************************************
 * 文件名：EntityExtension
 * 作者：黄泽林
 * 创始时间：2017/6/16 9:41:20
 * 创建说明：
****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Common.Entities
{
    public static class EntityExtension
    {
        public static TTarget Map<TEntity, TTarget>(this TEntity entityBase)
            where TEntity : EntityBase
        {
            return default(TTarget);
        }
    }
}
