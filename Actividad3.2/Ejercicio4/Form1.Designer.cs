namespace Ejercicio4
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
            btnVerResultados = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(12, 12);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(422, 424);
            lsbResultado.TabIndex = 0;
            // 
            // btnVerResultados
            // 
            btnVerResultados.Location = new Point(461, 12);
            btnVerResultados.Name = "btnVerResultados";
            btnVerResultados.Size = new Size(75, 64);
            btnVerResultados.TabIndex = 1;
            btnVerResultados.Text = "Ver Resultado";
            btnVerResultados.UseVisualStyleBackColor = true;
            btnVerResultados.Click += btnVerResultados_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(461, 393);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 43);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnVerResultados);
            Controls.Add(lsbResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 4";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsbResultado;
        private Button btnVerResultados;
        private Button btnSalir;
    }
}
