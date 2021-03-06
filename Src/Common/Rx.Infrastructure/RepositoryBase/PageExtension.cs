﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Rx.Common.Entities;

namespace Rx.Infrastructure.RepositoryBase
{
    /// <summary>
    /// 分页扩展工具类
    /// </summary>
    public static class PageExtension
    {
        #region # 分页扩展方法 —— static IEnumerable<T> ToPage<T>(this IEnumerable<T> enumerable...
        /// <summary>
        /// 分页扩展方法
        /// </summary>
        /// <typeparam name="T">领域实体</typeparam>
        /// <param name="enumerable">集合对象</param>
        /// <param name="predicate">查询条件</param>
        /// <param name="pageIndex">页索引</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="rowCount">总记录条数</param>
        /// <param name="pageCount">总页数</param>
        /// <returns>对象集合</returns>
        public static IEnumerable<T> ToPage<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate, int pageIndex, int pageSize, out int rowCount, out int pageCount)
            where T : PlainEntity
        {
            T[] list = enumerable.Where(predicate).ToArray();
            rowCount = list.Length;
            pageCount = (int)Math.Ceiling(rowCount * 1.0 / pageSize);
            return list.OrderByDescending(x => x.AddedTime).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
        #endregion

        #region # 分页扩展方法 —— static IQueryable<T> ToPage<T>(this IQueryable<T> queryable...
        /// <summary>
        /// 分页扩展方法
        /// </summary>
        /// <typeparam name="T">领域实体</typeparam>
        /// <param name="queryable">集合对象</param>
        /// <param name="predicate">查询条件</param>
        /// <param name="pageIndex">页索引</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="rowCount">总记录条数</param>
        /// <param name="pageCount">总页数</param>
        /// <returns>对象集合</returns>
        public static IQueryable<T> ToPage<T>(this IQueryable<T> queryable, Expression<Func<T, bool>> predicate, int pageIndex, int pageSize, out int rowCount, out int pageCount)
            where T : PlainEntity
        {
            IQueryable<T> list = queryable.Where(predicate);
            rowCount = list.Count();
            pageCount = (int)Math.Ceiling(rowCount * 1.0 / pageSize);
            return list.OrderByDescending(x => x.AddedTime).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
        #endregion
    }
}
