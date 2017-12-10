using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void citaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.citaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.bd.usuario);
            // TODO: esta línea de código carga datos en la tabla 'bd.cita' Puede moverla o quitarla según sea necesario.
            this.citaTableAdapter.Fill(this.bd.cita);

        }

        private void id_usuarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
