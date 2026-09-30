namespace SimuladorDeWindowsForm
{
    partial class FormPlanesDeVuelo
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
            this.txtid1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtx1F = new System.Windows.Forms.TextBox();
            this.txty1 = new System.Windows.Forms.TextBox();
            this.txty1F = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVel1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVel2 = new System.Windows.Forms.TextBox();
            this.txty2F = new System.Windows.Forms.TextBox();
            this.txty2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtx2F = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtid2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtid1
            // 
            this.txtid1.Location = new System.Drawing.Point(151, 108);
            this.txtid1.Name = "txtid1";
            this.txtid1.Size = new System.Drawing.Size(100, 20);
            this.txtid1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Avión 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Avión 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Identificador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Coordenadas iniciales";
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(151, 151);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(45, 20);
            this.txtx1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Coordenadas finales";
            // 
            // txtx1F
            // 
            this.txtx1F.Location = new System.Drawing.Point(151, 191);
            this.txtx1F.Name = "txtx1F";
            this.txtx1F.Size = new System.Drawing.Size(45, 20);
            this.txtx1F.TabIndex = 13;
            this.txtx1F.TextChanged += new System.EventHandler(this.txtx1F_TextChanged);
            // 
            // txty1
            // 
            this.txty1.Location = new System.Drawing.Point(206, 151);
            this.txty1.Name = "txty1";
            this.txty1.Size = new System.Drawing.Size(45, 20);
            this.txty1.TabIndex = 19;
            // 
            // txty1F
            // 
            this.txty1F.Location = new System.Drawing.Point(206, 191);
            this.txty1F.Name = "txty1F";
            this.txty1F.Size = new System.Drawing.Size(45, 20);
            this.txty1F.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Velocidad";
            // 
            // txtVel1
            // 
            this.txtVel1.Location = new System.Drawing.Point(151, 231);
            this.txtVel1.Name = "txtVel1";
            this.txtVel1.Size = new System.Drawing.Size(100, 20);
            this.txtVel1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Velocidad";
            // 
            // txtVel2
            // 
            this.txtVel2.Location = new System.Drawing.Point(470, 231);
            this.txtVel2.Name = "txtVel2";
            this.txtVel2.Size = new System.Drawing.Size(100, 20);
            this.txtVel2.TabIndex = 31;
            // 
            // txty2F
            // 
            this.txty2F.Location = new System.Drawing.Point(525, 191);
            this.txty2F.Name = "txty2F";
            this.txty2F.Size = new System.Drawing.Size(45, 20);
            this.txty2F.TabIndex = 30;
            // 
            // txty2
            // 
            this.txty2.Location = new System.Drawing.Point(525, 151);
            this.txty2.Name = "txty2";
            this.txty2.Size = new System.Drawing.Size(45, 20);
            this.txty2.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Coordenadas finales";
            // 
            // txtx2F
            // 
            this.txtx2F.Location = new System.Drawing.Point(470, 191);
            this.txtx2F.Name = "txtx2F";
            this.txtx2F.Size = new System.Drawing.Size(45, 20);
            this.txtx2F.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Coordenadas iniciales";
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(470, 151);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(45, 20);
            this.txtx2.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Identificador";
            // 
            // txtid2
            // 
            this.txtid2.Location = new System.Drawing.Point(470, 108);
            this.txtid2.Name = "txtid2";
            this.txtid2.Size = new System.Drawing.Size(100, 20);
            this.txtid2.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormPlanesDeVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVel2);
            this.Controls.Add(this.txty2F);
            this.Controls.Add(this.txty2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtx2F);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtid2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVel1);
            this.Controls.Add(this.txty1F);
            this.Controls.Add(this.txty1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtx1F);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid1);
            this.Name = "FormPlanesDeVuelo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPlanesDeVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtx1F;
        private System.Windows.Forms.TextBox txty1;
        private System.Windows.Forms.TextBox txty1F;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVel2;
        private System.Windows.Forms.TextBox txty2F;
        private System.Windows.Forms.TextBox txty2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtx2F;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

