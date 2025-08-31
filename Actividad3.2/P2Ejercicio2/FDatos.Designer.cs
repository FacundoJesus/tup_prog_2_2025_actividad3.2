namespace P2Ejercicio2
{
    partial class FDatos
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
            label1 = new Label();
            lbDni = new Label();
            tbNombre = new TextBox();
            tbDni = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // lbDni
            // 
            lbDni.AutoSize = true;
            lbDni.Location = new Point(41, 60);
            lbDni.Name = "lbDni";
            lbDni.Size = new Size(27, 15);
            lbDni.TabIndex = 1;
            lbDni.Text = "DNI";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(109, 15);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(131, 23);
            tbNombre.TabIndex = 2;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(109, 60);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(131, 23);
            tbDni.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(17, 112);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(195, 112);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 149);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(tbDni);
            Controls.Add(tbNombre);
            Controls.Add(lbDni);
            Controls.Add(label1);
            Name = "FDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos de la Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox tbNombre;
        public TextBox tbDni;
        private Button btnAceptar;
        private Button btnCancelar;
        public Label lbDni;
    }
}