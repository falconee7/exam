using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.models
{
    internal class DbConnection
    {
        public static examEntities Examentities { get; } = new examEntities();
    }
}
