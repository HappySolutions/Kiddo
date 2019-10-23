using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kiddo1.Models
{
    public class Blocks
    {
        [PrimaryKey, AutoIncrement]
        public int BlockId { get; set; }

        [NotNull]
        public IList<BList> BlockList { get; set; }
    }
    public class BList
    {
        [PrimaryKey, AutoIncrement]
        public int ListId { get; set; }

        [NotNull]
        public string title { get; set; }

        [NotNull]
        public DateTime schedualed { get; set; }

        [NotNull]
        public bool isdone { get; set; }

    }
}
