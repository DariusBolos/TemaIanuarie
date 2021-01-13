using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaIanuarie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnHome.BackColor = ColorTranslator.FromHtml("#fafafa");
            this.btnClose.BackColor = ColorTranslator.FromHtml("#fafafa");

            StyleButtons(this.flowPanelMaster);
        }

        public void StyleButtons(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    btn.BackColor = ColorTranslator.FromHtml("#fafafa");
                    btn.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#fcf4f4");
                    btn.Width = this.flowPanelMaster.Width;
                    btn.Height = this.flowPanelMaster.Height / this.flowPanelMaster.Controls.Count;
                }
        }
    }
}
