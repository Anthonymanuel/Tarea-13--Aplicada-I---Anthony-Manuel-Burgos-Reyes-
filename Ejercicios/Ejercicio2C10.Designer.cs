namespace Ejercicios
{
    partial class Ejercicio2C10
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
            this.label4 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.SesionTextBox = new System.Windows.Forms.TextBox();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.GradoTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MostrarRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sesion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grado";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(143, 36);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreTextBox.TabIndex = 4;
            // 
            // SesionTextBox
            // 
            this.SesionTextBox.Location = new System.Drawing.Point(143, 67);
            this.SesionTextBox.Name = "SesionTextBox";
            this.SesionTextBox.Size = new System.Drawing.Size(100, 20);
            this.SesionTextBox.TabIndex = 5;
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(143, 98);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(100, 20);
            this.EdadTextBox.TabIndex = 6;
            // 
            // GradoTextBox
            // 
            this.GradoTextBox.Location = new System.Drawing.Point(143, 129);
            this.GradoTextBox.Name = "GradoTextBox";
            this.GradoTextBox.Size = new System.Drawing.Size(100, 20);
            this.GradoTextBox.TabIndex = 7;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(153, 155);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MostrarRichTextBox
            // 
            this.MostrarRichTextBox.Location = new System.Drawing.Point(12, 184);
            this.MostrarRichTextBox.Name = "MostrarRichTextBox";
            this.MostrarRichTextBox.Size = new System.Drawing.Size(342, 96);
            this.MostrarRichTextBox.TabIndex = 9;
            this.MostrarRichTextBox.Text = "";
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(153, 292);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(75, 23);
            this.MostrarButton.TabIndex = 10;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // Ejercico2C10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 327);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.MostrarRichTextBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.GradoTextBox);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.SesionTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercico2C10";
            this.Text = "Ejercico 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox SesionTextBox;
        private System.Windows.Forms.TextBox EdadTextBox;
        private System.Windows.Forms.TextBox GradoTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.RichTextBox MostrarRichTextBox;
        private System.Windows.Forms.Button MostrarButton;
    }
}