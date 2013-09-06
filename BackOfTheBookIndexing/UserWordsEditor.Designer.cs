namespace BackOfTheBookIndexing
{
    partial class UserWordsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWordsEditor));
            this.UnDeleteWordBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.AfterDeleteListWordBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.MGWListbox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.UFWListbox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.DeleteWordBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.FGWListbox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.UWEProceedBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // UnDeleteWordBtn
            // 
            this.UnDeleteWordBtn.Location = new System.Drawing.Point(283, 310);
            this.UnDeleteWordBtn.Name = "UnDeleteWordBtn";
            this.UnDeleteWordBtn.Size = new System.Drawing.Size(50, 41);
            this.UnDeleteWordBtn.TabIndex = 2;
            this.UnDeleteWordBtn.Values.Text = "----";
            this.UnDeleteWordBtn.Click += new System.EventHandler(this.UnDeleteWordBtn_Click);
            // 
            // AfterDeleteListWordBtn
            // 
            this.AfterDeleteListWordBtn.Location = new System.Drawing.Point(610, 193);
            this.AfterDeleteListWordBtn.Name = "AfterDeleteListWordBtn";
            this.AfterDeleteListWordBtn.Size = new System.Drawing.Size(50, 41);
            this.AfterDeleteListWordBtn.TabIndex = 3;
            this.AfterDeleteListWordBtn.Values.Text = "=";
            this.AfterDeleteListWordBtn.Click += new System.EventHandler(this.AfterDeleteListWordBtn_Click);
            // 
            // MGWListbox
            // 
            this.MGWListbox.Location = new System.Drawing.Point(12, 12);
            this.MGWListbox.Name = "MGWListbox";
            this.MGWListbox.Size = new System.Drawing.Size(265, 458);
            this.MGWListbox.TabIndex = 4;
            // 
            // UFWListbox
            // 
            this.UFWListbox.Location = new System.Drawing.Point(339, 12);
            this.UFWListbox.Name = "UFWListbox";
            this.UFWListbox.Size = new System.Drawing.Size(265, 458);
            this.UFWListbox.TabIndex = 5;
            // 
            // DeleteWordBtn
            // 
            this.DeleteWordBtn.Location = new System.Drawing.Point(283, 78);
            this.DeleteWordBtn.Name = "DeleteWordBtn";
            this.DeleteWordBtn.Size = new System.Drawing.Size(50, 41);
            this.DeleteWordBtn.TabIndex = 6;
            this.DeleteWordBtn.Values.Text = "---->";
            this.DeleteWordBtn.Click += new System.EventHandler(this.DeleteWordBtn_Click_1);
            // 
            // FGWListbox
            // 
            this.FGWListbox.Location = new System.Drawing.Point(669, 12);
            this.FGWListbox.Name = "FGWListbox";
            this.FGWListbox.Size = new System.Drawing.Size(265, 458);
            this.FGWListbox.TabIndex = 7;
            // 
            // UWEProceedBtn
            // 
            this.UWEProceedBtn.Location = new System.Drawing.Point(844, 476);
            this.UWEProceedBtn.Name = "UWEProceedBtn";
            this.UWEProceedBtn.Size = new System.Drawing.Size(90, 33);
            this.UWEProceedBtn.TabIndex = 8;
            this.UWEProceedBtn.Values.Text = "Proceed>>>";
            this.UWEProceedBtn.Click += new System.EventHandler(this.UWEProceedBtn_Click);
            // 
            // UserWordsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 515);
            this.Controls.Add(this.UWEProceedBtn);
            this.Controls.Add(this.FGWListbox);
            this.Controls.Add(this.DeleteWordBtn);
            this.Controls.Add(this.UFWListbox);
            this.Controls.Add(this.MGWListbox);
            this.Controls.Add(this.AfterDeleteListWordBtn);
            this.Controls.Add(this.UnDeleteWordBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserWordsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Words Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton UnDeleteWordBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AfterDeleteListWordBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox MGWListbox;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox UFWListbox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton DeleteWordBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox FGWListbox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton UWEProceedBtn;
    }
}