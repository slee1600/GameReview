using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview.Interfaces
{
    public interface ReviewInterface
    {
        public virtual bool AddNewReview(string name)
        {
            return false;
        }
    }
}
