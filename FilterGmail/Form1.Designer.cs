
namespace FilterGmail
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
            this.generate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addFrom = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailCounter = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.clear = new System.Windows.Forms.Button();
            this.subjectcounter = new System.Windows.Forms.Label();
            this.subjectbtn = new System.Windows.Forms.Button();
            this.subjecttxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(339, 480);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 13;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Is:";
            // 
            // addFrom
            // 
            this.addFrom.Location = new System.Drawing.Point(284, 32);
            this.addFrom.Name = "addFrom";
            this.addFrom.Size = new System.Drawing.Size(75, 23);
            this.addFrom.TabIndex = 9;
            this.addFrom.Text = "Add";
            this.addFrom.UseVisualStyleBackColor = true;
            this.addFrom.Click += new System.EventHandler(this.addFrom_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(78, 34);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(200, 20);
            this.txtFrom.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "From: ";
            // 
            // emailCounter
            // 
            this.emailCounter.AutoSize = true;
            this.emailCounter.Location = new System.Drawing.Point(365, 37);
            this.emailCounter.Name = "emailCounter";
            this.emailCounter.Size = new System.Drawing.Size(13, 13);
            this.emailCounter.TabIndex = 14;
            this.emailCounter.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(385, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "is:important",
            "is:starred",
            "is:snoozed",
            "is:unread",
            "is:read",
            "is:inbox",
            "is:draft ",
            "is:sent "});
            this.checkedListBox1.Location = new System.Drawing.Point(78, 72);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 79);
            this.checkedListBox1.TabIndex = 17;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 480);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 18;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // subjectcounter
            // 
            this.subjectcounter.AutoSize = true;
            this.subjectcounter.Location = new System.Drawing.Point(365, 177);
            this.subjectcounter.Name = "subjectcounter";
            this.subjectcounter.Size = new System.Drawing.Size(13, 13);
            this.subjectcounter.TabIndex = 22;
            this.subjectcounter.Text = "0";
            // 
            // subjectbtn
            // 
            this.subjectbtn.Location = new System.Drawing.Point(284, 172);
            this.subjectbtn.Name = "subjectbtn";
            this.subjectbtn.Size = new System.Drawing.Size(75, 23);
            this.subjectbtn.TabIndex = 21;
            this.subjectbtn.Text = "Add";
            this.subjectbtn.UseVisualStyleBackColor = true;
            this.subjectbtn.Click += new System.EventHandler(this.subjectbtn_Click);
            // 
            // subjecttxt
            // 
            this.subjecttxt.Location = new System.Drawing.Point(78, 174);
            this.subjecttxt.Name = "subjecttxt";
            this.subjecttxt.Size = new System.Drawing.Size(200, 20);
            this.subjecttxt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Subjetcs: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 515);
            this.Controls.Add(this.subjectcounter);
            this.Controls.Add(this.subjectbtn);
            this.Controls.Add(this.subjecttxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.emailCounter);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addFrom);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Filter Gmail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailCounter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label subjectcounter;
        private System.Windows.Forms.Button subjectbtn;
        private System.Windows.Forms.TextBox subjecttxt;
        private System.Windows.Forms.Label label4;
    }
}

