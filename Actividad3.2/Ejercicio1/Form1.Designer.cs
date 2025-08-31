namespace Ejercicio1
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
            SuspendLayout();
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(12, 12);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(422, 409);
            lsbResultado.TabIndex = 0;
            // 
            // btnVerResultado
            // 
            btnVerResultado.Location = new Point(466, 12);
            btnVerResultado.Name = "btnVerResultado";
            btnVerResultado.Size = new Size(75, 60);
            btnVerResultado.TabIndex = 1;
            btnVerResultado.Text = "Ver";
            btnVerResultado.UseVisualStyleBackColor = true;
            btnVerResultado.Click += btnVerResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 450);
            Controls.Add(btnVerResultado);
            Controls.Add(lsbResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsbResultado;
        private Button btnVerResultado;
    }
}
