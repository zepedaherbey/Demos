using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface IItemRemoval
    {
        void Remove(int id);
    }

    public class ItemRemoval : IItemRemoval
    {
        public void Remove(int id)
        {
            //Removal item logic here
        }
    }
}
