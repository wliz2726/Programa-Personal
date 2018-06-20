using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // libreria de bases de datos Access

namespace ProyectoPersonal
{
    public partial class modification_Form : Form
    {
        public modification_Form()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            if ( buscar_registro( textb_id.Text) == true)
            {
                interface_datos();
            }
            else
            {
                MessageBox.Show("El registro no existe");
                textb_id.Focus();
            }
        }


        //este es el metodo para buscar en nuestra base de datos
        private bool buscar_registro(string codigo)
        {
            //convertir cadena a numero (string a int)

            int cod = Convert.ToInt32(codigo);
            //conexion
            OleDbConnection Conexion = new OleDbConnection();
            Conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\POO\Prog_Tutorial_C#\DATA BASE\Proyecto empresa base de datos\BBDDmaestra.accdb; Persist Security Info = false";

            //cadena SQl
            string CadenaSQL = "SELECT * FROM personal WHERE ID=" + cod; //Aqui decimos que selecione * (TODOS los campos de la tabla) personal donde el ID sera igual al codigo que escribir

            //adaptador
            OleDbDataAdapter adaptador = new OleDbDataAdapter(CadenaSQL, Conexion);//esto es un adaptador osea la caja donde se estaran almacenando todos los registro que encuentre

            //dataset
            DataSet ds = new DataSet();

            //llenar el dataset
            Conexion.Open();
            adaptador.Fill(ds);
            Conexion.Close();

            //contar registros
            if (ds.Tables[0].Rows.Count == 0)
            {
                ds.Dispose(); //liveras los recursos que el data set utilizo
                return false; //esto significa que el registro no fue encontrado
            }
            else
            {

                //carga los campos en text box o caja de textos
                textb_nom.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                textb_direc.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                textb_edad.Text = ds.Tables[0].Rows[0]["edad"].ToString();

                ds.Dispose();//liveras los recursos que el data set utilizo (ds) es ul data set
                return true;// aqui significa que el registro existe
            }

        }

        //esto es un metodo para inicial 

        private void interface_inicial()
        {
            //con esta funcion desactivamos estas casoillas

            label_id.Enabled = true;
            textb_id.Enabled = true;
            button_cancel.Enabled = true;
            button_buscar.Enabled = true;

            label_nom.Enabled = false;
            label_direc.Enabled = false;
            label_edad.Enabled = false;

            textb_nom.Enabled = false;
            textb_direc.Enabled = false;
            textb_edad.Enabled = false;

            button_guardar.Enabled = false;

            textb_id.Focus();

        }

        //aqui creamos un metodo private para desactivar todas la casillas que quieras
        private void interface_datos()
        {
            //con esta funcion desactivamos estas casoillas

            label_id.Enabled = false;
            textb_id.Enabled = false;
            button_cancel.Enabled = true;
            button_buscar.Enabled = false;

            label_nom.Enabled = true;
            label_direc.Enabled = true;
            label_edad.Enabled = true;

            textb_nom.Enabled = true;
            textb_direc.Enabled = true;
            textb_edad.Enabled = true;

            button_guardar.Enabled = true;



            textb_nom.Focus();

        }

        //esto es un metodo que se llama agregar_registro y tiene parametros que corresponde a ID (codigo), nombre,direccion, edad
        private bool modificar_registro(string codigo,string nombre, string direccion, string edad)
        {
            //convertir de cadena a texto porque los  valores que eran numericos
            int eda = Convert.ToInt32(edad);
            int cod = Convert.ToInt32(codigo);

            //esto instruciones son para agragar nuevo registro
            //aqui creamos la coexion y la configuramos
            //conexion
            OleDbConnection Conexion = new OleDbConnection();
            Conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\POO\Prog_Tutorial_C#\DATA BASE\Proyecto empresa base de datos\BBDDmaestra.accdb; Persist Security Info = false";

            //instruccion SQl
            //siempre tener cuidado en el orden que se va colocando los nombre en los campos de la base de datos y colocaros en el mismo orden
            string CadenaSQL = "UPDATE personal SET ";  //actualizar  en la tabla persona nombre, direccion y edad
            CadenaSQL = CadenaSQL + " nombre    = '" + nombre + "',"; 
            CadenaSQL = CadenaSQL + " direccion = '" + direccion + "',";
            CadenaSQL = CadenaSQL + " edad      =   " + eda + " ";
            CadenaSQL = CadenaSQL + " WHERE ID  =  " + cod; //a que registro va actualizar



            //crear comando
            OleDbCommand Comando = Conexion.CreateCommand();
            Comando.CommandText = CadenaSQL;

            //ejecutar la consulta de accion
            Conexion.Open(); //abrimos la conexion
            Comando.ExecuteNonQuery();//ejecuta el comando
            Conexion.Close();//cerramos la conexion
            return true;

        }

        private void limpiar_formulario()
        {
            
            textb_nom.Clear();
            textb_direc.Clear();
            textb_edad.Clear();
        }

        private void modification_Form_Load(object sender, EventArgs e)
        {
            interface_inicial();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {

            modificar_registro(textb_id.Text, textb_nom.Text, textb_direc.Text, textb_edad.Text);
            limpiar_formulario();
            interface_inicial();
            textb_id.Clear();
            MessageBox.Show("Se ha Modificado Exitosamente");

        }

        private void textb_id_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {

                e.Handled = true;
                SendKeys.Send("{TAB}"); //envia la tecla TAB y asi para al siguiente campo
            }

            e.Handled = Validadores.numerico(e.KeyChar);
        }

        private void textb_edad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {

                e.Handled = true;
                SendKeys.Send("{TAB}"); //envia la tecla TAB y asi para al siguiente campo
            }

            e.Handled = Validadores.numerico(e.KeyChar);
        }

        private void textb_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                e.Handled = true;
                SendKeys.Send("{TAB}"); //envia la tecla TAB y asi para al siguiente campo
            }


            e.Handled = Validadores.caracteres(e.KeyChar);
        }

        private void textb_direc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                e.Handled = true;
                SendKeys.Send("{TAB}"); //envia la tecla TAB y asi para al siguiente campo
            }

            e.Handled = Validadores.caracteres_Numeros(e.KeyChar);


        }

        private void textb_edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textb_nom_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}

