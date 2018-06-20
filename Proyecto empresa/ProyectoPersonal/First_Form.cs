using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPersonal
{
    public partial class First_Form : Form, Interface_show
    {
        public First_Form()
        {
            InitializeComponent();
        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //agragar nuevos registros
            //debemos instansiarlo para que el formulario de agregar siempre se instancia con new
            //add_form es un nombre y new_add_form es el formulario que estamos llamando 

            new_add_Form add_form = new new_add_Form();
            add_form.Show(this);


      

        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Modificacion de registro

            modification_Form mod_form = new modification_Form();
            mod_form.Show(this);

        }

        private void eliminacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Eliminacion de registros

            Delete_Form del_form = new Delete_Form();
            del_form.Show(this);
        }

        private void listarRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Listar registros
            list_registry_Form list_form = new list_registry_Form();
            list_form.Show(this);
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //salir del sitema
            this.Close();

        }

        void Interface_show.mostrar_new_add(bool visible)
        {

        }

    }
}
