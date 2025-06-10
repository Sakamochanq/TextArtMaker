namespace TextArtMaker
{
    partial class Source
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.OriginPictureBox = new System.Windows.Forms.PictureBox();
            this.ResultPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ScaleTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.StyleSelectBox = new System.Windows.Forms.ComboBox();
            this.menustrip = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.stripImageLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.stripScaleLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stripStyleLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.OriginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleTrackBar)).BeginInit();
            this.menustrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // OriginPictureBox
            // 
            this.OriginPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OriginPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.OriginPictureBox.Location = new System.Drawing.Point(212, 43);
            this.OriginPictureBox.Name = "OriginPictureBox";
            this.OriginPictureBox.Size = new System.Drawing.Size(243, 156);
            this.OriginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginPictureBox.TabIndex = 3;
            this.OriginPictureBox.TabStop = false;
            // 
            // ResultPictureBox
            // 
            this.ResultPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResultPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ResultPictureBox.Location = new System.Drawing.Point(471, 43);
            this.ResultPictureBox.Name = "ResultPictureBox";
            this.ResultPictureBox.Size = new System.Drawing.Size(243, 156);
            this.ResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResultPictureBox.TabIndex = 4;
            this.ResultPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(212, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Origin：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(468, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result：";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(582, 252);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(132, 34);
            this.ConvertButton.TabIndex = 8;
            this.ConvertButton.Text = "ASCI I に変換";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ScaleTrackBar
            // 
            this.ScaleTrackBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ScaleTrackBar.Location = new System.Drawing.Point(16, 70);
            this.ScaleTrackBar.Maximum = 100;
            this.ScaleTrackBar.Name = "ScaleTrackBar";
            this.ScaleTrackBar.Size = new System.Drawing.Size(158, 45);
            this.ScaleTrackBar.TabIndex = 9;
            this.ScaleTrackBar.TickFrequency = 10;
            this.ScaleTrackBar.UseWaitCursor = true;
            this.ScaleTrackBar.Value = 20;
            this.ScaleTrackBar.Scroll += new System.EventHandler(this.ScaleTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(21, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "画像スタイル：";
            // 
            // StyleSelectBox
            // 
            this.StyleSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StyleSelectBox.FormattingEnabled = true;
            this.StyleSelectBox.Location = new System.Drawing.Point(24, 165);
            this.StyleSelectBox.Name = "StyleSelectBox";
            this.StyleSelectBox.Size = new System.Drawing.Size(147, 20);
            this.StyleSelectBox.TabIndex = 13;
            this.StyleSelectBox.SelectedIndexChanged += new System.EventHandler(this.StyleSelectBox_SelectedIndexChanged);
            // 
            // menustrip
            // 
            this.menustrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menustrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem});
            this.menustrip.Location = new System.Drawing.Point(0, 0);
            this.menustrip.Name = "menustrip";
            this.menustrip.Size = new System.Drawing.Size(733, 24);
            this.menustrip.TabIndex = 14;
            this.menustrip.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton,
            this.名前を付けて保存ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.終了ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル（F）";
            // 
            // OpenButton
            // 
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenButton.Size = new System.Drawing.Size(180, 22);
            this.OpenButton.Text = "開く";
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.名前を付けて保存ToolStripMenuItem1});
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            this.名前を付けて保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.名前を付けて保存ToolStripMenuItem.Text = "保存";
            // 
            // 名前を付けて保存ToolStripMenuItem1
            // 
            this.名前を付けて保存ToolStripMenuItem1.Name = "名前を付けて保存ToolStripMenuItem1";
            this.名前を付けて保存ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.名前を付けて保存ToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.名前を付けて保存ToolStripMenuItem1.Text = "名前を付けて保存";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearButton});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.編集EToolStripMenuItem.Text = "編集（E）";
            // 
            // ClearButton
            // 
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.ClearButton.Size = new System.Drawing.Size(188, 22);
            this.ClearButton.Text = "画像の削除";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.ScaleLabel);
            this.panel1.Controls.Add(this.StyleSelectBox);
            this.panel1.Controls.Add(this.ScaleTrackBar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 306);
            this.panel1.TabIndex = 15;
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ScaleLabel.Location = new System.Drawing.Point(21, 42);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(150, 13);
            this.ScaleLabel.TabIndex = 16;
            this.ScaleLabel.Text = "ASCI I の全体サイズ： 20 %";
            // 
            // toolstrip
            // 
            this.toolstrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.stripImageLabel,
            this.toolStripLabel3,
            this.toolStripSeparator1,
            this.toolStripLabel4,
            this.stripScaleLabel,
            this.toolStripLabel6,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.stripStyleLabel});
            this.toolstrip.Location = new System.Drawing.Point(193, 305);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(540, 25);
            this.toolstrip.TabIndex = 16;
            this.toolstrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel1.Text = " ";
            // 
            // stripImageLabel
            // 
            this.stripImageLabel.Name = "stripImageLabel";
            this.stripImageLabel.Size = new System.Drawing.Size(71, 22);
            this.stripImageLabel.Text = "Image：null";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel3.Text = " ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel4.Text = " ";
            // 
            // stripScaleLabel
            // 
            this.stripScaleLabel.Name = "stripScaleLabel";
            this.stripScaleLabel.Size = new System.Drawing.Size(68, 22);
            this.stripScaleLabel.Text = "Scale：20%";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel6.Text = " ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // stripStyleLabel
            // 
            this.stripStyleLabel.Name = "stripStyleLabel";
            this.stripStyleLabel.Size = new System.Drawing.Size(98, 22);
            this.stripStyleLabel.Text = " Style：GrayScale";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel2.Text = " ";
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 330);
            this.Controls.Add(this.toolstrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menustrip);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultPictureBox);
            this.Controls.Add(this.OriginPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menustrip;
            this.MaximizeBox = false;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Art Maker   |   Sakamochanq";
            ((System.ComponentModel.ISupportInitialize)(this.OriginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleTrackBar)).EndInit();
            this.menustrip.ResumeLayout(false);
            this.menustrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox OriginPictureBox;
        private System.Windows.Forms.PictureBox ResultPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TrackBar ScaleTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StyleSelectBox;
        private System.Windows.Forms.MenuStrip menustrip;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenButton;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel stripImageLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel stripScaleLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel stripStyleLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

