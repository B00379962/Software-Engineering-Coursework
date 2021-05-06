using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataAccessManager
{
    public abstract class ReadFile
    {

        public abstract object Read();

        public virtual string Finish()
        {
            string Text = "Finished Reading Selected File";
            return Text;
        }



        // The template method
        public void Create()
        {

                Read();
                Finish();

        }
    }
}
