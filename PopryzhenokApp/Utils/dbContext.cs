using PopryzhenokApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopryzhenokApp.Utils
{
    internal class dbContext
    {
        private static PoprygModel db { get; set; }
        public static PoprygModel Db
        {
            get => db ?? (db = new PoprygModel());
        }
    }
}
