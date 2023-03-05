namespace Proyecto2EDA_AlgoritmoEncriptacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_limpiar = new FontAwesome.Sharp.IconButton();
            this.btn_AbrirEncriptado = new FontAwesome.Sharp.IconButton();
            this.btn_Guardar = new FontAwesome.Sharp.IconButton();
            this.btn_Decrypt = new FontAwesome.Sharp.IconButton();
            this.txt_Encriptado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.btn_Encriptar = new FontAwesome.Sharp.IconButton();
            this.txt_Leer = new System.Windows.Forms.TextBox();
            this.txt_Abrir = new System.Windows.Forms.TextBox();
            this.btn_Abrir = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALGORTIMO DE ENCRIPTACIÓN Y DESENCRIPTACIÓN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_limpiar);
            this.panel2.Controls.Add(this.btn_AbrirEncriptado);
            this.panel2.Controls.Add(this.btn_Guardar);
            this.panel2.Controls.Add(this.btn_Decrypt);
            this.panel2.Controls.Add(this.txt_Encriptado);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_Clave);
            this.panel2.Controls.Add(this.btn_Encriptar);
            this.panel2.Controls.Add(this.txt_Leer);
            this.panel2.Controls.Add(this.txt_Abrir);
            this.panel2.Controls.Add(this.btn_Abrir);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 446);
            this.panel2.TabIndex = 1;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btn_limpiar.IconColor = System.Drawing.Color.Black;
            this.btn_limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_limpiar.IconSize = 24;
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(721, 327);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(141, 33);
            this.btn_limpiar.TabIndex = 11;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_AbrirEncriptado
            // 
            this.btn_AbrirEncriptado.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AbrirEncriptado.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btn_AbrirEncriptado.IconColor = System.Drawing.Color.Black;
            this.btn_AbrirEncriptado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AbrirEncriptado.IconSize = 25;
            this.btn_AbrirEncriptado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AbrirEncriptado.Location = new System.Drawing.Point(436, 379);
            this.btn_AbrirEncriptado.Name = "btn_AbrirEncriptado";
            this.btn_AbrirEncriptado.Size = new System.Drawing.Size(219, 35);
            this.btn_AbrirEncriptado.TabIndex = 10;
            this.btn_AbrirEncriptado.Text = "Abrir archivo Encriptado";
            this.btn_AbrirEncriptado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AbrirEncriptado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AbrirEncriptado.UseVisualStyleBackColor = true;
            this.btn_AbrirEncriptado.Click += new System.EventHandler(this.btn_AbrirEncriptado_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btn_Guardar.IconColor = System.Drawing.Color.Black;
            this.btn_Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Guardar.IconSize = 24;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(721, 269);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(141, 33);
            this.btn_Guardar.TabIndex = 9;
            this.btn_Guardar.Text = "Salvar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Decrypt.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.btn_Decrypt.IconColor = System.Drawing.Color.Black;
            this.btn_Decrypt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Decrypt.IconSize = 23;
            this.btn_Decrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Decrypt.Location = new System.Drawing.Point(721, 199);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(141, 35);
            this.btn_Decrypt.TabIndex = 8;
            this.btn_Decrypt.Text = "Desencriptar";
            this.btn_Decrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Decrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // txt_Encriptado
            // 
            this.txt_Encriptado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Encriptado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Encriptado.Location = new System.Drawing.Point(403, 115);
            this.txt_Encriptado.MaxLength = 9999999;
            this.txt_Encriptado.Multiline = true;
            this.txt_Encriptado.Name = "txt_Encriptado";
            this.txt_Encriptado.Size = new System.Drawing.Size(287, 245);
            this.txt_Encriptado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(121, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clave:";
            // 
            // txt_Clave
            // 
            this.txt_Clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Clave.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Clave.Location = new System.Drawing.Point(207, 64);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(326, 25);
            this.txt_Clave.TabIndex = 5;
            // 
            // btn_Encriptar
            // 
            this.btn_Encriptar.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Encriptar.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btn_Encriptar.IconColor = System.Drawing.Color.Black;
            this.btn_Encriptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Encriptar.IconSize = 22;
            this.btn_Encriptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Encriptar.Location = new System.Drawing.Point(721, 129);
            this.btn_Encriptar.Name = "btn_Encriptar";
            this.btn_Encriptar.Size = new System.Drawing.Size(141, 35);
            this.btn_Encriptar.TabIndex = 4;
            this.btn_Encriptar.Text = "Encriptar";
            this.btn_Encriptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Encriptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Encriptar.UseVisualStyleBackColor = true;
            this.btn_Encriptar.Click += new System.EventHandler(this.btn_Encriptar_Click);
            // 
            // txt_Leer
            // 
            this.txt_Leer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Leer.Location = new System.Drawing.Point(35, 115);
            this.txt_Leer.Multiline = true;
            this.txt_Leer.Name = "txt_Leer";
            this.txt_Leer.Size = new System.Drawing.Size(298, 245);
            this.txt_Leer.TabIndex = 3;
            // 
            // txt_Abrir
            // 
            this.txt_Abrir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Abrir.Enabled = false;
            this.txt_Abrir.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Abrir.Location = new System.Drawing.Point(207, 18);
            this.txt_Abrir.Name = "txt_Abrir";
            this.txt_Abrir.Size = new System.Drawing.Size(326, 25);
            this.txt_Abrir.TabIndex = 2;
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Abrir.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btn_Abrir.IconColor = System.Drawing.Color.Black;
            this.btn_Abrir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Abrir.IconSize = 25;
            this.btn_Abrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Abrir.Location = new System.Drawing.Point(77, 379);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(208, 35);
            this.btn_Abrir.TabIndex = 1;
            this.btn_Abrir.Text = "Abrir archivo en Claro";
            this.btn_Abrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Abrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ruta del archivo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = ".txt";
            this.openFileDialog1.Filter = "Archivo TXT (*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Guardar en...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private FontAwesome.Sharp.IconButton btn_Abrir;
        private TextBox txt_Leer;
        private TextBox txt_Abrir;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontAwesome.Sharp.IconButton btn_Encriptar;
        private Label label3;
        private TextBox txt_Clave;
        private TextBox txt_Encriptado;
        private FontAwesome.Sharp.IconButton btn_Decrypt;
        private FontAwesome.Sharp.IconButton btn_Guardar;
        private FontAwesome.Sharp.IconButton btn_limpiar;
        private FontAwesome.Sharp.IconButton btn_AbrirEncriptado;
    }
}