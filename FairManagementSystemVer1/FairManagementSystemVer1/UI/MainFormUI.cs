using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using FairManagementSystemVer1;
using FairManagementSystemVer1.UI;

=======
>>>>>>> de4d30157f90d083f329ca715f108f8a22124eb7

namespace FairManagementSystemVer1
{
    public partial class MainFormUI : Form
    {
        public MainFormUI()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void visitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitorEntryToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
             VisitorEntryUI visitorEntryUi = new VisitorEntryUI();
            visitorEntryUi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeUI zoneTypeUi = new ZoneTypeUI();
            zoneTypeUi.Show();
        }

        private void zoneSpecificVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorUI zoneSpecificVisitorUi = new ZoneSpecificVisitorUI();
            zoneSpecificVisitorUi.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoneWiseVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneWiseVisitorUI zoneWiseVisitorUi = new ZoneWiseVisitorUI();
            zoneWiseVisitorUi.Show();
        }


=======
>>>>>>> de4d30157f90d083f329ca715f108f8a22124eb7
    }
}
