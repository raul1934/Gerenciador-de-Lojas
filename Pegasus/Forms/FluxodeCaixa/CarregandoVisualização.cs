using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Controllers.FluxodeCaixa
{
    
    public partial class CarregandoVisualização : Form
    {
        public Action Worker { get; set; }
        public CarregandoVisualização(Action action)
        {
            InitializeComponent();

            if(action == null)
            {
                throw new ArgumentNullException();
            }
            Worker = action;

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}

