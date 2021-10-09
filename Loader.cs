using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIVERSALSOFTWARE
{
    class Loader
    {
        public string FileName { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }

        public Loader()
        {

        }

        public Loader(string FileName, string Text, string Url)
        {
            this.FileName = FileName;
            this.Text = Text;
            this.Url = Url;
        }

        public void Download(MainWindow Main)
        {
        }
    }
}
