using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadHardwareSim
{
    public partial class WaitingDialog : Form
    {
        public Action<object> ActionWorker { get; set; }
        public object DeviceChoice;

        public WaitingDialog()
        {
            InitializeComponent();
        }

        public WaitingDialog(Action<object> actionWorker, DeviceChoiceEnum deviceChoice)
        {
            InitializeComponent();
            if (actionWorker == null)
                throw new ArgumentException();
            ActionWorker = actionWorker;
            DeviceChoice = deviceChoice;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(ActionWorker, DeviceChoice).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
