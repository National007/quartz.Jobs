using SqlSugar;
using System;

namespace quartz.Jobs.Core.Business.Manager
{
    public class BaseManager
    {
        public SqlSugarClient db
        {
            get
            {
                return new DbManager().db;
            }
        }
    }
}
