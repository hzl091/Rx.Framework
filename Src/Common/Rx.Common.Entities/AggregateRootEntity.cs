﻿using System;
using Rx.Common.Entities;

namespace Rx.Common.Entities
{
    /// <summary>
    /// 聚合根实体基类
    /// </summary>
    [Serializable]
    public abstract class AggregateRootEntity : PlainEntity, INumerable, INameable, ISearchable
    {
        #region # 构造器
        /// <summary>
        /// 构造器
        /// </summary>
        protected AggregateRootEntity()
        {
            this.SavedTime = DateTime.Now;
            this.Deleted = false;
            this.DeletedTime = null;
        }
        #endregion

        #region # 属性

        #region 编号 —— string Number
        /// <summary>
        /// 编号
        /// </summary>
        public string Number { get; set; }
        #endregion

        #region 名称 —— string Name
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region 关键字 —— string Keywords
        /// <summary>
        /// 关键字
        /// </summary>
        public string Keywords { get; set; }
        #endregion

        #region 保存时间 —— DateTime SavedTime
        /// <summary>
        /// 保存时间
        /// </summary>
        public DateTime SavedTime { get; set; }
        #endregion

        #region 逻辑删除标记 —— bool Deleted
        /// <summary>
        /// 逻辑删除标记
        /// </summary>
        public bool Deleted { get; set; }
        #endregion

        #region 删除时间 —— DateTime? DeletedTime
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeletedTime { get; set; }
        #endregion

        #region 创建人账号 —— string CreatorAccount
        /// <summary>
        /// 创建人账号
        /// </summary>
        public string CreatorAccount { get; set; }
        #endregion

        #region 操作人账号 —— string OperatorAccount
        /// <summary>
        /// 操作人账号
        /// </summary>
        public string OperatorAccount { get; set; }
        #endregion

        #endregion

        #region # 方法

        #region 设置关键字 —— void SetKeywords(string keywords)
        /// <summary>
        /// 设置关键字
        /// </summary>
        /// <param name="keywords">关键字</param>
        public void SetKeywords(string keywords)
        {
            this.Keywords = keywords;
        }
        #endregion

        #endregion
    }
}
