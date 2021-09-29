using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerYPol
{
    public partial class Form1 : Form
    {
        Multimedia a;
        Pelicula b;
        PeliculaDocumental c;
        tiempo duracion;
        Validacion v = new Validacion();

        //VARIABLE PARA CONDICION DE SELCCION DE CLASE 
        int cond;
        //0 = Multimedia
        //1 = Pelicula
        //2 = PeliculaDocumental

        //CONDICON DE ERROR
        int bandera;

        public Form1()  //Constructor de la clase Form1
        {
            InitializeComponent();
            IniciarFormatos();
            IniciarFormatos2();
            ComBox2.Enabled = false;
            txtAPH.Enabled = false;
            txtAPM.Enabled = false;
            chkBox.Enabled = false;
            btnAñadir.Enabled = false;
            cond = 0;           
            bandera = 0; //SIN ERROR
            txtHoras.Text = "00";
            txtMinutos.Text = "00";
            txtSegundos.Text = "00";
        }

        void IniciarFormatos() //Inicializa las opciones del ComboBox1
        {
            ComBox1.Items.Add(".wav");
            ComBox1.Items.Add(".mp3");
            ComBox1.Items.Add(".midi");
            ComBox1.Items.Add(".cdAudio");
            ComBox1.Items.Add(".avi (Video)");
            ComBox1.Items.Add(".mov (Video)");
            ComBox1.Items.Add(".mpg (Video)");           
            ComBox1.Items.Add(".dvd (Video)");
        }

        void IniciarFormatos2()  //Inicializa las opciones del ComboBox2
        {
            ComBox2.Items.Add("Cientifico");
            ComBox2.Items.Add("Social");
            ComBox2.Items.Add("Cultural");
            ComBox2.Items.Add("Otro");
        }

        private void ComBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string texto;
            texto = ComBox1.Text;

            if (texto == ".avi (Video)" || texto == ".mov (Video)" || texto == ".mpg (Video)" || texto == ".dvd (Video)")
            {
                txtAPH.Enabled = true;
                txtAPM.Enabled = true;
                chkBox.Enabled = true;
                cond = 1;
            }
            else
            {
                txtAPH.Enabled = false;
                txtAPM.Enabled = false;
                chkBox.Checked = false;
                chkBox.Enabled = false;                
                txtAPH.Clear();
                txtAPM.Clear();
                cond = 0;
            }
        }

        private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBox.Checked)
            {
                ComBox2.Enabled = false;
                ComBox2.Text = "";
                cond = 1;
            }
            if (chkBox.Checked)
            {              
                ComBox2.Enabled = true;
                cond = 2;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            bandera = 0;
            //DECLARACION DE VARIABLES
            string titulo = "";
            string autor = "";
            string formato = "";
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            string A1 = "";
            string A2 = "";
            string cat = "";
            string Horas = "";
            string Minutos = "";
            string Segundos = "";

            //LECTURA DE DATOS
            titulo = txtTitulo.Text;
            formato = ComBox1.Text;
            cat = ComBox2.Text;

            autor = txtAutor.Text;
            //EN CASO DE VACIO
            if (autor == "")
            {
                autor = "N/A";
            }

            A1 = txtAPH.Text;
            //EN CASO DE VACIO
            if (A1 == "")
            {
                A1 = "N/A";
            }

            A2 = txtAPM.Text;
            //EN CASO DE VACIO
            if (A2 == "")
            {
                A2 = "N/A";
            }

            //PARA CONVERTIR A STRING
            if (txtHoras.Text == "")
            {
                num1 = 0;
            }
            else
            {
                num1 = Convert.ToInt32(txtHoras.Text);
            }
            //PARA DAR FORMATO
            if (num1 <= 9)
            {
                Horas = "0" + num1.ToString();
            }
            else
            {
                Horas = num1.ToString();
            }

            //PARA CONVERTIR A STRING
            if (txtMinutos.Text == "")
            {
                num2 = 0;
            }
            else
            {
                num2 = Convert.ToInt32(txtMinutos.Text);
            }         
            //PARA DAR FORMATO
            if (num2 <= 9)
            {
                Minutos = "0" + num2.ToString();
            }
            else
            {
                Minutos = num2.ToString();
            }

            //PARA CONVERTIR A STRING
            if(txtSegundos.Text=="")
            {
                num3 = 0;
            }
            else
            {
                num3 = Convert.ToInt32(txtSegundos.Text);
            }
            //PARA DAR FORMATO
            if (num3 <= 9)
            {
                Segundos = "0" + num3.ToString();
            }
            else
            {
                Segundos = num3.ToString();
            }

            //DETECCION DE ERRORES
            if (txtTitulo.Text == "" || ComBox1.Text == "")
            {
                bandera = 1;    //ERROR 1
            }
            if (num1 > 99 || num2 > 59 || num3 > 59)
            {
                bandera = 2;    //ERROR 2
            }
            if (cond == 1 || cond == 2)
            {
                if (A1 == "N/A" && A2 == "N/A")
                {
                    bandera = 3;    //ERROR 3
                }
            }
            if(cond == 2)
            {
                if(ComBox2.Text=="")
                {
                    bandera = 4;    //ERROR 4
                }
            }
            if(txtHoras.Text == "00" && txtMinutos.Text == "00" && txtSegundos.Text == "00")
            {
                bandera = 5;
            }
            if (txtHoras.Text == "" && txtMinutos.Text == "" && txtSegundos.Text == "")
            {
                bandera = 5;
            }

            switch (bandera)
            {
                case 0: //NO HUBO ERROR
                    {                        
                        //ENVIO DE PARAMTEROS A LAS CLASES
                        duracion = new tiempo(Horas, Minutos, Segundos);
                        a = new Multimedia(titulo, autor, formato, duracion);
                        b = new Pelicula(titulo, autor, formato, duracion, A1, A2);
                        c = new PeliculaDocumental(titulo, autor, formato, duracion, A1, A2, cat);

                        //IDENTIFICACION DE ERRORES
                        switch (cond)
                        {
                            case 0:
                                {
                                    lbxPrevia.Items.Clear();
                                    mostrar(a);
                                    break;
                                }
                            case 1:
                                {
                                    lbxPrevia.Items.Clear();
                                    mostrar(b);
                                    break;
                                }
                            case 2:
                                {
                                    lbxPrevia.Items.Clear();
                                    mostrar(c);
                                    break;
                                }
                        }
                        break;                       
                    }
                case 1:
                    {
                        MessageBox.Show("Se deben llenar al menos los atributos: Titulo, Formato y duracion");
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Formato de hora no valido");
                        break;                    
                    }
                case 3:
                    {
                        MessageBox.Show("Debe haber por lo menos un actor o actriz principal");
                        break;
                    }
                case 4:
                    {
                        MessageBox.Show("Seleccion el tipo de Documental o quita el check de la casilla");
                        break;
                    }
                case 5:
                    {
                        MessageBox.Show("Validacion de tiempo incorrecta");
                        break;
                    }
            }

            if(bandera == 0)
            {
                btnAñadir.Enabled = true;
            }
            else
            {
                btnAñadir.Enabled = false;
            }
        }

        private void mostrar(Multimedia a)
        {
            lbxPrevia.Items.Add(a.ACadena());           
        }

        //AÑADIR A LA GRIDVIEW
        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            //Añadir una nueva fila
            int fila = dtgvLista.Rows.Add();

            //Colocar la informacion

            dtgvLista.Rows[fila].Cells[0].Value = txtTitulo.Text;

            if (txtAutor.Text != "")
                dtgvLista.Rows[fila].Cells[1].Value = txtAutor.Text;
            else
                dtgvLista.Rows[fila].Cells[1].Value = "<>";

            if (txtAPH.Text != "")
                dtgvLista.Rows[fila].Cells[2].Value = txtAPH.Text;
            else
                dtgvLista.Rows[fila].Cells[2].Value = "<>";

            if (txtAPM.Text != "")
                dtgvLista.Rows[fila].Cells[3].Value = txtAPM.Text;
            else
                dtgvLista.Rows[fila].Cells[3].Value = "<>";

            if (ComBox2.Text != "")
                dtgvLista.Rows[fila].Cells[4].Value = ComBox2.Text;
            else
                dtgvLista.Rows[fila].Cells[4].Value = "<>";
      
            dtgvLista.Rows[fila].Cells[5].Value = ComBox1.Text;
            dtgvLista.Rows[fila].Cells[6].Value = duracion.getDatos();


            txtTitulo.Text = "";
            txtAutor.Text = "";
            ComBox1.Text = "";
            txtHoras.Text = "";
            txtMinutos.Text = "";
            txtSegundos.Text = "";
            txtAPH.Text = "";
            txtAPM.Text = "";
            ComBox2.Text = "";
            chkBox.Checked = false;
            btnAñadir.Enabled = false;
        }


        //CONTROL Y VALIDACION
        private void TxtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void TxtAPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void TxtAPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void TxtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void TxtMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void TxtSegundos_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void ComBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NoSePuedeEscribir(e);
        }

        private void ComBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NoSePuedeEscribir(e);
        }

        private void TxtHoras_Click(object sender, EventArgs e)
        {
            txtHoras.Text = "";
            btnAñadir.Enabled = false;
        }

        private void TxtMinutos_Click(object sender, EventArgs e)
        {
            txtMinutos.Text = "";
            btnAñadir.Enabled = false;
        }

        private void TxtSegundos_Click(object sender, EventArgs e)
        {
            txtSegundos.Text = "";
            btnAñadir.Enabled = false;
        }

        private void TxtTitulo_Click(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void TxtAutor_Click(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void ComBox1_Click(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void TxtAPH_Click(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void TxtAPM_Click(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void ChkBox_Click(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void ComBox2_Click(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void TxtTitulo_MouseCaptureChanged(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void TxtAutor_MouseCaptureChanged(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void ComBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void TxtHoras_MouseCaptureChanged(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void TxtMinutos_MouseCaptureChanged(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void TxtSegundos_MouseCaptureChanged(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void TxtAPH_MouseCaptureChanged(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void TxtAPM_MouseCaptureChanged(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }

        private void ComBox2_MouseCaptureChanged(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
        }
    }
}
