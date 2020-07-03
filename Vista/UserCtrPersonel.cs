using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SourceCode.Controlador;
using SourceCode.Modelo;

namespace SourceCode.Vista
{
    public partial class UserCtrPersonel : UserControl
    {
        private Usuario user;

        public UserCtrPersonel(Usuario usuario)
        {
            user = usuario;
            InitializeComponent();
        }

        private void UserCtrPersonel_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            lblUser.Text = "Welcome " + user.nombre + " Role: Employee";
            lblUser.TextAlign = ContentAlignment.BottomRight;
            
            title.Text = "Check-In History:";
            title.Font = new Font("Arial", 24);
            
            btnReturn.Text = "Return Page";
            btnReturn.Font = new Font("Arial", 12);
            
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            List<Registro> listR = RegistroDAO.getListSingleUser(user.idUsuario);
            dataGridView1.DataSource = listR;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ((FormInterface)this.ParentForm).ChangeControl(new UserCtrLogin());
        }
    }
}