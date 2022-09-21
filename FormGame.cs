using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();

            // buttons
            buttonClose.Click += ButtonClose_Click;
            buttonSettings.Click += ButtonSettings_Click;
            buttonStart.Click += ButtonStart_Click;
        }

        #region button Events
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
