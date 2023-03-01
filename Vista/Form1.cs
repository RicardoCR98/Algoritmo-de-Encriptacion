using Proyecto2EDA_AlgoritmoEncriptacion.Logica;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace Proyecto2EDA_AlgoritmoEncriptacion
{
    public partial class Form1 : Form
    {
        string cadena;
        string clave;
        string cadenaEncrypt;
        public Form1()
        {
            InitializeComponent();
        }

        private void leerCampos()
        {
            this.cadena = txt_Leer.Text;
            this.clave = txt_Clave.Text;
            this.cadenaEncrypt = txt_Encriptado.Text;

        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_Abrir.Text = openFileDialog1.FileName;
                TextReader reader = new StreamReader(txt_Abrir.Text);
                txt_Leer.Text = reader.ReadToEnd();
                reader.Close();
            }
            else
            {
                txt_Abrir.Text = "Seleccione la ruta del archivo";
            }
        }

        private void btn_Encriptar_Click(object sender, EventArgs e)
        {

            //if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    TextWriter wr = new StreamWriter(openFileDialog1.FileName + "-Encrypted.txt");
            //    wr.Close();
            //}
            leerCampos();
            Encrypt cifrar = new Encrypt(cadena,clave);
            txt_Encriptado.Text = cifrar.cadenaEncryp(clave);
            MessageBox.Show("Archivo encriptado con éxito");
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            leerCampos();
            Decrypt descifrar = new Decrypt(cadenaEncrypt,clave);
            //txt_Leer.Text = descifrar.cadenaDecrypr(clave);
            MessageBox.Show("Archivo desencriptado con éxito");
        }
    }
}