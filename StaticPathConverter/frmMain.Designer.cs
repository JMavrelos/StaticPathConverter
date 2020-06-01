namespace StaticPathConverter
{
    partial class frmMain
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
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.txtStatic = new System.Windows.Forms.TextBox();
            this.txtRelative = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.chkNoMove = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter
            // 
            this.splitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitter.Location = new System.Drawing.Point(12, 12);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.txtStatic);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.txtRelative);
            this.splitter.Size = new System.Drawing.Size(776, 397);
            this.splitter.SplitterDistance = 437;
            this.splitter.TabIndex = 0;
            // 
            // txtStatic
            // 
            this.txtStatic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatic.Location = new System.Drawing.Point(0, 0);
            this.txtStatic.Multiline = true;
            this.txtStatic.Name = "txtStatic";
            this.txtStatic.Size = new System.Drawing.Size(437, 397);
            this.txtStatic.TabIndex = 0;
            // 
            // txtRelative
            // 
            this.txtRelative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRelative.Location = new System.Drawing.Point(0, 0);
            this.txtRelative.Multiline = true;
            this.txtRelative.Name = "txtRelative";
            this.txtRelative.ReadOnly = true;
            this.txtRelative.Size = new System.Drawing.Size(335, 397);
            this.txtRelative.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(713, 415);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // chkNoMove
            // 
            this.chkNoMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNoMove.AutoSize = true;
            this.chkNoMove.Checked = true;
            this.chkNoMove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNoMove.Location = new System.Drawing.Point(627, 419);
            this.chkNoMove.Name = "chkNoMove";
            this.chkNoMove.Size = new System.Drawing.Size(82, 17);
            this.chkNoMove.TabIndex = 2;
            this.chkNoMove.Text = "Skip Moves";
            this.chkNoMove.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkNoMove);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.splitter);
            this.Name = "frmMain";
            this.Text = "Static Path Converter";
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel1.PerformLayout();
            this.splitter.Panel2.ResumeLayout(false);
            this.splitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.TextBox txtStatic;
        private System.Windows.Forms.TextBox txtRelative;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.CheckBox chkNoMove;
    }
}

