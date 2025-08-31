namespace P2Ejercicio2
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
            tbDniABuscar = new TextBox();
            label1 = new Label();
            btnVerAltaPersona = new Button();
            lsbResultado = new ListBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // tbDniABuscar
            // 
            tbDniABuscar.Location = new Point(12, 31);
            tbDniABuscar.Name = "tbDniABuscar";
            tbDniABuscar.Size = new Size(190, 23);
            tbDniABuscar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "DNI";
            // 
            // btnVerAltaPersona
            // 
            btnVerAltaPersona.Location = new Point(258, 31);
            btnVerAltaPersona.Name = "btnVerAltaPersona";
            btnVerAltaPersona.Size = new Size(105, 23);
            btnVerAltaPersona.TabIndex = 2;
            btnVerAltaPersona.Text = "Ver/Alta Persona";
            btnVerAltaPersona.UseVisualStyleBackColor = true;
            btnVerAltaPersona.Click += btnVerAltaPersona_Click;
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(12, 72);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(351, 124);
            lsbResultado.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(146, 202);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 234);
            Controls.Add(btnSalir);
            Controls.Add(lsbResultado);
            Controls.Add(btnVerAltaPersona);
            Controls.Add(label1);
            Controls.Add(tbDniABuscar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parte 2 - Ejercicio 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDniABuscar;
        private Label label1;
        private Button btnVerAltaPersona;
        private ListBox lsbResultado;
        private Button btnSalir;
    }
}
