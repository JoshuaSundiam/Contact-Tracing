namespace Contact_Tracing
{
    partial class Form2
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
            this.Sbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DataBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateSet = new System.Windows.Forms.DateTimePicker();
            this.Clrbtn = new System.Windows.Forms.Button();
            this.SearchInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Sbox
            // 
            this.Sbox.Location = new System.Drawing.Point(48, 12);
            this.Sbox.Name = "Sbox";
            this.Sbox.Size = new System.Drawing.Size(408, 27);
            this.Sbox.TabIndex = 2;
            this.Sbox.TextChanged += new System.EventHandler(this.Sbox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(478, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataBox
            // 
            this.DataBox.Location = new System.Drawing.Point(48, 130);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(408, 308);
            this.DataBox.TabIndex = 4;
            this.DataBox.Text = "";
            this.DataBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(179, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter a Name";
            // 
            // DateSet
            // 
            this.DateSet.Location = new System.Drawing.Point(48, 65);
            this.DateSet.Name = "DateSet";
            this.DateSet.Size = new System.Drawing.Size(250, 27);
            this.DateSet.TabIndex = 6;
            this.DateSet.ValueChanged += new System.EventHandler(this.DateSet_ValueChanged);
            // 
            // Clrbtn
            // 
            this.Clrbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clrbtn.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clrbtn.Location = new System.Drawing.Point(478, 65);
            this.Clrbtn.Name = "Clrbtn";
            this.Clrbtn.Size = new System.Drawing.Size(261, 49);
            this.Clrbtn.TabIndex = 7;
            this.Clrbtn.Text = "Clear";
            this.Clrbtn.UseVisualStyleBackColor = false;
            this.Clrbtn.Click += new System.EventHandler(this.Clrbtn_Click);
            // 
            // SearchInfo
            // 
            this.SearchInfo.Location = new System.Drawing.Point(478, 130);
            this.SearchInfo.Name = "SearchInfo";
            this.SearchInfo.Size = new System.Drawing.Size(271, 308);
            this.SearchInfo.TabIndex = 8;
            this.SearchInfo.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing.Properties.Resources.Screenshot_2022_06_10_2214141;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchInfo);
            this.Controls.Add(this.Clrbtn);
            this.Controls.Add(this.DateSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sbox);
            this.Name = "Form2";
            this.Text = "Contact Tracing";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox Sbox;
        private Button button1;
        private RichTextBox DataBox;
        private Label label1;
        private DateTimePicker DateSet;
        private Button Clrbtn;
        private RichTextBox SearchInfo;
    }
}