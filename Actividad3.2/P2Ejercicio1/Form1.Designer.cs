namespace P2Ejercicio1
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
            lsbResultado = new ListBox();
            btnVerResultado = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(12, 12);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(418, 424);
            lsbResultado.TabIndex = 0;
            // 
            // btnVerResultado
            // 
            btnVerResultado.Location = new Point(453, 12);
            btnVerResultado.Name = "btnVerResultado";
            btnVerResultado.Size = new Size(86, 71);
            btnVerResultado.TabIndex = 1;
            btnVerResultado.Text = "Ver Resultados";
            btnVerResultado.UseVisualStyleBackColor = true;
            btnVerResultado.Click += btnVerResultado_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(453, 365);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 71);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnVerResultado);
            Controls.Add(lsbResultado);
            Name = "Form1";
            Text = "Parte 2 -Ejercicio 1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsbResultado;
        private Button btnVerResultado;
        private Button btnSalir;
    }
}
