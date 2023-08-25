namespace Patentes
{
    partial class Form1
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
            this.rbFormato1 = new System.Windows.Forms.RadioButton();
            this.rbFormato2 = new System.Windows.Forms.RadioButton();
            this.btnPatente = new System.Windows.Forms.Button();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCuit = new System.Windows.Forms.Button();
            this.lblCuitAyuda = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbFormato1
            // 
            this.rbFormato1.AutoSize = true;
            this.rbFormato1.Location = new System.Drawing.Point(144, 39);
            this.rbFormato1.Name = "rbFormato1";
            this.rbFormato1.Size = new System.Drawing.Size(73, 17);
            this.rbFormato1.TabIndex = 0;
            this.rbFormato1.TabStop = true;
            this.rbFormato1.Text = "LLNNNLL";
            this.rbFormato1.UseVisualStyleBackColor = true;
            this.rbFormato1.CheckedChanged += new System.EventHandler(this.rbFormato1_CheckedChanged);
            // 
            // rbFormato2
            // 
            this.rbFormato2.AutoSize = true;
            this.rbFormato2.Location = new System.Drawing.Point(144, 62);
            this.rbFormato2.Name = "rbFormato2";
            this.rbFormato2.Size = new System.Drawing.Size(67, 17);
            this.rbFormato2.TabIndex = 1;
            this.rbFormato2.TabStop = true;
            this.rbFormato2.Text = "LLLNNN";
            this.rbFormato2.UseVisualStyleBackColor = true;
            this.rbFormato2.CheckedChanged += new System.EventHandler(this.rbFormato2_CheckedChanged);
            // 
            // btnPatente
            // 
            this.btnPatente.Location = new System.Drawing.Point(39, 86);
            this.btnPatente.Name = "btnPatente";
            this.btnPatente.Size = new System.Drawing.Size(75, 23);
            this.btnPatente.TabIndex = 2;
            this.btnPatente.Text = "Aceptar";
            this.btnPatente.UseVisualStyleBackColor = true;
            this.btnPatente.Click += new System.EventHandler(this.btnPatente_Click);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(27, 48);
            this.txtPatente.MaxLength = 7;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 3;
            this.txtPatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatente_KeyPress);
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(47, 16);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(177, 13);
            this.lblFormato.TabIndex = 4;
            this.lblFormato.Text = "Seleccione el formato de su patente";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(65, 71);
            this.txtCuit.MaxLength = 11;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(153, 20);
            this.txtCuit.TabIndex = 5;
            this.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFormato2);
            this.groupBox1.Controls.Add(this.rbFormato1);
            this.groupBox1.Controls.Add(this.lblFormato);
            this.groupBox1.Controls.Add(this.btnPatente);
            this.groupBox1.Controls.Add(this.txtPatente);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCuit);
            this.groupBox2.Controls.Add(this.lblCuitAyuda);
            this.groupBox2.Controls.Add(this.txtCuit);
            this.groupBox2.Location = new System.Drawing.Point(340, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 154);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CUIT";
            // 
            // btnCuit
            // 
            this.btnCuit.Location = new System.Drawing.Point(104, 108);
            this.btnCuit.Name = "btnCuit";
            this.btnCuit.Size = new System.Drawing.Size(75, 23);
            this.btnCuit.TabIndex = 5;
            this.btnCuit.Text = "Aceptar";
            this.btnCuit.UseVisualStyleBackColor = true;
            this.btnCuit.Click += new System.EventHandler(this.btnCuit_Click);
            // 
            // lblCuitAyuda
            // 
            this.lblCuitAyuda.AutoSize = true;
            this.lblCuitAyuda.Location = new System.Drawing.Point(62, 39);
            this.lblCuitAyuda.Name = "lblCuitAyuda";
            this.lblCuitAyuda.Size = new System.Drawing.Size(157, 13);
            this.lblCuitAyuda.TabIndex = 5;
            this.lblCuitAyuda.Text = "Ingrese su CUIT (Solo numeros)";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(454, 263);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(0, 13);
            this.lblDni.TabIndex = 6;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(454, 204);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(0, 13);
            this.lblCuit.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CUIT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Patente:";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(99, 247);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(0, 13);
            this.lblPatente.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFormato1;
        private System.Windows.Forms.RadioButton rbFormato2;
        private System.Windows.Forms.Button btnPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCuit;
        private System.Windows.Forms.Label lblCuitAyuda;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPatente;
    }
}

