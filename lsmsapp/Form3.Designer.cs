namespace lsmsapp
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sendbtn = new System.Windows.Forms.Button();
            this.cbname = new System.Windows.Forms.ComboBox();
            this.cbdptid = new System.Windows.Forms.ComboBox();
            this.cbauthor = new System.Windows.Forms.ComboBox();
            this.cbsem = new System.Windows.Forms.ComboBox();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BookName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "BookID       :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "DeptID       :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author       :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "semester   :";
            // 
            // sendbtn
            // 
            this.sendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.Location = new System.Drawing.Point(486, 383);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(86, 34);
            this.sendbtn.TabIndex = 10;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // cbname
            // 
            this.cbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbname.FormattingEnabled = true;
            this.cbname.Location = new System.Drawing.Point(157, 67);
            this.cbname.Name = "cbname";
            this.cbname.Size = new System.Drawing.Size(304, 28);
            this.cbname.TabIndex = 11;
            this.cbname.SelectedIndexChanged += new System.EventHandler(this.cbname_SelectedIndexChanged);
            // 
            // cbdptid
            // 
            this.cbdptid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdptid.FormattingEnabled = true;
            this.cbdptid.Location = new System.Drawing.Point(157, 212);
            this.cbdptid.Name = "cbdptid";
            this.cbdptid.Size = new System.Drawing.Size(304, 28);
            this.cbdptid.TabIndex = 13;
            this.cbdptid.SelectedIndexChanged += new System.EventHandler(this.cbdptid_SelectedIndexChanged);
            // 
            // cbauthor
            // 
            this.cbauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbauthor.FormattingEnabled = true;
            this.cbauthor.Location = new System.Drawing.Point(157, 286);
            this.cbauthor.Name = "cbauthor";
            this.cbauthor.Size = new System.Drawing.Size(304, 28);
            this.cbauthor.TabIndex = 14;
            this.cbauthor.SelectedIndexChanged += new System.EventHandler(this.cbauthor_SelectedIndexChanged);
            // 
            // cbsem
            // 
            this.cbsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsem.FormattingEnabled = true;
            this.cbsem.Location = new System.Drawing.Point(157, 349);
            this.cbsem.Name = "cbsem";
            this.cbsem.Size = new System.Drawing.Size(304, 28);
            this.cbsem.TabIndex = 15;
            this.cbsem.SelectedIndexChanged += new System.EventHandler(this.cbsem_SelectedIndexChanged);
            // 
            // cbid
            // 
            this.cbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(157, 130);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(304, 28);
            this.cbid.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "dept\tid",
            "cse\t1000",
            "ece\t2000",
            "eee\t3000",
            "mech\t4000",
            "ecm\t5000"});
            this.listBox1.Location = new System.Drawing.Point(560, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 124);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(703, 441);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.cbsem);
            this.Controls.Add(this.cbauthor);
            this.Controls.Add(this.cbdptid);
            this.Controls.Add(this.cbname);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "SMS Request form";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.ComboBox cbname;
        private System.Windows.Forms.ComboBox cbdptid;
        private System.Windows.Forms.ComboBox cbauthor;
        private System.Windows.Forms.ComboBox cbsem;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.ListBox listBox1;
    }
}