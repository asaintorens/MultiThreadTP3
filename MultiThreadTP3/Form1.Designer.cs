namespace MultiThreadTP3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewNonTrier = new System.Windows.Forms.ListView();
            this.listViewTrier = new System.Windows.Forms.ListView();
            this.buttonValoriser = new System.Windows.Forms.Button();
            this.buttonTrier = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewNonTrier
            // 
            this.listViewNonTrier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewNonTrier.Location = new System.Drawing.Point(46, 57);
            this.listViewNonTrier.Name = "listViewNonTrier";
            this.listViewNonTrier.Size = new System.Drawing.Size(272, 417);
            this.listViewNonTrier.TabIndex = 0;
            this.listViewNonTrier.UseCompatibleStateImageBehavior = false;
            this.listViewNonTrier.View = System.Windows.Forms.View.Details;
            // 
            // listViewTrier
            // 
            this.listViewTrier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewTrier.Location = new System.Drawing.Point(672, 57);
            this.listViewTrier.Name = "listViewTrier";
            this.listViewTrier.Size = new System.Drawing.Size(272, 417);
            this.listViewTrier.TabIndex = 1;
            this.listViewTrier.UseCompatibleStateImageBehavior = false;
            this.listViewTrier.View = System.Windows.Forms.View.Details;
            // 
            // buttonValoriser
            // 
            this.buttonValoriser.Location = new System.Drawing.Point(453, 57);
            this.buttonValoriser.Name = "buttonValoriser";
            this.buttonValoriser.Size = new System.Drawing.Size(75, 23);
            this.buttonValoriser.TabIndex = 2;
            this.buttonValoriser.Text = "Valoriser";
            this.buttonValoriser.UseVisualStyleBackColor = true;
            this.buttonValoriser.Click += new System.EventHandler(this.buttonValoriser_Click);
            // 
            // buttonTrier
            // 
            this.buttonTrier.Location = new System.Drawing.Point(453, 107);
            this.buttonTrier.Name = "buttonTrier";
            this.buttonTrier.Size = new System.Drawing.Size(75, 23);
            this.buttonTrier.TabIndex = 3;
            this.buttonTrier.Text = "Trier";
            this.buttonTrier.UseVisualStyleBackColor = true;
            this.buttonTrier.Click += new System.EventHandler(this.buttonTrier_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre non trié";
            this.columnHeader1.Width = 132;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "1000";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre triés";
            this.columnHeader2.Width = 163;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 505);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTrier);
            this.Controls.Add(this.buttonValoriser);
            this.Controls.Add(this.listViewTrier);
            this.Controls.Add(this.listViewNonTrier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewNonTrier;
        private System.Windows.Forms.ListView listViewTrier;
        private System.Windows.Forms.Button buttonValoriser;
        private System.Windows.Forms.Button buttonTrier;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

