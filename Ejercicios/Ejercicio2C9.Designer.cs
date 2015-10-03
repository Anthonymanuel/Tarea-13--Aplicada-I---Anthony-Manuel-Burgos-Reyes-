namespace Ejercicios
{
    partial class Ejercicio2C9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.EntidadBTextBox = new System.Windows.Forms.TextBox();
            this.CuentaTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MostrarRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entidad Bancaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de cuenta";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(131, 41);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroTextBox.TabIndex = 3;
            // 
            // EntidadBTextBox
            // 
            this.EntidadBTextBox.Location = new System.Drawing.Point(131, 82);
            this.EntidadBTextBox.Name = "EntidadBTextBox";
            this.EntidadBTextBox.Size = new System.Drawing.Size(100, 20);
            this.EntidadBTextBox.TabIndex = 4;
            // 
            // CuentaTextBox
            // 
            this.CuentaTextBox.Location = new System.Drawing.Point(131, 128);
            this.CuentaTextBox.Name = "CuentaTextBox";
            this.CuentaTextBox.Size = new System.Drawing.Size(100, 20);
            this.CuentaTextBox.TabIndex = 5;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(145, 165);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MostrarRichTextBox
            // 
            this.MostrarRichTextBox.Location = new System.Drawing.Point(12, 212);
            this.MostrarRichTextBox.Name = "MostrarRichTextBox";
            this.MostrarRichTextBox.Size = new System.Drawing.Size(293, 89);
            this.MostrarRichTextBox.TabIndex = 7;
            this.MostrarRichTextBox.Text = "";
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(145, 304);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(75, 23);
            this.MostrarButton.TabIndex = 8;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // Ejercicio2C9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 339);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.MostrarRichTextBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CuentaTextBox);
            this.Controls.Add(this.EntidadBTextBox);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2C9";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox EntidadBTextBox;
        private System.Windows.Forms.TextBox CuentaTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.RichTextBox MostrarRichTextBox;
        private System.Windows.Forms.Button MostrarButton;
    }
}