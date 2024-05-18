namespace NicoCala.Prototipos.Ej4
{
    partial class PersonaEditarForm
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
            EdicionGroupBox = new GroupBox();
            AceptarBoton = new Button();
            CancelarBoton = new Button();
            NumeroText = new TextBox();
            label7 = new Label();
            CodAreaText = new TextBox();
            label6 = new Label();
            CodPaisText = new TextBox();
            label5 = new Label();
            TipoCombo = new ComboBox();
            label4 = new Label();
            ApellidoText = new TextBox();
            label3 = new Label();
            NombreText = new TextBox();
            label2 = new Label();
            DocumentoText = new TextBox();
            label1 = new Label();
            EdicionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EdicionGroupBox
            // 
            EdicionGroupBox.Controls.Add(AceptarBoton);
            EdicionGroupBox.Controls.Add(CancelarBoton);
            EdicionGroupBox.Controls.Add(NumeroText);
            EdicionGroupBox.Controls.Add(label7);
            EdicionGroupBox.Controls.Add(CodAreaText);
            EdicionGroupBox.Controls.Add(label6);
            EdicionGroupBox.Controls.Add(CodPaisText);
            EdicionGroupBox.Controls.Add(label5);
            EdicionGroupBox.Controls.Add(TipoCombo);
            EdicionGroupBox.Controls.Add(label4);
            EdicionGroupBox.Controls.Add(ApellidoText);
            EdicionGroupBox.Controls.Add(label3);
            EdicionGroupBox.Controls.Add(NombreText);
            EdicionGroupBox.Controls.Add(label2);
            EdicionGroupBox.Controls.Add(DocumentoText);
            EdicionGroupBox.Controls.Add(label1);
            EdicionGroupBox.Location = new Point(12, 12);
            EdicionGroupBox.Name = "EdicionGroupBox";
            EdicionGroupBox.Size = new Size(743, 183);
            EdicionGroupBox.TabIndex = 6;
            EdicionGroupBox.TabStop = false;
            EdicionGroupBox.Text = "EdicionGroup";
            // 
            // AceptarBoton
            // 
            AceptarBoton.Location = new Point(573, 145);
            AceptarBoton.Name = "AceptarBoton";
            AceptarBoton.Size = new Size(75, 23);
            AceptarBoton.TabIndex = 15;
            AceptarBoton.Text = "Aceptar";
            AceptarBoton.UseVisualStyleBackColor = true;
            AceptarBoton.Click += AceptarBoton_Click;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(654, 145);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(75, 23);
            CancelarBoton.TabIndex = 5;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // NumeroText
            // 
            NumeroText.Location = new Point(544, 102);
            NumeroText.Name = "NumeroText";
            NumeroText.Size = new Size(184, 23);
            NumeroText.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(544, 84);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 13;
            label7.Text = "Numero";
            // 
            // CodAreaText
            // 
            CodAreaText.Location = new Point(354, 102);
            CodAreaText.Name = "CodAreaText";
            CodAreaText.Size = new Size(184, 23);
            CodAreaText.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 84);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 11;
            label6.Text = "Codigo Area";
            // 
            // CodPaisText
            // 
            CodPaisText.Location = new Point(164, 102);
            CodPaisText.Name = "CodPaisText";
            CodPaisText.Size = new Size(184, 23);
            CodPaisText.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 84);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 9;
            label5.Text = "Codigo Pais";
            // 
            // TipoCombo
            // 
            TipoCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TipoCombo.FormattingEnabled = true;
            TipoCombo.Location = new Point(6, 102);
            TipoCombo.Name = "TipoCombo";
            TipoCombo.Size = new Size(152, 23);
            TipoCombo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "Tipo";
            // 
            // ApellidoText
            // 
            ApellidoText.Location = new Point(544, 37);
            ApellidoText.Name = "ApellidoText";
            ApellidoText.Size = new Size(184, 23);
            ApellidoText.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 19);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // NombreText
            // 
            NombreText.Location = new Point(196, 37);
            NombreText.Name = "NombreText";
            NombreText.Size = new Size(342, 23);
            NombreText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 19);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // DocumentoText
            // 
            DocumentoText.Location = new Point(6, 37);
            DocumentoText.Name = "DocumentoText";
            DocumentoText.Size = new Size(184, 23);
            DocumentoText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // PersonaEditarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 210);
            Controls.Add(EdicionGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PersonaEditarForm";
            Text = "PersonaEditar";
            Load += PersonaEditarForm_Load;
            EdicionGroupBox.ResumeLayout(false);
            EdicionGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EdicionGroupBox;
        private Button AceptarBoton;
        private Button CancelarBoton;
        private TextBox NumeroText;
        private Label label7;
        private TextBox CodAreaText;
        private Label label6;
        private TextBox CodPaisText;
        private Label label5;
        private ComboBox TipoCombo;
        private Label label4;
        private TextBox ApellidoText;
        private Label label3;
        private TextBox NombreText;
        private Label label2;
        private TextBox DocumentoText;
        private Label label1;
    }
}