namespace Caro_Game
{
    partial class PlayZone
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
            this.PlayzoneFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.Avatar1PctBox = new System.Windows.Forms.PictureBox();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Avatar2PctBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar1PctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar2PctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayzoneFlow
            // 
            this.PlayzoneFlow.Location = new System.Drawing.Point(2, 1);
            this.PlayzoneFlow.Name = "PlayzoneFlow";
            this.PlayzoneFlow.Size = new System.Drawing.Size(713, 499);
            this.PlayzoneFlow.TabIndex = 0;
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.Location = new System.Drawing.Point(738, 12);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(119, 30);
            this.MenuButton.TabIndex = 1;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            // 
            // ReplayButton
            // 
            this.ReplayButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayButton.Location = new System.Drawing.Point(749, 453);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(91, 34);
            this.ReplayButton.TabIndex = 2;
            this.ReplayButton.Text = "Đi lại";
            this.ReplayButton.UseVisualStyleBackColor = true;
            // 
            // Avatar1PctBox
            // 
            this.Avatar1PctBox.Location = new System.Drawing.Point(721, 189);
            this.Avatar1PctBox.Name = "Avatar1PctBox";
            this.Avatar1PctBox.Size = new System.Drawing.Size(144, 101);
            this.Avatar1PctBox.TabIndex = 3;
            this.Avatar1PctBox.TabStop = false;
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Label.Location = new System.Drawing.Point(738, 158);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(111, 28);
            this.Player1Label.TabIndex = 4;
            this.Player1Label.Text = "Người chơi 1";
            this.Player1Label.UseCompatibleTextRendering = true;
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Label.Location = new System.Drawing.Point(738, 305);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(111, 23);
            this.Player2Label.TabIndex = 5;
            this.Player2Label.Text = "Người chơi 2";
            // 
            // Avatar2PctBox
            // 
            this.Avatar2PctBox.Location = new System.Drawing.Point(721, 331);
            this.Avatar2PctBox.Name = "Avatar2PctBox";
            this.Avatar2PctBox.Size = new System.Drawing.Size(144, 105);
            this.Avatar2PctBox.TabIndex = 6;
            this.Avatar2PctBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(724, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 82);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Đây là nơi hiển thị thời gian";
            // 
            // PlayZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 499);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Avatar2PctBox);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.Avatar1PctBox);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.PlayzoneFlow);
            this.Name = "PlayZone";
            this.Text = "CaroGameByD2V";
            ((System.ComponentModel.ISupportInitialize)(this.Avatar1PctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar2PctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PlayzoneFlow;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.PictureBox Avatar1PctBox;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.PictureBox Avatar2PctBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}