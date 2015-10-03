namespace Ejercicios
{
    partial class Ejercicio5C9
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
            this.MostrarRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SelecionarButton = new System.Windows.Forms.Button();
            this.TipoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MostrarRichTextBox
            // 
            this.MostrarRichTextBox.Location = new System.Drawing.Point(12, 141);
            this.MostrarRichTextBox.Name = "MostrarRichTextBox";
            this.MostrarRichTextBox.ReadOnly = true;
            this.MostrarRichTextBox.Size = new System.Drawing.Size(260, 96);
            this.MostrarRichTextBox.TabIndex = 9;
            this.MostrarRichTextBox.Text = "";
            // 
            // SelecionarButton
            // 
            this.SelecionarButton.Location = new System.Drawing.Point(126, 111);
            this.SelecionarButton.Name = "SelecionarButton";
            this.SelecionarButton.Size = new System.Drawing.Size(75, 23);
            this.SelecionarButton.TabIndex = 8;
            this.SelecionarButton.Text = "Seleccionar";
            this.SelecionarButton.UseVisualStyleBackColor = true;
            this.SelecionarButton.Click += new System.EventHandler(this.SelecionarButton_Click);
            // 
            // TipoComboBox
            // 
            this.TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoComboBox.FormattingEnabled = true;
            this.TipoComboBox.Items.AddRange(new object[] {
            "Estrellas de la secuencia principal ",
            "Estrellas gigantes y luminosas ",
            "Estrellas supergigantes ",
            "Estrellas binarias"});
            this.TipoComboBox.Location = new System.Drawing.Point(113, 23);
            this.TipoComboBox.Name = "TipoComboBox";
            this.TipoComboBox.Size = new System.Drawing.Size(159, 21);
            this.TipoComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de estrella";
            // 
            // Ejercicio5C9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MostrarRichTextBox);
            this.Controls.Add(this.SelecionarButton);
            this.Controls.Add(this.TipoComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio5C9";
            this.Text = "Ejercicio5C9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MostrarRichTextBox;
        private System.Windows.Forms.Button SelecionarButton;
        private System.Windows.Forms.ComboBox TipoComboBox;
        private System.Windows.Forms.Label label1;
    }
}