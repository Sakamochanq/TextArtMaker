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
            this.OpenButton = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.OriginPictureBox = new System.Windows.Forms.PictureBox();
            this.GrayScalePictureBox = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PreviewTextBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OriginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayScalePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(526, 25);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(126, 31);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Load Image";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // PathBox
            // 
            this.PathBox.BackColor = System.Drawing.Color.White;
            this.PathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathBox.Location = new System.Drawing.Point(12, 25);
            this.PathBox.Name = "PathBox";
            this.PathBox.ReadOnly = true;
            this.PathBox.Size = new System.Drawing.Size(502, 19);
            this.PathBox.TabIndex = 1;
            this.PathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OriginPictureBox
            // 
            this.OriginPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OriginPictureBox.Location = new System.Drawing.Point(12, 65);
            this.OriginPictureBox.Name = "OriginPictureBox";
            this.OriginPictureBox.Size = new System.Drawing.Size(243, 156);
            this.OriginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginPictureBox.TabIndex = 3;
            this.OriginPictureBox.TabStop = false;
            // 
            // GrayScalePictureBox
            // 
            this.GrayScalePictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GrayScalePictureBox.Location = new System.Drawing.Point(271, 65);
            this.GrayScalePictureBox.Name = "GrayScalePictureBox";
            this.GrayScalePictureBox.Size = new System.Drawing.Size(243, 156);
            this.GrayScalePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GrayScalePictureBox.TabIndex = 4;
            this.GrayScalePictureBox.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(526, 65);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(126, 31);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Origin：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(268, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grayscale：";
            // 
            // PreviewTextBox
            // 
            this.PreviewTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewTextBox.Location = new System.Drawing.Point(12, 281);
            this.PreviewTextBox.Multiline = true;
            this.PreviewTextBox.Name = "PreviewTextBox";
            this.PreviewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PreviewTextBox.Size = new System.Drawing.Size(496, 398);
            this.PreviewTextBox.TabIndex = 0;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(514, 376);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(126, 31);
            this.ConvertButton.TabIndex = 8;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 691);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.PreviewTextBox);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.GrayScalePictureBox);
            this.Controls.Add(this.OriginPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Art Maker   |   Sakamochanq";
            ((System.ComponentModel.ISupportInitialize)(this.OriginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayScalePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.PictureBox OriginPictureBox;
        private System.Windows.Forms.PictureBox GrayScalePictureBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreviewTextBox;
        private System.Windows.Forms.Button ConvertButton;
    }
}

