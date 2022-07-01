namespace ACADEMIA_SER
{
    partial class principal
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSesion = new System.Windows.Forms.Button();
            this.btnSilabo = new System.Windows.Forms.Button();
            this.btnHojaRespuesta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(362, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "ASISTENCIA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(130, 467);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "BANCO DE PREGUNTAS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.Location = new System.Drawing.Point(362, 467);
            this.btnSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(154, 80);
            this.btnSesion.TabIndex = 2;
            this.btnSesion.Text = "SESION DE CLASES";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // btnSilabo
            // 
            this.btnSilabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSilabo.Location = new System.Drawing.Point(150, 51);
            this.btnSilabo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSilabo.Name = "btnSilabo";
            this.btnSilabo.Size = new System.Drawing.Size(159, 59);
            this.btnSilabo.TabIndex = 3;
            this.btnSilabo.Text = "SILABO";
            this.btnSilabo.UseVisualStyleBackColor = true;
            this.btnSilabo.Click += new System.EventHandler(this.btnSilabo_Click);
            // 
            // btnHojaRespuesta
            // 
            this.btnHojaRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHojaRespuesta.Location = new System.Drawing.Point(12, 338);
            this.btnHojaRespuesta.Name = "btnHojaRespuesta";
            this.btnHojaRespuesta.Size = new System.Drawing.Size(120, 74);
            this.btnHojaRespuesta.TabIndex = 4;
            this.btnHojaRespuesta.Text = "Hoja Respuesta";
            this.btnHojaRespuesta.UseVisualStyleBackColor = true;
            this.btnHojaRespuesta.Click += new System.EventHandler(this.btnHojaRespuesta_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACADEMIA_SER.Properties.Resources.Academia_ser__2_;
            this.ClientSize = new System.Drawing.Size(633, 574);
            this.Controls.Add(this.btnHojaRespuesta);
            this.Controls.Add(this.btnSilabo);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Button btnSilabo;
        private System.Windows.Forms.Button btnHojaRespuesta;
    }
}

