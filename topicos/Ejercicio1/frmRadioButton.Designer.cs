namespace Ejercicio1
{
    partial class frmRadioButton
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
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.rbtRetryCancel = new System.Windows.Forms.RadioButton();
            this.rbtYesNo = new System.Windows.Forms.RadioButton();
            this.rbtYesNoCancel = new System.Windows.Forms.RadioButton();
            this.rbtAbortRetryIgnore = new System.Windows.Forms.RadioButton();
            this.rbtOkCancel = new System.Windows.Forms.RadioButton();
            this.rbtOk = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxIcono = new System.Windows.Forms.GroupBox();
            this.rbtPregunta = new System.Windows.Forms.RadioButton();
            this.rbtInformacion = new System.Windows.Forms.RadioButton();
            this.rbtExclamacion = new System.Windows.Forms.RadioButton();
            this.rbtError = new System.Windows.Forms.RadioButton();
            this.btnDesplegar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxTipo.SuspendLayout();
            this.gbxIcono.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rbtRetryCancel);
            this.gbxTipo.Controls.Add(this.rbtYesNo);
            this.gbxTipo.Controls.Add(this.rbtYesNoCancel);
            this.gbxTipo.Controls.Add(this.rbtAbortRetryIgnore);
            this.gbxTipo.Controls.Add(this.rbtOkCancel);
            this.gbxTipo.Controls.Add(this.rbtOk);
            this.gbxTipo.Location = new System.Drawing.Point(49, 85);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(190, 461);
            this.gbxTipo.TabIndex = 0;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "TIPO DE ELEMENTO";
            // 
            // rbtRetryCancel
            // 
            this.rbtRetryCancel.AutoSize = true;
            this.rbtRetryCancel.Location = new System.Drawing.Point(31, 341);
            this.rbtRetryCancel.Name = "rbtRetryCancel";
            this.rbtRetryCancel.Size = new System.Drawing.Size(106, 21);
            this.rbtRetryCancel.TabIndex = 5;
            this.rbtRetryCancel.TabStop = true;
            this.rbtRetryCancel.Text = "RetryCancel";
            this.rbtRetryCancel.UseVisualStyleBackColor = true;
            // 
            // rbtYesNo
            // 
            this.rbtYesNo.AutoSize = true;
            this.rbtYesNo.Location = new System.Drawing.Point(31, 279);
            this.rbtYesNo.Name = "rbtYesNo";
            this.rbtYesNo.Size = new System.Drawing.Size(71, 21);
            this.rbtYesNo.TabIndex = 4;
            this.rbtYesNo.TabStop = true;
            this.rbtYesNo.Text = "YesNo";
            this.rbtYesNo.UseVisualStyleBackColor = true;
            this.rbtYesNo.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbtYesNoCancel
            // 
            this.rbtYesNoCancel.AutoSize = true;
            this.rbtYesNoCancel.Location = new System.Drawing.Point(31, 217);
            this.rbtYesNoCancel.Name = "rbtYesNoCancel";
            this.rbtYesNoCancel.Size = new System.Drawing.Size(114, 21);
            this.rbtYesNoCancel.TabIndex = 3;
            this.rbtYesNoCancel.TabStop = true;
            this.rbtYesNoCancel.Text = "YesNoCancel";
            this.rbtYesNoCancel.UseVisualStyleBackColor = true;
            this.rbtYesNoCancel.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbtAbortRetryIgnore
            // 
            this.rbtAbortRetryIgnore.AutoSize = true;
            this.rbtAbortRetryIgnore.Location = new System.Drawing.Point(31, 155);
            this.rbtAbortRetryIgnore.Name = "rbtAbortRetryIgnore";
            this.rbtAbortRetryIgnore.Size = new System.Drawing.Size(140, 21);
            this.rbtAbortRetryIgnore.TabIndex = 2;
            this.rbtAbortRetryIgnore.TabStop = true;
            this.rbtAbortRetryIgnore.Text = "AbortRetryCancel";
            this.rbtAbortRetryIgnore.UseVisualStyleBackColor = true;
            this.rbtAbortRetryIgnore.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbtOkCancel
            // 
            this.rbtOkCancel.AutoSize = true;
            this.rbtOkCancel.Location = new System.Drawing.Point(31, 93);
            this.rbtOkCancel.Name = "rbtOkCancel";
            this.rbtOkCancel.Size = new System.Drawing.Size(92, 21);
            this.rbtOkCancel.TabIndex = 1;
            this.rbtOkCancel.TabStop = true;
            this.rbtOkCancel.Text = "OKCancel";
            this.rbtOkCancel.UseVisualStyleBackColor = true;
            this.rbtOkCancel.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtOk
            // 
            this.rbtOk.AutoSize = true;
            this.rbtOk.Location = new System.Drawing.Point(31, 31);
            this.rbtOk.Name = "rbtOk";
            this.rbtOk.Size = new System.Drawing.Size(49, 21);
            this.rbtOk.TabIndex = 0;
            this.rbtOk.TabStop = true;
            this.rbtOk.Text = "OK";
            this.rbtOk.UseVisualStyleBackColor = true;
            this.rbtOk.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbxIcono
            // 
            this.gbxIcono.Controls.Add(this.rbtPregunta);
            this.gbxIcono.Controls.Add(this.rbtInformacion);
            this.gbxIcono.Controls.Add(this.rbtExclamacion);
            this.gbxIcono.Controls.Add(this.rbtError);
            this.gbxIcono.Location = new System.Drawing.Point(325, 85);
            this.gbxIcono.Name = "gbxIcono";
            this.gbxIcono.Size = new System.Drawing.Size(190, 227);
            this.gbxIcono.TabIndex = 1;
            this.gbxIcono.TabStop = false;
            this.gbxIcono.Text = "ICONO";
            // 
            // rbtPregunta
            // 
            this.rbtPregunta.AutoSize = true;
            this.rbtPregunta.Location = new System.Drawing.Point(18, 175);
            this.rbtPregunta.Name = "rbtPregunta";
            this.rbtPregunta.Size = new System.Drawing.Size(87, 21);
            this.rbtPregunta.TabIndex = 7;
            this.rbtPregunta.TabStop = true;
            this.rbtPregunta.Text = "Pregunta";
            this.rbtPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtPregunta.UseVisualStyleBackColor = true;
            // 
            // rbtInformacion
            // 
            this.rbtInformacion.AutoSize = true;
            this.rbtInformacion.Location = new System.Drawing.Point(18, 127);
            this.rbtInformacion.Name = "rbtInformacion";
            this.rbtInformacion.Size = new System.Drawing.Size(102, 21);
            this.rbtInformacion.TabIndex = 6;
            this.rbtInformacion.TabStop = true;
            this.rbtInformacion.Text = "Informacion";
            this.rbtInformacion.UseVisualStyleBackColor = true;
            // 
            // rbtExclamacion
            // 
            this.rbtExclamacion.AutoSize = true;
            this.rbtExclamacion.Location = new System.Drawing.Point(18, 79);
            this.rbtExclamacion.Name = "rbtExclamacion";
            this.rbtExclamacion.Size = new System.Drawing.Size(107, 21);
            this.rbtExclamacion.TabIndex = 5;
            this.rbtExclamacion.TabStop = true;
            this.rbtExclamacion.Text = "Excalamcion";
            this.rbtExclamacion.UseVisualStyleBackColor = true;
            // 
            // rbtError
            // 
            this.rbtError.AutoSize = true;
            this.rbtError.Location = new System.Drawing.Point(18, 31);
            this.rbtError.Name = "rbtError";
            this.rbtError.Size = new System.Drawing.Size(61, 21);
            this.rbtError.TabIndex = 4;
            this.rbtError.TabStop = true;
            this.rbtError.Text = "Error";
            this.rbtError.UseVisualStyleBackColor = true;
            // 
            // btnDesplegar
            // 
            this.btnDesplegar.Location = new System.Drawing.Point(325, 337);
            this.btnDesplegar.Name = "btnDesplegar";
            this.btnDesplegar.Size = new System.Drawing.Size(190, 75);
            this.btnDesplegar.TabIndex = 2;
            this.btnDesplegar.Text = "DESPLEGAR";
            this.btnDesplegar.UseVisualStyleBackColor = true;
            this.btnDesplegar.Click += new System.EventHandler(this.btnDesplegar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona el tipo de mensaje que deseas desplegar";
            // 
            // frmRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesplegar);
            this.Controls.Add(this.gbxIcono);
            this.Controls.Add(this.gbxTipo);
            this.Name = "frmRadioButton";
            this.Text = "Radio Button";
            this.Load += new System.EventHandler(this.frmRadioButton_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            this.gbxIcono.ResumeLayout(false);
            this.gbxIcono.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTipo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxIcono;
        private System.Windows.Forms.Button btnDesplegar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtYesNo;
        private System.Windows.Forms.RadioButton rbtYesNoCancel;
        private System.Windows.Forms.RadioButton rbtAbortRetryIgnore;
        private System.Windows.Forms.RadioButton rbtOkCancel;
        private System.Windows.Forms.RadioButton rbtOk;
        private System.Windows.Forms.RadioButton rbtRetryCancel;
        private System.Windows.Forms.RadioButton rbtPregunta;
        private System.Windows.Forms.RadioButton rbtInformacion;
        private System.Windows.Forms.RadioButton rbtExclamacion;
        private System.Windows.Forms.RadioButton rbtError;
    }
}