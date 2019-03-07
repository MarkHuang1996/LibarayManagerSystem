using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// BorrowDetail table
    /// </summary>
    [Serializable]
    public class BorrowDetail
    {
        public int BorrowDetailId { get; set; }
        public string BorrowId { get; set; }
        public int BookId { get; set; }
        public int BorrowCount { get; set; }
        public int ReturnCount { get; set; }
        public int NonReturnCount { get; set; }
        public DateTime Expire { get; set; }

    }
}
