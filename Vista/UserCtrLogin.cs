using System;
using System.Drawing;
using System.Windows.Forms;
using SourceCode.Controlador;
using SourceCode.Modelo;
using SourceCode.Patrón;
using SourceCode.Patrón.Estrategia;

namespace SourceCode.Vista
{
    public partial class UserCtrLogin : UserControl
    {
        public UserCtrLogin()
        {
            InitializeComponent();
        }

        private void UserCtrLogin_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            title.Text = "Log In";
            title.TextAlign = ContentAlignment.TopCenter;
            title.Font = new Font("Arial", 30);
            
            label1.Text = "User:";
            label1.Font = new Font("Arial", 16);

            label2.Text = "Password";
            label2.Font = new Font("Arial", 16);

            btnLogin.Text = "Access";
            btnLogin.Font = new Font("Arial", 16);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ProxyAcceso.ISujeto proxy = new ProxyAcceso.ProxySeguro();
            if (proxy.PeticionAcceso(txtUser.Text, txtPwd.Text))
            {
                Usuario u = new Usuario();
                u = UsuarioDAO.GetSingleUsuario(txtUser.Text);

                string nombreDepartamento = DepartamentoDAO.GetNombreDepartamento(u.idDepartamento);

                IDepartamento miDepartamento;
                
                miDepartamento = new CAdministracion();
                if (miDepartamento.PerteneceADepartamento(nombreDepartamento))
                {
                    ((FormInterface)this.ParentForm).ChangeControl(new UserCtrlAdmin(u));
                }
                
                miDepartamento = new CVigilancia();
                if (miDepartamento.PerteneceADepartamento(nombreDepartamento))
                {
                    ((FormInterface)this.ParentForm).ChangeControl(new UserCtrlSecurity(u));
                }
                
                miDepartamento = new CPersonal();
                if (miDepartamento.PerteneceADepartamento(nombreDepartamento))
                {
                    ((FormInterface)this.ParentForm).ChangeControl(new UserCtrPersonel(u));
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password, try again!");
            }
        }


        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}