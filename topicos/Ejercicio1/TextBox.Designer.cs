namespace Ejercicio1
{
    partial class frmTextBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnVisible = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.lblVerSimbolo = new System.Windows.Forms.Label();
            this.lblVerUpper = new System.Windows.Forms.Label();
            this.lblVerNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(164, 71);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(164, 109);
            this.txtApellidoP.MaxLength = 50;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(234, 22);
            this.txtApellidoP.TabIndex = 1;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(164, 147);
            this.txtApellidoM.MaxLength = 50;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(234, 22);
            this.txtApellidoM.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(164, 185);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(41, 71);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(117, 17);
            this.lblNombrePaciente.TabIndex = 10;
            this.lblNombrePaciente.Text = "Nombre Paciente";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(41, 111);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(112, 17);
            this.lblApellidoP.TabIndex = 11;
            this.lblApellidoP.Text = "Apellido Paterno";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(41, 151);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(114, 17);
            this.lblApellidoM.TabIndex = 12;
            this.lblApellidoM.Text = "Apellido Materno";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(41, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // btnAceptar
            // 
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(677, 242);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(677, 194);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(677, 146);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(86, 23);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(677, 98);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(86, 23);
            this.btnVisible.TabIndex = 8;
            this.btnVisible.Text = "Visible";
            this.btnVisible.UseVisualStyleBackColor = true;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Resultado";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(41, 226);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(164, 223);
            this.txtPassword.MaxLength = 13;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(677, 50);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(86, 23);
            this.btnOcultar.TabIndex = 9;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // lblVerSimbolo
            // 
            this.lblVerSimbolo.AutoSize = true;
            this.lblVerSimbolo.ForeColor = System.Drawing.Color.Red;
            this.lblVerSimbolo.Location = new System.Drawing.Point(404, 276);
            this.lblVerSimbolo.Name = "lblVerSimbolo";
            this.lblVerSimbolo.Size = new System.Drawing.Size(46, 17);
            this.lblVerSimbolo.TabIndex = 17;
            this.lblVerSimbolo.Text = "label2";
            // 
            // lblVerUpper
            // 
            this.lblVerUpper.AutoSize = true;
            this.lblVerUpper.ForeColor = System.Drawing.Color.Red;
            this.lblVerUpper.Location = new System.Drawing.Point(404, 252);
            this.lblVerUpper.Name = "lblVerUpper";
            this.lblVerUpper.Size = new System.Drawing.Size(46, 17);
            this.lblVerUpper.TabIndex = 18;
            this.lblVerUpper.Text = "label3";
            // 
            // lblVerNumero
            // 
            this.lblVerNumero.AutoSize = true;
            this.lblVerNumero.ForeColor = System.Drawing.Color.Red;
            this.lblVerNumero.Location = new System.Drawing.Point(404, 228);
            this.lblVerNumero.Name = "lblVerNumero";
            this.lblVerNumero.Size = new System.Drawing.Size(46, 17);
            this.lblVerNumero.TabIndex = 19;
            this.lblVerNumero.Text = "label4";
            // 
            // frmTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 373);
            this.Controls.Add(this.lblVerNumero);
            this.Controls.Add(this.lblVerUpper);
            this.Controls.Add(this.lblVerSimbolo);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text Box";
            this.Load += new System.EventHandler(this.TextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnVisible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Label lblVerSimbolo;
        private System.Windows.Forms.Label lblVerUpper;
        private System.Windows.Forms.Label lblVerNumero;
    }
}