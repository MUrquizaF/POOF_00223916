using System;
using System.Windows.Forms;

namespace SourceCode.Vista
{
    public partial class FormInterface : Form
    {
        private UserControl current = null;
        
        public FormInterface()
        {
            InitializeComponent();
            current = userCtrLogin1;
            DoubleBuffered = true;
        }
        
        public void ChangeControl(UserControl newControl) 
        {
            try
            {
                if (newControl == null)
                {
                    throw new NullReferenceException();
                }

                if (current != null)
                {
                    MainPanel.Controls.Remove(current);
                }

                current = newControl;
                MainPanel.Controls.Add(current);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void userCtrLogin1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}