namespace Ejercicio2
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
            btnVer = new Button();
            SuspendLayout();
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(12, 12);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(417, 424);
            lsbResultado.TabIndex = 0;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(444, 12);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 55);
            btnVer.TabIndex = 1;
            btnVer.Text = "Ver Resultados";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(btnVer);
            Controls.Add(lsbResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 2";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsbResultado;
        private Button btnVer;
    }
}
