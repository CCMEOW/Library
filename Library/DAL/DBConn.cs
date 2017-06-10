using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace Library.DAL
{
    public class DBConn
    {
        public ModelDB createDbContext()
        {
            ModelDB db = (ModelDB)CallContext.GetData("MssqlDBContext");
            if (null == db)
            {
                db = new ModelDB();
                CallContext.SetData("ModelDB", db);
            }
            return db;
        }
    }
    }
}