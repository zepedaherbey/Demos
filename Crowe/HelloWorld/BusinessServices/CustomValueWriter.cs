using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface ICustomValueWriter
    {
        void WriteItem(string item);
    }

    public class CustomValueDbWriter : ICustomValueWriter
    {
        public void WriteItem(string item)
        {
            //write item to database
        }
    }

    public class CustomValueFileWriter : ICustomValueWriter
    {
        public void WriteItem(string item)
        {
            //write item to file
        }
    }
}
