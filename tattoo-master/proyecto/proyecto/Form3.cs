using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.NET;
using MySql.Data.MySqlClient;
using WindowsFormsControlLibrary1;
using System.IO;
namespace proyecto
{
    public partial class Form3 : Form
    {
        int pw;
        bool hide;
        int pwx;
        
   
        public Form3()
        {
            
            InitializeComponent();
            
            pw = panel1.Width;
            pwx = panel1.Width - 250;
            hide = false;
            explorador.Dock = DockStyle.Fill;
            explorador.Visible = true;
            WindowState = FormWindowState.Maximized;
            timer2.Enabled = true;
            
          
            timer1.Start();
            pictureBox1.Visible = false;
            DateTime hoy = DateTime.Now;
            {
                anocita.Text = hoy.ToString("yyyy");
                añohoy.Text = hoy.ToString("yyyy");
                diahoy.Text = hoy.ToString("dd");
                meshoy.Text = hoy.ToString("MM");
                
               
            }

            
            MostrarDatos();
            MostrarDatos1();
            MostrarDatos2();
            MostrarDatos3();
            MostrarDatoscita();
            MostrarDatostattoo();
           
        }

        conexion conexion_bd = new conexion();
        

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public void MostrarDatos()
        {
            //metodo para mostrar datos
            conexion_bd.consulta("SELECT id_almacen,descripcion_producto as Descripcion,tipo_producto as Tipo,cantidad as Cantidad,costo_unidad as Precio FROM almacen", "almacen");
            dataGridView1.DataSource = conexion_bd.ds.Tables["almacen"];
            dataGridView1.Columns["Descripcion"].Visible = false;
            dataGridView1.Columns["id_almacen"].Visible = false;

            
        }
        public void MostrarDatoscita()
        {
            //metodo para mostrar datos
            conexion_bd.consulta("SELECT * FROM cita", "cita");
            citasdata.DataSource = conexion_bd.ds.Tables["cita"];
            //dataGridView1.Columns["Descripcion"].Visible = false;
            //dataGridView1.Columns["id_almacen"].Visible = false;


        }
        public void MostrarDatostattoo()
        {
            //metodo para mostrar datos
            conexion_bd.consulta("SELECT * FROM tatuaje", "tatuaje");
            tatuajeDataGridView.DataSource = conexion_bd.ds.Tables["tatuaje"];
            //dataGridView1.Columns["Descripcion"].Visible = false;
            //dataGridView1.Columns["id_almacen"].Visible = false;


        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectofinDataSet4.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter2.Fill(this.proyectofinDataSet4.usuario);
// TODO: esta línea de código carga datos en la tabla 'bd.tatuaje' Puede moverla o quitarla según sea necesario.
this.tatuajeTableAdapter.Fill(this.bd.tatuaje);
            // TODO: esta línea de código carga datos en la tabla 'bd.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter1.Fill(this.bd.usuario);

            
            
           
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            explorador.Visible = true;
            inventario.Visible = false;
            horarios.Visible = false;
            contactos.Visible = false;
            PPP1.Visible = false;
            PPP2.Visible = false;
            monthCalendar1.Visible = true;
            explorador.Dock = DockStyle.Fill;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
            inventario.Visible = true;
            explorador.Visible = false;
            inventario.Dock = DockStyle.Fill;
            horarios.Visible = false;
            contactos.Visible = false;
            PPP1.Visible = false;
            PPP2.Visible = false;
            monthCalendar1.Visible = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            contactos.Visible = false;

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            horarios.Visible = true;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Dock = DockStyle.Fill;
            contactos.Visible = false;
            PPP1.Visible = false;
            PPP2.Visible = false;
            monthCalendar1.Visible = true;
            
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            contactos.Visible = true;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            contactos.Dock = DockStyle.Fill;
            PPP1.Visible = false;
            PPP2.Visible = false;
            monthCalendar1.Visible = true;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Visible = false;
            //label4.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hide)
            {
                panel1.Width = panel1.Width + 125;

                if (panel1.Width == pw)
                {
                   
                   
                    pictureBox1.Visible = true;
                    timer1.Stop();
                    hide = false;
                    this.Refresh();
                   
                }
            }
            else
            {
                panel1.Width = panel1.Width - 125;
                

                if (panel1.Width == pwx)
                {

                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
        }

        private void menusup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuinf_Paint(object sender, PaintEventArgs e)
        {

        }

        private void explorador_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate(textBox1.Text);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            webBrowser2.GoHome();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if

            ( MessageBox.Show("Seguro que desea cerrar la sesión?", "CERRAR SESIÓN", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
             Form1 f1 = new Form1();
             f1.Show();
             this.Hide();
             
            }
             
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            if
            (MessageBox.Show("Seguro que desea eliminar", "ELIMINAR PRODUCTO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
            
            
            }
        
            
            }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("dato a guardar");
        }

        private void calendar1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            
            agregar_cita f5 = new agregar_cita();
            f5.Show();
            
        }

        private void calendar2_Load(object sender, EventArgs e)
        {
            
        }
        
        private void calendar1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void calendar1_Load_2(object sender, EventArgs e)
        {
            
           
            
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            contactos.Visible = false;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            citas.Dock = DockStyle.Fill;
            PPP2.Dock = DockStyle.Fill;
            citas.Visible = true;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PPP2.Dock = DockStyle.Fill;
           
            PPP2.Visible = true;
            PPP2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contactos.Visible = false;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            PPP2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            int id = tatuajeDataGridView.RowCount;
            int contarcitas= citasdata.RowCount;
            MessageBox.Show(Convert.ToString(id));
            MessageBox.Show(Convert.ToString(contarcitas));
            string consulta_agregarcita = "INSERT INTO cita (id_cita,id_usuario,id_cliente,ano,mes,dia,hora,min,horafin,minfin,id_tatuaje) VALUES ( '" + contarcitas + "','" + tatuadorcita.SelectedValue + "','" + cicita.Text + "','" + anocita.Text + "','" + mescita.Text + "','" + diacita.Text + "','" + horaini.Text + "','" + minini.Text + "','" + horafin.Text + "','" + minfin.Text + "','" + id + "')";
                            //    //  MessageBox.Show("1");
                            //    //conexion_bd.InsertarDatos(consulta_agregarcita);

                            string consulta_agregartatuaje = "INSERT INTO tatuaje (id_tatuaje,precio,adelanto,tamano,descripcion_tatuaje,tipo,ubicacion) VALUES ('" + id + "' ,'" + precio.Text + "','" + adelanto.Text + "','" + tamano.Text + "','" + descripcion.Text + "','" + tipo.Text + "','" + ubicacion.Text + "')";
                            //    //conexion_bd.InsertarDatos(consulta_agregartatuaje);
                            //    //MessageBox.Show("2");

                            string consulta_agregarcliente = "INSERT INTO cliente (id_cliente,nombre,apellido,edad,observaciones_clinic) VALUES ( '" + cicita.Text + "','" + nombrecita.Text + "','" + apellidocita.Text + "','" + edadcita.Text + "','" + observacionescita.Text + "')";
                            //    //conexion_bd.InsertarDatos(consulta_agregarcliente);
                            //    //MessageBox.Show("3");
            
            int f;
            if (nombrecita.Text != "" && apellidocita.Text != "" && edadcita.Text != "" && cicita.Text != "" && anocita.Text != "" && mescita.Text != "" && diacita.Text != "" && horaini.Text != "" && minini.Text != "" && horafin.Text != "" && minfin.Text != "" && tamano.Text != "" && precio.Text != "" && adelanto.Text != "" && ubicacion.Text != "" && descripcion.Text != ""){
                if(Convert.ToInt32(anocita.Text) >= Convert.ToInt32(añohoy.Text) &&Convert.ToInt32(mescita.Text) >=Convert.ToInt32(meshoy.Text) && Convert.ToInt32(diacita.Text) >= Convert.ToInt32(diahoy.Text)){
                    if (Convert.ToInt32(precio.Text)> Convert.ToInt32(adelanto.Text)){
                        if((Convert.ToInt32(horaini.Text)<24 && Convert.ToInt32(horafin.Text)<24)&&(Convert.ToInt32(minini.Text)<60 && Convert.ToInt32(minfin.Text)<60)){
                            if(Convert.ToInt32(horaini.Text)==Convert.ToInt32(horafin.Text)){
                                if(Convert.ToInt32(minini.Text)<Convert.ToInt32(minfin.Text)){
                                f=1;
                                }else{
                                    f=0;
                                    MessageBox.Show("La hora de inicio de la cita no puede ser mayor a la hora final (Los minutos estan mal)");
                                }
                            }else{
                                if(Convert.ToInt32(horaini.Text)<Convert.ToInt32(horafin.Text)){
                                f=1;
                                }else{
                                    f=0;
                                    MessageBox.Show("La hora de inicio de la cita no puede ser mayor a la hora final (Las horas estan mal)");
                                }
                            }
                        }else{
                             f=0;
                             MessageBox.Show("El formato de la hora no es valido");
                        }
                    }else{
                        f=0;
                        MessageBox.Show("El adelanto no puede ser mayor al precio del tatuaje");
                    }
                }else{
                    f=0;
                    MessageBox.Show("No se puede introducir una fecha antigua");
                }
            }else { 
                f=0;
                MessageBox.Show("No puede dejar los campos (*) vacios");
            }

            if(f==1){
                int cantidadcitas= citasdata.RowCount; //seleccionar la cantidad de citas que existen (count (id_citas))
                    int j = (cantidadcitas-1); // convertir a entero
               for(int i=1;i<=j;i++){
                   conexion_bd.consulta("SELECT * FROM cita WHERE id_cita='"+i+"'", "cita");
                   conexion_bd.consulta("SELECT cliente.nombre, cita.id_cita FROM cita,cliente WHERE cliente.id_cliente = cita.id_cliente AND id_cita='"+i+"'", "cliente");
                   datos.DataSource = conexion_bd.ds.Tables["cita"];
                   datoscliente.DataSource= conexion_bd.ds.Tables["cliente"];
                   String tatuadordelacita =  datos.CurrentRow.Cells[1].Value.ToString();//seleccionar el usuario de la base de datos from citas where id_citas=i
                   String elcarnetdeidentidad= datos.CurrentRow.Cells[2].Value.ToString(); //seleccionar el carnet de identidad del cliente de la cita de la base de datos from citas where id_citas=i
                   String elnombredelcliente= datoscliente.CurrentRow.Cells[0].Value.ToString(); //seleccionar el nombre del cliente de la cita de la base de datos from CLIENTE where id_cliente = i
                   String elano= datos.CurrentRow.Cells[3].Value.ToString(); //seleccionar el año de la base de datos from citas where id_citas=i
                   String elmes=datos.CurrentRow.Cells[4].Value.ToString(); //seleccionar el mes de la base de datos from citas where id_citas=i
                   String eldia=datos.CurrentRow.Cells[5].Value.ToString(); //seleccionar el dia de la base de datos from citas where id_citas=i
                   String horaini1=datos.CurrentRow.Cells[6].Value.ToString(); //seleccionar la hora de inicio de la base de datos from citas where id_citas=i
                   String horafin1=datos.CurrentRow.Cells[8].Value.ToString(); //seleccionar la hora de inicio de la base de datos from citas where id_citas=i
                   String minini1 = datos.CurrentRow.Cells[7].Value.ToString(); //seleccionar el minuto de inicio de la base de datos from citas where id_citas=i
                   String minfin1=datos.CurrentRow.Cells[9].Value.ToString(); //seleccionar el minuto de inicio de la base de datos from citas where id_citas=i
                   //convertir todos a enteros
                       if (Convert.ToInt32(anocita.Text)==Convert.ToUInt32(elano) && Convert.ToInt32(mescita.Text)==Convert.ToUInt32(elmes) && Convert.ToInt32(diacita.Text) ==Convert.ToInt32(eldia)){
                            int HI1=((Convert.ToInt32(horaini1)*100)+Convert.ToInt32(minini1));
                            int HF1=((Convert.ToInt32(horafin1)*100)+Convert.ToInt32( minfin1));
                            int HI2=((Convert.ToInt32(horaini.Text)*100)+Convert.ToInt32(minini.Text));
                            int HF2=((Convert.ToInt32(horafin.Text)*100)+Convert.ToInt32(minfin.Text));
                           if(((HI1<HI2 && HI2<HF1)||(HI1<HF2&& HF2<HF1)||((HI2<=HI1)&&(HF1<=HF2)))&&tatuadordelacita == tatuadorcita.SelectedValue){ //NO SE SI ESE ES CODIGO PARA OBTENER EL TATUADOR DEL COMBOBOX
                                MessageBox.Show("El tatuador esta ocupado a esa hora");
                           }else{
                                if (elcarnetdeidentidad==cicita.Text){
                                    if(elnombredelcliente==nombrecita.Text && elcarnetdeidentidad==cicita.Text){

                                        //AGREGAR TATUAJE
                                        if (conexion_bd.InsertarDatos(consulta_agregartatuaje))
                                        {
                                            
                                            MessageBox.Show("TATUAJE AGREGADO");
                                        //AGREGAR CITA
                                            if (conexion_bd.InsertarDatos(consulta_agregarcita))
                                            {
                                            MessageBox.Show("CITA AGREGADA");
                                            
                                            }
                                        }else
                                        {
                                           MessageBox.Show("LO SENTIMOS PERO OCURRIO UN ERROR AL INSERTAR LOS DATOS POR FAVOR INTENTE NUEVAMENTE");
 
                                        }
                                    }else{
                                        MessageBox.Show("El carnet de identidad ya esta en uso");
                                    }
                                }else{
                                    
                                    //AGREGAR TATUAJE
                                    if (conexion_bd.InsertarDatos(consulta_agregartatuaje))
                                    {
                                            MessageBox.Show("TATUAJE AGREGADO");
                                    
                                        //AGREGAR CLIENTE
                                        if (conexion_bd.InsertarDatos(consulta_agregarcliente))
                                        {
                                            MessageBox.Show("CLIENTE AGREGADO");
                                   
                                            //AGREGAR CITA
                                            if (conexion_bd.InsertarDatos(consulta_agregarcita))
                                            {
                                            MessageBox.Show("CITA AGREGADA");
                                            nombrecita.Text = "";
                                            apellidocita.Text = "";
                                        edadcita.Text = "";
                                        cicita.Text = "";
                                        anocita.Text = "";
                                        mescita.Text = "";
                                        diacita.Text = "";
                                        horaini.Text = "";
                                        minini.Text = "";
                                        horafin.Text = "";
                                        minfin.Text = "";
                                        tamano.Text = "";
                                        precio.Text = "";
                                        adelanto.Text = "";
                                        ubicacion.Text = "";
                                        descripcion.Text = "";
                                        tipo.Text = "";
                                        observacionescita.Text = "";
                                        
                                            }
                                        
                                        }
                                    
                                    }

                                }
                           }
                       }
                    
               }
            }

            //MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=proyectofin; Uid=root; pwd=;");
            //conectar.Open();

            //MySqlCommand codigo = new MySqlCommand();
            //MySqlConnection conectados = new MySqlConnection();
            //codigo.Connection = conectar;
            //codigo.CommandText = ("SELECT * FROM cliente WHERE id_cliente ='" + cicita.Text +"'");
            //MySqlDataReader leer = codigo.ExecuteReader();
            //if (leer.Read())
            //{
            //    MessageBox.Show("El CI ingresado ya se encuentra en uso");,,
            //}
            //else
            //{
            //    MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTOS");
            //}

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PPP2.Visible = false;
            PPP2.Visible = true;
            PPP2.Dock = DockStyle.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if

         (MessageBox.Show("Seguro que desea cancelar?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                PPP1.Visible = false;
                PPP2.Visible = false;
                monthCalendar1.Visible = true;
                explorador.Visible = false;
                inventario.Visible = false;
                horarios.Visible = false;
                contactos.Visible = false;
                
                nombrecita.Text = ""; 
                apellidocita.Text = ""; 
                edadcita.Text = "" ;
                cicita.Text = ""; 
                anocita.Text = ""; 
                mescita.Text = ""; 
                diacita.Text = ""; 
                horaini.Text = "" ;
                minini.Text = "" ;
                horafin.Text = "" ;
                minfin.Text = "" ;
                tamano.Text = "" ;
                precio.Text = "" ;
                adelanto.Text = "" ;
                ubicacion.Text = "" ;
                descripcion.Text = "";
                tipo.Text = "";
                observacionescita.Text = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            agreg_inventario.Visible = false;
            inventario.Visible = true;
            string consulta_agregar = "INSERT INTO almacen VALUES ('{0}','" + descripcion_almacen.Text + "','" + tipo_almacen.Text + "','" + cantidad_almacen.Text + "','" + precio_almacen.Text + "')";
            if (conexion_bd.InsertarDatos(consulta_agregar))
            {
                MessageBox.Show("Datos insertados");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Datos no insertados");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            inventario.Visible = false;
            agreg_inventario.Visible = true;
            agreg_inventario.Dock = DockStyle.Fill;
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if

        (MessageBox.Show("Seguro que desea cancelar?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                agreg_inventario.Visible = false;
                inventario.Visible = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if

       (MessageBox.Show("Seguro que desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {


                if (conexion_bd.EliminarDatos("almacen", "id_almacen= " + id_pro.Text))
                {
                    MessageBox.Show("Datos eliminados");
                    MostrarDatos();
                }
                else
                {
                    MessageBox.Show("Datos no eliminado");
                }
            }
        }
        public void MostrarCombo()
        {
            //metodo para obtener los datos de ciudad en el combo
            //conexion_bd.consulta("SELECT * FROM usuario", "usuario");
            //tatuadorcita.DataSource = conexion_bd.ds.Tables["usuario"];
            //tatuadorcita.DisplayMember = "nickname";
            //tatuadorcita.ValueMember = "id_usuario";
        }
        

        private void calendar1_Load_3(object sender, EventArgs e)
        {
            
            

        }

        private void anocita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void mescita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void diacita_TextChanged(object sender, EventArgs e)
        {

        }

        private void diacita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void horacita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void minutocita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void cicliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void nombrecita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void apellidocita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //forma para obtener los registros en los campos al dar click sobre un registro
            DataGridViewRow registro = dataGridView1.Rows[e.RowIndex];
            descripcion_producto.Text = registro.Cells["Descripcion"].Value.ToString();
            precio_unidad.Text = registro.Cells["Precio"].Value.ToString();
            cantidad_producto.Text = registro.Cells["cantidad"].Value.ToString();
            id_pro.Text = registro.Cells["id_almacen"].Value.ToString();
           
            
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //boton para actualizar datos de la tabla almacen
            string actualizar = "descripcion_producto='" + descripcion_producto.Text + "', costo_unidad= '" + precio_unidad.Text + "',cantidad='" + cantidad_producto.Text + "'";
            if (conexion_bd.ActualizarDatos("almacen", actualizar, "id_almacen=" + id_pro.Text))
            {
                MessageBox.Show("Datos actualizados");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Datos no actualizados");

            }
        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //boton para actualizar datos de contactos(USUARIOS)
                string actualizar = "nombreusu='" +nom.Text + "', apellidousu= '" + app.Text + "',direccionusu='" + dirc.Text + "', telefonousu= '" + telef.Text + "'";
                if (conexion_bd.ActualizarDatos("usuario", actualizar, "id_usuario=" + idd.Text))
                {
                    MessageBox.Show("Datos actualizados");
                 
                    MostrarDatos1();
                }
                else
                {
                    MessageBox.Show("Datos no actualizados");

                }
            }
        }
        public void MostrarDatos1()
        {
            //metodo para mostrar datos(USUARIO)
            conexion_bd.consulta("SELECT id_usuario,password,nombreusu as Nombre,apellidousu as Apellido,direccionusu as Direccion,telefonousu as Telefono,nickname FROM usuario", "usuario");
            dataGridView4.DataSource = conexion_bd.ds.Tables["usuario"];
            dataGridView4.Columns["id_usuario"].Visible = false;
            dataGridView4.Columns["password"].Visible = false;
            dataGridView4.Columns["nickname"].Visible = false;

        }
        public void MostrarDatos2()
        {
            //metodo para mostrar datos(CLIENTE)
            conexion_bd.consulta("SELECT id_cliente,nombre as Nombre,apellido as Apellido,edad,observaciones_clinic FROM cliente", "cliente");
            dataGridView5.DataSource = conexion_bd.ds.Tables["cliente"];
            dataGridView5.Columns["id_cliente"].Visible = false;
            dataGridView5.Columns["edad"].Visible = false;
            dataGridView5.Columns["observaciones_clinic"].Visible = false;

        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //forma para obtener los registros en los campos al dar click sobre un registro
            DataGridViewRow registro = dataGridView4.Rows[e.RowIndex];
            nom.Text = registro.Cells["Nombre"].Value.ToString();
            app.Text = registro.Cells["Apellido"].Value.ToString();
            dirc.Text = registro.Cells["Direccion"].Value.ToString();
            telef.Text = registro.Cells["Telefono"].Value.ToString();
            idd.Text = registro.Cells["id_usuario"].Value.ToString();
            label8.Visible = true;
            dirc.Visible = true;
            tel.Visible = true;
            telef.Visible = true;
            edd.Visible = false;
            eddt.Visible = false;
            b1.Visible = true;
            b2.Visible = false;
            
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //forma para obtener los registros en los campos al dar click sobre un registro
            DataGridViewRow registro = dataGridView5.Rows[e.RowIndex];
            nom.Text = registro.Cells["Nombre"].Value.ToString();
            app.Text = registro.Cells["Apellido"].Value.ToString();
            idd.Text = registro.Cells["id_cliente"].Value.ToString();
            eddt.Text = registro.Cells["edad"].Value.ToString();
            dirc.Visible=false;
            label8.Visible = false;
            tel.Visible = false;
            telef.Visible = false;
            edd.Visible = true;
            eddt.Visible = true;
            b1.Visible = false;
            b2.Visible = true;

        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //boton para actualizar datos
                string actualizar = "nombre='" + nom.Text + "', apellido= '" + app.Text + "'";
                if (conexion_bd.ActualizarDatos("cliente", actualizar, "id_cliente=" + idd.Text))
                {
                    MessageBox.Show("Datos actualizados");

                    MostrarDatos2();
                }
                else
                {
                    MessageBox.Show("Datos no actualizados");

                }
            }
        }

        private void nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void app_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void telef_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void eddt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void tamano_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void adelanto_TextChanged(object sender, EventArgs e)
        {

        }

        private void adelanto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
          
            
            
        }

        private void nombrecita_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void MostrarDatos3()
        {
            //metodo para mostrar datos
            //conexion_bd.consulta("SELECT `cita`.*, `tatuaje`.*, `usuario`.* FROM `usuario` LEFT JOIN `cita` ON `cita`.`id_usuario` = `usuario`.`id_usuario` LEFT JOIN `tatuaje` ON `cita`.`id_tatuaje` = `tatuaje`.`id_tatuaje`", "cita");
            //citasdata.DataSource = conexion_bd.ds.Tables["cita"];
            //citasdata.Columns["id_cita"].Visible = false;
            //citasdata.Columns["id_tatuaje"].Visible = false;
            //citasdata.Columns["id_usuario"].Visible = false;
            //citasdata.Columns["id_tatuaje"].Visible = false;
            //citasdata.Columns["id_tatuaje1"].Visible = false;
            //citasdata.Columns["password"].Visible = false;
            
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            PPP1.Visible=true;
            PPP2.Visible=true;
            monthCalendar1.Visible = false;
            int ta=monthCalendar1.SelectionRange.Start.Year;
            int tm = monthCalendar1.SelectionRange.Start.Month;
            int td = monthCalendar1.SelectionRange.Start.Day; 
            if (tm < 10)
            {
                String ttm=("0" +tm.ToString());
               mescita.Text = ttm;
            }else
            {
                mescita.Text =tm.ToString();
            }
            if (td < 10)
            {
                String ttd = ("0" + td.ToString());
               diacita.Text = ttd;
            }else
            {
                diacita.Text =td.ToString();
            }
            anocita.Text = ta.ToString();
           
            
        }

        private void anocita_TextChanged(object sender, EventArgs e)
        {

        }

        private void tacita_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(tatuadorcita.ValueMember);
        }
        public void MostrarCombo1()
        {
            //metodo para obtener los datos de ciudad en el combo
            conexion_bd.consulta("SELECT * FROM usuario", "usuario");
            tatuadorcita.DataSource = conexion_bd.ds.Tables["usuario"];
            tatuadorcita.DisplayMember = "nickname";
           String vartat = tatuadorcita.ValueMember = "id_usuario";

           MessageBox.Show("dato: " + vartat);

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void nombrecita_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void apellidocita_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void edadcita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void cicita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void horaini_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void minini_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void horafin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void minfin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void ubicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton3_Click_2(object sender, EventArgs e)
        {
            panel20.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       
    }
}
