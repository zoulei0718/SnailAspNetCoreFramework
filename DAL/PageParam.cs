﻿using CommonAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web
{
    public class PageParam<TEntity,TKey> where TEntity:IBaseEntity
    {
        public int PageSize { set; get; }
        public int PageIndex { set; get; }
        public Func<TEntity,TKey> OrderBy { get; set; }
        public Sort Sort { get; set; }
    }
}
