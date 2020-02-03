namespace anagram
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.GoButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.progress_l = new System.Windows.Forms.Label();
            this.stat = new System.Windows.Forms.Label();
            this.debugL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(348, 76);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "GO!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.OnGoClick);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(191, 76);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(151, 22);
            this.InputBox.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(191, 153);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(232, 97);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(269, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(86, 17);
            this.title.TabIndex = 3;
            this.title.Text = "ANAGRAMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your word:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(475, 153);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(52, 17);
            this.status.TabIndex = 7;
            this.status.Text = "Status:";
            // 
            // progress_l
            // 
            this.progress_l.AutoSize = true;
            this.progress_l.Location = new System.Drawing.Point(475, 82);
            this.progress_l.Name = "progress_l";
            this.progress_l.Size = new System.Drawing.Size(69, 17);
            this.progress_l.TabIndex = 8;
            this.progress_l.Text = "Progress:";
            // 
            // stat
            // 
            this.stat.AutoSize = true;
            this.stat.Location = new System.Drawing.Point(555, 153);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(83, 17);
            this.stat.TabIndex = 10;
            this.stat.Text = "---------------";
            // 
            // debugL
            // 
            this.debugL.AutoSize = true;
            this.debugL.Location = new System.Drawing.Point(221, 336);
            this.debugL.Name = "debugL";
            this.debugL.Size = new System.Drawing.Size(46, 17);
            this.debugL.TabIndex = 11;
            this.debugL.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debugL);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.progress_l);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.GoButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label progress_l;
        private System.Windows.Forms.Label stat;
        private System.Windows.Forms.Label debugL;
    }
}

