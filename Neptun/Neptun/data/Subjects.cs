using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptun.data
{
    [Table("Subjects")]
    public class Subjects
    {
        [PrimaryKey]
        public int TargyId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public int onclass { get; set; }
    }
}
