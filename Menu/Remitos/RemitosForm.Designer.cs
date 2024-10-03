namespace LoginCAI.Menu.Remitos
{
    partial class RemitosForm
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
            VerRemitosBtn = new Button();
            VolverRemitoBtn = new Button();
            SuspendLayout();
            // 
            // VerRemitosBtn
            // 
            VerRemitosBtn.Location = new Point(124, 111);
            VerRemitosBtn.Name = "VerRemitosBtn";
            VerRemitosBtn.Size = new Size(191, 81);
            VerRemitosBtn.TabIndex = 0;
            VerRemitosBtn.Text = "Ver Remitos";
            VerRemitosBtn.UseVisualStyleBackColor = true;
            // 
            // VolverRemitoBtn
            // 
            VolverRemitoBtn.Location = new Point(32, 12);
            VolverRemitoBtn.Name = "VolverRemitoBtn";
            VolverRemitoBtn.Size = new Size(121, 45);
            VolverRemitoBtn.TabIndex = 2;
            VolverRemitoBtn.Text = "Volver";
            VolverRemitoBtn.UseVisualStyleBackColor = true;
            // 
            // RemitosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(VolverRemitoBtn);
            Controls.Add(VerRemitosBtn);
            Name = "RemitosForm";
            Text = "RemitosForm";
            Load += RemitosForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button VerRemitosBtn;
        private Button VolverRemitoBtn;
    }
}