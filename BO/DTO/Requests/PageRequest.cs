using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BO.DTO
{
    public class PageRequest
    {
        /// <summary>
        /// Current Page
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// Limit entities on one page
        /// </summary>
        public int PageSize { get; set; }

        public PageRequest()
        {
            Page = 1;
            PageSize = 10;
        }

        public PageRequest(int page, int pageSize)
        {
            this.Page = page;
            this.PageSize = pageSize;
        }
    }
}