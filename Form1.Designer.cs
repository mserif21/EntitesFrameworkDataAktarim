namespace EntitesFrameworkDataAktarım
{
    partial class Form1
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
            this.tum_siparisler = new System.Windows.Forms.Button();
            this.ilk5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tum_siparisler
            // 
            this.tum_siparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tum_siparisler.Location = new System.Drawing.Point(100, 29);
            this.tum_siparisler.Name = "tum_siparisler";
            this.tum_siparisler.Size = new System.Drawing.Size(118, 95);
            this.tum_siparisler.TabIndex = 0;
            this.tum_siparisler.Text = "Tüm Siparişler";
            this.tum_siparisler.UseVisualStyleBackColor = true;
            this.tum_siparisler.Click += new System.EventHandler(this.tum_siparisler_Click);
            // 
            // ilk5
            // 
            this.ilk5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilk5.Location = new System.Drawing.Point(370, 29);
            this.ilk5.Name = "ilk5";
            this.ilk5.Size = new System.Drawing.Size(118, 95);
            this.ilk5.TabIndex = 1;
            this.ilk5.Text = "İlk 5 Sipariş";
            this.ilk5.UseVisualStyleBackColor = true;
            this.ilk5.Click += new System.EventHandler(this.ilk5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 290);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ilk5);
            this.Controls.Add(this.tum_siparisler);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tum_siparisler;
        private System.Windows.Forms.Button ilk5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

