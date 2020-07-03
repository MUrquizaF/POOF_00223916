using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SourceCode.Controlador;
using SourceCode.Modelo;

namespace SourceCode.Vista
{
    public partial class UserCtrlSecurity : UserControl
    {
        private Usuario user;
        
        private delegate void MyDelegate();
        static MyDelegate Actualizaciones;
        
        private List<Usuario> listU = new List<Usuario>();
        private List<Departamento> listD = new List<Departamento>();
        private List<Registro> listR = new List<Registro>();
        private List<UsuarioReducido> listUR = new List<UsuarioReducido>();
        
        public UserCtrlSecurity(Usuario usuario)
        {
            user = usuario;
            InitializeComponent();
        }

        private void UserCtrlSecurity_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            Actualizaciones = ActualizarControles;
            Actualizaciones += ActualizarDataGrids;

            lblUser.Text = "Welcome " + user.nombre + " Role: Security";
            lblUser.TextAlign = ContentAlignment.BottomRight;
            
            title.Text = "Temperature data:";
            title.Font = new Font("Arial", 26);
            
            title2.Text = "Active working employees:";
            title2.Font = new Font("Arial", 26);
            
            btnAdd.Text = "Add";
            btnAdd.Font = new Font("Arial", 12);

            btnReturn.Text = "Return page";
            btnReturn.Font = new Font("Arial", 12);

            numericUpDown1.Minimum = 0;

            radioButton1.Checked = true;

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

            cmbId.DataSource = null;
            cmbId.DisplayMember = "User ID";
            cmbId.DataSource = listU;
        }

        private void ActualizarDataGrids()
        {
            listUR = UsuarioDAO.GetUsuariosEnEdificio();
            dataGridView1.DataSource = listUR;
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            ((FormInterface)this.ParentForm).ChangeControl(new UserCtrLogin());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool entrada;
            if (radioButton1.Checked)
                entrada = true;
            else
                entrada = false; 
            try
            {
                RegistroDAO.AgregarRegistro(new Registro(entrada, dateTimePicker1.Value, 
                    (int) numericUpDown1.Value, cmbId.Text));
                MessageBox.Show("Registration succeed!");
                Actualizaciones.Invoke();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}