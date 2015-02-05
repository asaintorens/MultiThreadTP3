namespace MultiThreadTP3
{
    partial class FormProgression
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.backgroundWorkerTrie = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(64, 60);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(839, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(685, 191);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Enabled = false;
            this.buttonOk.Location = new System.Drawing.Point(828, 191);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // backgroundWorkerTrie
            // 
            this.backgroundWorkerTrie.WorkerReportsProgress = true;
            this.backgroundWorkerTrie.WorkerSupportsCancellation = true;
            this.backgroundWorkerTrie.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTrie_DoWork);
            this.backgroundWorkerTrie.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerTrie_ProgressChanged);
            this.backgroundWorkerTrie.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerTrie_RunWorkerCompleted);
            // 
            // FormProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 255);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.progressBar1);
            this.Name = "FormProgression";
            this.Text = "FormProgression";
            this.Load += new System.EventHandler(this.FormProgression_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonOk;
        public System.ComponentModel.BackgroundWorker backgroundWorkerTrie;
    }
}