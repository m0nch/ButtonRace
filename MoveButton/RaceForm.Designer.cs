namespace MoveButton
{
    partial class RaceForm
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
            this.btnBella = new System.Windows.Forms.Button();
            this.btnAlex = new System.Windows.Forms.Button();
            this.btnLady = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelFinish = new System.Windows.Forms.Panel();
            this.lblFinish = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PanelFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBella
            // 
            this.btnBella.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBella.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBella.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBella.Location = new System.Drawing.Point(27, 40);
            this.btnBella.Name = "btnBella";
            this.btnBella.Size = new System.Drawing.Size(93, 33);
            this.btnBella.TabIndex = 0;
            this.btnBella.Text = "Bella";
            this.btnBella.UseVisualStyleBackColor = false;
            // 
            // btnAlex
            // 
            this.btnAlex.BackColor = System.Drawing.Color.Gold;
            this.btnAlex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlex.Location = new System.Drawing.Point(27, 121);
            this.btnAlex.Name = "btnAlex";
            this.btnAlex.Size = new System.Drawing.Size(93, 33);
            this.btnAlex.TabIndex = 1;
            this.btnAlex.Text = "Alex";
            this.btnAlex.UseVisualStyleBackColor = false;
            // 
            // btnLady
            // 
            this.btnLady.BackColor = System.Drawing.Color.Khaki;
            this.btnLady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLady.Location = new System.Drawing.Point(27, 202);
            this.btnLady.Name = "btnLady";
            this.btnLady.Size = new System.Drawing.Size(93, 33);
            this.btnLady.TabIndex = 2;
            this.btnLady.Text = "Lady";
            this.btnLady.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(12, 291);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(1136, 37);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.PanelFinish);
            this.panel1.Controls.Add(this.btnLady);
            this.panel1.Controls.Add(this.btnAlex);
            this.panel1.Controls.Add(this.btnBella);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 262);
            this.panel1.TabIndex = 6;
            // 
            // PanelFinish
            // 
            this.PanelFinish.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelFinish.Controls.Add(this.lblFinish);
            this.PanelFinish.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelFinish.Location = new System.Drawing.Point(1043, 0);
            this.PanelFinish.Name = "PanelFinish";
            this.PanelFinish.Size = new System.Drawing.Size(93, 262);
            this.PanelFinish.TabIndex = 4;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.Color.Red;
            this.lblFinish.Location = new System.Drawing.Point(-3, 0);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(93, 31);
            this.lblFinish.TabIndex = 7;
            this.lblFinish.Text = "Finish";
            // 
            // RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1160, 340);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "RaceForm";
            this.Text = "Race";
            this.panel1.ResumeLayout(false);
            this.PanelFinish.ResumeLayout(false);
            this.PanelFinish.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBella;
        private System.Windows.Forms.Button btnAlex;
        private System.Windows.Forms.Button btnLady;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelFinish;
        private System.Windows.Forms.Label lblFinish;
    }
}

