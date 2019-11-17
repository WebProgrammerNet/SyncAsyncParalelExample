namespace AsyncSyncTask
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
            this.btnResult = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnParalel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(584, 12);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(226, 76);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "button1";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSync
            // 
            this.btnSync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.Location = new System.Drawing.Point(12, 159);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(252, 79);
            this.btnSync.TabIndex = 1;
            this.btnSync.Text = "Get Content  URL  SYNC";
            this.btnSync.UseVisualStyleBackColor = false;
            this.btnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(253, 282);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 147);
            this.listBox1.TabIndex = 4;
            // 
            // btnAsync
            // 
            this.btnAsync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsync.ForeColor = System.Drawing.Color.White;
            this.btnAsync.Location = new System.Drawing.Point(281, 159);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(252, 79);
            this.btnAsync.TabIndex = 5;
            this.btnAsync.Text = "Get Content  URL  ASYNC";
            this.btnAsync.UseVisualStyleBackColor = false;
            this.btnAsync.Click += new System.EventHandler(this.BtnAsync_Click);
            // 
            // btnParalel
            // 
            this.btnParalel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnParalel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParalel.ForeColor = System.Drawing.Color.White;
            this.btnParalel.Location = new System.Drawing.Point(567, 159);
            this.btnParalel.Name = "btnParalel";
            this.btnParalel.Size = new System.Drawing.Size(252, 79);
            this.btnParalel.TabIndex = 6;
            this.btnParalel.Text = "Get Content  URL   Paralel";
            this.btnParalel.UseVisualStyleBackColor = false;
            this.btnParalel.Click += new System.EventHandler(this.BtnParalel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 475);
            this.Controls.Add(this.btnParalel);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnResult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnParalel;
    }
}

