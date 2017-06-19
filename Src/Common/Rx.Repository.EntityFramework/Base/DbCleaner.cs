﻿using System.Runtime.Remoting.Messaging;
using Rx.Infrastructure.RepositoryBase;
using Rx.Repository.EntityFramework.Base;

namespace Rx.Repository.EntityFramework
{
    /// <summary>
    /// 数据库清理者实现
    /// </summary>
    public class DbCleaner : IDbCleaner
    {
        /// <summary>
        /// 清理
        /// </summary>
        public void Clean()
        {
            if (BaseDbSession.CommandInstance != null)
            {
                BaseDbSession.CommandInstance.Dispose();
            }
            if (BaseDbSession.QueryInstance != null)
            {
                BaseDbSession.QueryInstance.Dispose();
            }
            CallContext.FreeNamedDataSlot(BaseDbSession.CommandInstanceKey);
            CallContext.FreeNamedDataSlot(BaseDbSession.QueryInstanceKey);
        }
    }
}
