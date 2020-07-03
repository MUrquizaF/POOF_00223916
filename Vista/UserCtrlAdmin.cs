using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SourceCode.Controlador;
using SourceCode.Modelo;

namespace SourceCode.Vista
{
    public partial class UserCtrlAdmin : UserControl
    {
        private Usuario user;
        
        private delegate void MyDelegate();
        static MyDelegate Actualizaciones;
        
        private List<Usuario> listU = new List<Usuario>();
        private List<Departamento> listD = new List<Departamento>();
        private List<Registro> listR = new List<Registro>();
        private List<UsuarioReducido> listUR = new List<UsuarioReducido>();
        
        public UserCtrlAdmin(Usuario usuario)
        {
            user = usuario;
            InitializeComponent();
        }

        private void UserCtrlAdmin_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            
            Actualizaciones = ActualizarControles;
            Actualizaciones += ActualizarDataGrids;
            
            tabPage1.Text = "User's Maintenance";

            tabPage2.Text = "Info";

            lblUser.Text = "Welcome " + user.nombre + " Role: Admin";
            lblUser.TextAlign = ContentAlignment.BottomRight;
            lblUser.Font = new Font("Arial", 12);
            
            lvlTop.Font = new Font("Arial", 14);
            
            lblfreq.Font = new Font("Arial", 14);

            title.Text = "Add User";
            title.Font = new Font("Arial", 26);

            title2.Text = "Remove User";
            title2.Font = new Font("Arial", 26);

            titleReg.Text = "Public Registers";
            titleReg.Font = new Font("Arial", 14);

            titleTop.Text = "Most crowded Department:";
            titleTop.Font = new Font("Arial", 14);
            
            titlebuild.Text = "Active employees:";
            titlebuild.Font = new Font("Arial", 24);

            btnReturn.Text = "Return page";
            btnReturn.Font = new Font("Arial", 10);
            
            btnAdd.Text = "Add";
            btnAdd.Font = new Font("Arial", 10);

            btnDel.Text = "Remove";
            btnDel.Font = new Font("Arial", 10);

            btnClear.Text = "Clean";
            btnClear.Font = new Font("Arial", 6);
            
            foreach (Control ctrl in tableLayoutPanel2.Controls)
            {
                if (ctrl.Tag == "add")
                {
                    ctrl.Font = new Font("Arial", 10);
                }
            }
            
            Actualizaciones.Invoke();
        }

        private void ActualizarControles()
        {
            listU = UsuarioDAO.getList();
            listD = DepartamentoDAO.getList();
            listR = RegistroDAO.getList();

            cmbD.DataSource = null;
            cmbD.DisplayMember = "name";
            cmbD.ValueMember = "Department ID";
            cmbD.DataSource = listD;

            cmbId.DataSource = null;
            cmbId.DisplayMember = "User ID";
            cmbId.DataSource = listU;
        }

        private void ActualizarDataGrids()
        {
            listR = RegistroDAO.getList();
            listUR = UsuarioDAO.GetUsuariosEnEdificio();
            Frequencia f = DepartamentoDAO.BuscarDepartamentoConcurrido();

            dataRegist.DataSource = listR;
            dataBuilding.DataSource = listUR;
            lblfreq.Text = f.frecuencia.ToString();
            lvlTop.Text = f.nombre;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(txtID.Text, txtPwd.Text, txtName.Text, txtSurn.Text, 
                Convert.ToInt32(txtDui.Text), dateTimePicker1.Value, (int) cmbD.SelectedValue);
            try
            {
                UsuarioDAO.AgregarUsuario(u);
                MessageBox.Show("User registration succeed!");
                btnClear_Click(sender, e);
                Actualizaciones.Invoke();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            foreach (Control ctrl in tableLayoutPanel2.Controls)
            {
                if (ctrl is TextBox)
                {
                    txt = (TextBox) ctrl;
                    txt.Clear();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDAO.borrarUsuario(cmbId.Text);
                MessageBox.Show("User removal succeeed!");
                Actualizaciones.Invoke();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ((FormInterface)this.ParentForm).ChangeControl(new UserCtrLogin());
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}