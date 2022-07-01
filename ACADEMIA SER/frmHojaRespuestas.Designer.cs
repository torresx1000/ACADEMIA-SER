namespace ACADEMIA_SER
{
    partial class frmHojaRespuestas
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancealr = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgHojaRespuesta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumPreguntaHR = new System.Windows.Forms.TextBox();
            this.txtIdHojaRespuesta = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CbAlterHojaRespuesta = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTarjetaId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHojaRespuesta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnCancealr);
            this.groupBox4.Controls.Add(this.btnActualizar);
            this.groupBox4.Controls.Add(this.btnInsertar);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(290, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 54);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OPCIONES";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSalir.Location = new System.Drawing.Point(258, 21);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancealr
            // 
            this.btnCancealr.BackColor = System.Drawing.Color.LightGreen;
            this.btnCancealr.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCancealr.Location = new System.Drawing.Point(177, 21);
            this.btnCancealr.Name = "btnCancealr";
            this.btnCancealr.Size = new System.Drawing.Size(75, 23);
            this.btnCancealr.TabIndex = 4;
            this.btnCancealr.Text = "Cancelar";
            this.btnCancealr.UseVisualStyleBackColor = false;
            this.btnCancealr.Click += new System.EventHandler(this.btnCancealr_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightGreen;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnActualizar.Location = new System.Drawing.Point(87, 21);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.LightGreen;
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnInsertar.Location = new System.Drawing.Point(6, 21);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgHojaRespuesta
            // 
            this.dgHojaRespuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHojaRespuesta.Location = new System.Drawing.Point(290, 54);
            this.dgHojaRespuesta.Name = "dgHojaRespuesta";
            this.dgHojaRespuesta.Size = new System.Drawing.Size(294, 150);
            this.dgHojaRespuesta.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumPreguntaHR);
            this.groupBox1.Controls.Add(this.txtIdHojaRespuesta);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 228);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtNumPreguntaHR
            // 
            this.txtNumPreguntaHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPreguntaHR.Location = new System.Drawing.Point(182, 62);
            this.txtNumPreguntaHR.Multiline = true;
            this.txtNumPreguntaHR.Name = "txtNumPreguntaHR";
            this.txtNumPreguntaHR.Size = new System.Drawing.Size(48, 26);
            this.txtNumPreguntaHR.TabIndex = 2;
            // 
            // txtIdHojaRespuesta
            // 
            this.txtIdHojaRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHojaRespuesta.Location = new System.Drawing.Point(63, 25);
            this.txtIdHojaRespuesta.Multiline = true;
            this.txtIdHojaRespuesta.Name = "txtIdHojaRespuesta";
            this.txtIdHojaRespuesta.Size = new System.Drawing.Size(125, 26);
            this.txtIdHojaRespuesta.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CbAlterHojaRespuesta);
            this.groupBox3.Location = new System.Drawing.Point(46, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 32);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // CbAlterHojaRespuesta
            // 
            this.CbAlterHojaRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAlterHojaRespuesta.FormattingEnabled = true;
            this.CbAlterHojaRespuesta.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CbAlterHojaRespuesta.Location = new System.Drawing.Point(4, 5);
            this.CbAlterHojaRespuesta.Name = "CbAlterHojaRespuesta";
            this.CbAlterHojaRespuesta.Size = new System.Drawing.Size(96, 23);
            this.CbAlterHojaRespuesta.TabIndex = 1;
            this.CbAlterHojaRespuesta.Text = "Seleccionar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTarjetaId);
            this.groupBox2.Location = new System.Drawing.Point(29, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 40);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // txtTarjetaId
            // 
            this.txtTarjetaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjetaId.Location = new System.Drawing.Point(8, 9);
            this.txtTarjetaId.Multiline = true;
            this.txtTarjetaId.Name = "txtTarjetaId";
            this.txtTarjetaId.Size = new System.Drawing.Size(145, 26);
            this.txtTarjetaId.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ALTERNATIVA DE PREGUNTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID TARJETA DE INGRESO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NUMERO DE PREGUNTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // frmHojaRespuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 270);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgHojaRespuesta);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHojaRespuestas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmHojaRespuestas";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHojaRespuesta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancealr;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgHojaRespuesta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumPreguntaHR;
        private System.Windows.Forms.TextBox txtIdHojaRespuesta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CbAlterHojaRespuesta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTarjetaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}