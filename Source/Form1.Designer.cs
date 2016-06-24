namespace Music_Genre_Grouper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileFolderTextbox1 = new FileFolderTextbox();
            this.StartButton = new System.Windows.Forms.Button();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CreateM3UCheckbox = new System.Windows.Forms.CheckBox();
            this.ChangeGenreCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileFolderTextbox1
            // 
            this.fileFolderTextbox1.AbsolutePath = "H:\\Music";
            this.fileFolderTextbox1.AllowFiles = false;
            this.fileFolderTextbox1.AutoCompleteList = null;
            this.fileFolderTextbox1.Label = "Select folder:";
            this.fileFolderTextbox1.Location = new System.Drawing.Point(12, 12);
            this.fileFolderTextbox1.Name = "fileFolderTextbox1";
            this.fileFolderTextbox1.RecentItemsString = "H:|H:\\Music";
            this.fileFolderTextbox1.RelativeBasePath = "";
            this.fileFolderTextbox1.Size = new System.Drawing.Size(503, 21);
            this.fileFolderTextbox1.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(440, 340);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // objectListView1
            // 
            this.objectListView1.Location = new System.Drawing.Point(12, 39);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(503, 164);
            this.objectListView1.TabIndex = 2;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 209);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(503, 125);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // CreateM3UCheckbox
            // 
            this.CreateM3UCheckbox.AutoSize = true;
            this.CreateM3UCheckbox.Checked = true;
            this.CreateM3UCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreateM3UCheckbox.Location = new System.Drawing.Point(14, 341);
            this.CreateM3UCheckbox.Name = "CreateM3UCheckbox";
            this.CreateM3UCheckbox.Size = new System.Drawing.Size(80, 17);
            this.CreateM3UCheckbox.TabIndex = 4;
            this.CreateM3UCheckbox.Text = "Create m3u";
            this.CreateM3UCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChangeGenreCheckbox
            // 
            this.ChangeGenreCheckbox.AutoSize = true;
            this.ChangeGenreCheckbox.Location = new System.Drawing.Point(126, 340);
            this.ChangeGenreCheckbox.Name = "ChangeGenreCheckbox";
            this.ChangeGenreCheckbox.Size = new System.Drawing.Size(93, 17);
            this.ChangeGenreCheckbox.TabIndex = 5;
            this.ChangeGenreCheckbox.Text = "Change genre";
            this.ChangeGenreCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 375);
            this.Controls.Add(this.ChangeGenreCheckbox);
            this.Controls.Add(this.CreateM3UCheckbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.fileFolderTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileFolderTextbox fileFolderTextbox1;
        private System.Windows.Forms.Button StartButton;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox CreateM3UCheckbox;
        private System.Windows.Forms.CheckBox ChangeGenreCheckbox;
    }
}

