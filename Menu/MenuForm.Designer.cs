namespace LoginCAI.Menu
{
    partial class MenuForm
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
            ordenesBtn = new Button();
            remitosBtn = new Button();
            SuspendLayout();
            // 
            // ordenesBtn
            // 
            ordenesBtn.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordenesBtn.Location = new Point(307, 133);
            ordenesBtn.Name = "ordenesBtn";
            ordenesBtn.RightToLeft = RightToLeft.No;
            ordenesBtn.Size = new Size(163, 80);
            ordenesBtn.TabIndex = 3;
            ordenesBtn.Text = "Ordenes";
            ordenesBtn.UseVisualStyleBackColor = true;
            ordenesBtn.Click += ordenesBtn_Click;
            // 
            // remitosBtn
            // 
            remitosBtn.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remitosBtn.Location = new Point(307, 254);
            remitosBtn.Name = "remitosBtn";
            remitosBtn.Size = new Size(163, 80);
            remitosBtn.TabIndex = 4;
            remitosBtn.Text = "Remitos";
            remitosBtn.UseVisualStyleBackColor = true;
            remitosBtn.Click += remitosBtn_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(remitosBtn);
            Controls.Add(ordenesBtn);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button ordenesBtn;
        private Button remitosBtn;
    }
}