using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNDOWNLOADER
{
    class EffectOpenWindow
    {
        Form form;
        Timer timer = new Timer();
        double opacity = 0;
        public EffectOpenWindow(Form form)
        {
            this.form = form;
        }
        public void ShowWindow()
        {
            form.Opacity = opacity;
            timer.Interval = 1;
            timer.Tick += new EventHandler(TimerTick);
            timer.Enabled = true;
        }
        void TimerTick(object sender, EventArgs e)
        {
            opacity += 0.1;
            form.Opacity = opacity;
            if (form.Opacity == .9) timer.Stop();
        }
    }
}
