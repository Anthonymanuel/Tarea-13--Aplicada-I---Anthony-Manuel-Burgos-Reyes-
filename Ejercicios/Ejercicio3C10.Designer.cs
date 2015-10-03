namespace Ejercicios
{
    partial class Ejercicio3C10
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
            this.LadoTextBox = new System.Windows.Forms.TextBox();
            this.LongitudTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MostrarRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitud";
            // 
            // LadoTextBox
            // 
            this.LadoTextBox.Location = new System.Drawing.Point(121, 48);
            this.LadoTextBox.Name = "LadoTextBox";
            this.LadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.LadoTextBox.TabIndex = 2;
            // 
            // LongitudTextBox
            // 
            this.LongitudTextBox.Location = new System.Drawing.Point(121, 87);
            this.LongitudTextBox.Name = "LongitudTextBox";
            this.LongitudTextBox.Size = new System.Drawing.Size(100, 20);
            this.LongitudTextBox.TabIndex = 3;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(137, 113);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 4;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MostrarRichTextBox
            // 
            this.MostrarRichTextBox.Location = new System.Drawing.Point(12, 163);
            this.MostrarRichTextBox.Name = "MostrarRichTextBox";
            this.MostrarRichTextBox.ReadOnly = true;
            this.MostrarRichTextBox.Size = new System.Drawing.Size(323, 86);
            this.MostrarRichTextBox.TabIndex = 5;
            this.MostrarRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datos validados  si es igual 1 el dato es invalido";
            // 
            // Ejercicio3C10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MostrarRichTextBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.LongitudTextBox);
            this.Controls.Add(this.LadoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio3C10";
            this.Text = "Ejercicio 3, 4 y 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LadoTextBox;
        private System.Windows.Forms.TextBox LongitudTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.RichTextBox MostrarRichTextBox;
        private System.Windows.Forms.Label label3;
    }
}