using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pat_04_00_Observer
{

    class DigitalClock : Observer
    {
        Label digitalClockLabel;
        Subject subject;
        TimeSpan time;
        public Control GetControl
        {
            get { return digitalClockLabel; }
        }
        public DigitalClock(Control parent, Subject subject)
        {
            digitalClockLabel = new Label { Parent = parent };
            this.subject = subject;
            subject.Attach(this);
        }
        public override void Update(Subject theChangedSubject)
        {
            time = (theChangedSubject as ClockTimer).GetTime();
            digitalClockLabel.BeginInvoke(new Action(Draw));
        }
        public void Draw()
        {
            digitalClockLabel.Text = time.ToString("hh\\:mm\\:ss");
        }
    }


}
