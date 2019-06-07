using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace AbstractFactoryPattern.Database
{
    public abstract class Database
    {
        /// <summary>
        /// Database connection
        /// </summary>
        public virtual DbConnection Connection { get; set; }

        /// <summary>
        /// Command
        /// </summary>
        public virtual DbCommand Command { get; set; }
    }
}
