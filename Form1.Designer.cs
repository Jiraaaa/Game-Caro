namespace Caro_Game
{
    partial class LoginForm
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.PVPButton = new System.Windows.Forms.Button();
            this.PVBButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.ExitButton);
            this.MenuPanel.Controls.Add(this.PVBButton);
            this.MenuPanel.Controls.Add(this.PVPButton);
            this.MenuPanel.Location = new System.Drawing.Point(2, 1);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(882, 510);
            this.MenuPanel.TabIndex = 0;
            // 
            // PVPButton
            // 
            this.PVPButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVPButton.Location = new System.Drawing.Point(364, 235);
            this.PVPButton.Name = "PVPButton";
            this.PVPButton.Size = new System.Drawing.Size(156, 45);
            this.PVPButton.TabIndex = 0;
            this.PVPButton.Text = "Chơi với người";
            this.PVPButton.UseVisualStyleBackColor = true;
            // 
            // PVBButton
            // 
            this.PVBButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVBButton.Location = new System.Drawing.Point(364, 324);
            this.PVBButton.Name = "PVBButton";
            this.PVBButton.Size = new System.Drawing.Size(156, 44);
            this.PVBButton.TabIndex = 1;
            this.PVBButton.Text = "Chơi với máy";
            this.PVBButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(364, 420);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(156, 42);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Thoát Game";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 510);
            this.Controls.Add(this.MenuPanel);
            this.Name = "LoginForm";
            this.Text = "CaroGameByD2V";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PVBButton;
        private System.Windows.Forms.Button PVPButton;
    }
}

