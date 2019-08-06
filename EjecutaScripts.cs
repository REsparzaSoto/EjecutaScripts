using EjecutaSps;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EjecutaScripts
{
    public partial class EjecutaScripts : Form
    {
        private Credenciales conexion;

        private EjecutaScript ejecuciones;

        private Argumentos argumentos;

        public EjecutaScripts()
        {
            InitializeComponent();
        }

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            conexion = new Credenciales();
            ejecuciones = new EjecutaScript();
        }

        private void lv_Scripts_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lv_Scripts_DragDrop(object sender, DragEventArgs e)
        {
            AgregarArchivos(e);
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            AgregarCredenciales();

            if (ValidarCredenciales())
            {
                if (ValidarItems())
                {
                    EjecutarScripts();
                }
                else
                {
                    MessageBox.Show(Literales.ValidarRenglones, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(Literales.ValidarCredenciales, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lv_Scripts.Items.Clear();
        }
        #endregion

        #region Agregar
        private void AgregarArchivos(DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, true);

            if (!(archivos is null))
            {
                foreach (string archivo in archivos)
                {
                    if (ValidarExtension(archivo, Literales.ExtensionSql))
                    {
                        lv_Scripts.Items.Add(archivo);
                    }
                }
            }
            else
            {
                MessageBox.Show(Literales.ValidarDragDrop, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarCredenciales()
        {
            conexion.Server = tb_Server.Text;
            conexion.DB = tb_DB.Text;
            conexion.User = tb_User.Text;
            conexion.Password = tb_Password.Text;
        }
        #endregion

        #region Validaciones
        private bool ValidarExtension(string archivo, string extension)
        {
            return string.Equals(Path.GetExtension(archivo), extension, StringComparison.OrdinalIgnoreCase);
        }

        private bool ValidarCredenciales()
        {
            return !string.IsNullOrEmpty(conexion.Server) && !string.IsNullOrEmpty(conexion.DB) && !string.IsNullOrEmpty(conexion.User) && !string.IsNullOrEmpty(conexion.Password);
        }

        private bool ValidarItems()
        {
            return lv_Scripts.Items.Count > 0;
        }
        #endregion

        #region Ejecuciones
        private void EjecutarScripts()
        {
            foreach (ListViewItem item in lv_Scripts.Items)
            {
                argumentos = new Argumentos();

                //Documentacion SqlCmd https://docs.microsoft.com/en-us/sql/tools/sqlcmd-utility?view=sql-server-2017
                argumentos.AgregarArgumento("-S", conexion.Server);     //Argumento del servidor
                argumentos.AgregarArgumento("-d", conexion.DB);         //Argumento de la base de datos
                argumentos.AgregarArgumento("-U", conexion.User);       //Argumento del usuario
                argumentos.AgregarArgumento("-P", conexion.Password);   //Argumento de la constraseña
                argumentos.AgregarArgumento("-b");                      //Argumento para terminar ejecución en caso de error
                argumentos.AgregarArgumento("-i", item.Text);           //Argumento de archivo de entrada (script)
                argumentos.AgregarArgumento("-o", Path.Combine(Application.StartupPath, Path.ChangeExtension(Path.GetFileName(item.Text), Literales.ExtensionLog)));//Argumento de archivo de salida (log)

                ejecuciones.EjecutaSqlCmd(argumentos.Cadena);

                if (ejecuciones.Error == 0)
                {
                    item.ForeColor = Color.Green;
                }
                else
                {
                    item.ForeColor = Color.Red;
                }
            }

            MessageBox.Show(Literales.EjecucionTerminada, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
