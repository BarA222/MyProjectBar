using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    /// <summary>
    /// This class is used to throw a messages when secces or failed actions
    /// </summary>
    public class Message
    {
        public bool IsSuccess { get; set; }
        public string Content { get; set; }

    }
}
