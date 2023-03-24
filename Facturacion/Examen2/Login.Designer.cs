namespace Examen2
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoUsuarioTextBox1 = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox2 = new System.Windows.Forms.TextBox();
            this.CancelarButton2 = new System.Windows.Forms.Button();
            this.AceptarButton1 = new System.Windows.Forms.Button();
            this.ImagenPictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // CodigoUsuarioTextBox1
            // 
            this.CodigoUsuarioTextBox1.Location = new System.Drawing.Point(143, 38);
            this.CodigoUsuarioTextBox1.Name = "CodigoUsuarioTextBox1";
            this.CodigoUsuarioTextBox1.Size = new System.Drawing.Size(181, 26);
            this.CodigoUsuarioTextBox1.TabIndex = 2;
            // 
            // ContraseñaTextBox2
            // 
            this.ContraseñaTextBox2.Location = new System.Drawing.Point(143, 88);
            this.ContraseñaTextBox2.Name = "ContraseñaTextBox2";
            this.ContraseñaTextBox2.PasswordChar = '*';
            this.ContraseñaTextBox2.Size = new System.Drawing.Size(181, 26);
            this.ContraseñaTextBox2.TabIndex = 3;
            // 
            // CancelarButton2
            // 
            this.CancelarButton2.BackColor = System.Drawing.Color.Red;
            this.CancelarButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton2.Image = global::Examen2.Properties.Resources.error;
            this.CancelarButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CancelarButton2.Location = new System.Drawing.Point(232, 145);
            this.CancelarButton2.Name = "CancelarButton2";
            this.CancelarButton2.Size = new System.Drawing.Size(134, 33);
            this.CancelarButton2.TabIndex = 6;
            this.CancelarButton2.Text = "Cancelar";
            this.CancelarButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelarButton2.UseVisualStyleBackColor = false;
            this.CancelarButton2.Click += new System.EventHandler(this.CancelarButton2_Click);
            // 
            // AceptarButton1
            // 
            this.AceptarButton1.BackColor = System.Drawing.Color.Lime;
            this.AceptarButton1.Image = global::Examen2.Properties.Resources.aceptar;
            this.AceptarButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AceptarButton1.Location = new System.Drawing.Point(47, 143);
            this.AceptarButton1.Name = "AceptarButton1";
            this.AceptarButton1.Size = new System.Drawing.Size(124, 33);
            this.AceptarButton1.TabIndex = 5;
            this.AceptarButton1.Text = "Aceptar";
            this.AceptarButton1.UseVisualStyleBackColor = false;
            this.AceptarButton1.Click += new System.EventHandler(this.AceptarButton1_Click);
            // 
            // ImagenPictureBox1
            // 
            this.ImagenPictureBox1.BackColor = System.Drawing.Color.White;
            this.ImagenPictureBox1.Image = global::Examen2.Properties.Resources.personal_data;
            this.ImagenPictureBox1.Location = new System.Drawing.Point(353, 38);
            this.ImagenPictureBox1.Name = "ImagenPictureBox1";
            this.ImagenPictureBox1.Size = new System.Drawing.Size(68, 70);
            this.ImagenPictureBox1.TabIndex = 4;
            this.ImagenPictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AcceptButton = this.AceptarButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton2;
            this.ClientSize = new System.Drawing.Size(497, 227);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarButton2);
            this.Controls.Add(this.AceptarButton1);
            this.Controls.Add(this.ImagenPictureBox1);
            this.Controls.Add(this.ContraseñaTextBox2);
            this.Controls.Add(this.CodigoUsuarioTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoUsuarioTextBox1;
        private System.Windows.Forms.TextBox ContraseñaTextBox2;
        private System.Windows.Forms.PictureBox ImagenPictureBox1;
        private System.Windows.Forms.Button AceptarButton1;
        private System.Windows.Forms.Button CancelarButton2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

