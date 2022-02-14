
namespace KeyCheckGui.Dialogs
{
    partial class CheckedImagesIdsDialog
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
            System.Windows.Forms.ListBox resultList;
            this.openImagesGroup = new System.Windows.Forms.GroupBox();
            this.svgImageButton = new System.Windows.Forms.Button();
            this.pngImageButton = new System.Windows.Forms.Button();
            this.svgImageLink = new System.Windows.Forms.LinkLabel();
            this.resultGroup = new System.Windows.Forms.GroupBox();
            this.resultShowButton = new System.Windows.Forms.Button();
            this.resultTypeBox = new System.Windows.Forms.ComboBox();
            this.resultList2 = new System.Windows.Forms.TextBox();
            this.resultList = new System.Windows.Forms.ListBox();
            this.openImagesGroup.SuspendLayout();
            this.resultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultList
            // 
            this.resultList.FormattingEnabled = true;
            this.resultList.ItemHeight = 15;
            this.resultList.Location = new System.Drawing.Point(6, 51);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(303, 304);
            this.resultList.TabIndex = 20;
            // 
            // openImagesGroup
            // 
            this.openImagesGroup.Controls.Add(this.svgImageButton);
            this.openImagesGroup.Controls.Add(this.pngImageButton);
            this.openImagesGroup.Controls.Add(this.svgImageLink);
            this.openImagesGroup.Location = new System.Drawing.Point(741, 12);
            this.openImagesGroup.Name = "openImagesGroup";
            this.openImagesGroup.Size = new System.Drawing.Size(200, 100);
            this.openImagesGroup.TabIndex = 17;
            this.openImagesGroup.TabStop = false;
            this.openImagesGroup.Text = "Open selected in new window";
            // 
            // svgImageButton
            // 
            this.svgImageButton.Location = new System.Drawing.Point(7, 53);
            this.svgImageButton.Name = "svgImageButton";
            this.svgImageButton.Size = new System.Drawing.Size(75, 23);
            this.svgImageButton.TabIndex = 1;
            this.svgImageButton.Text = "Svg";
            this.svgImageButton.UseVisualStyleBackColor = true;
            this.svgImageButton.Click += new System.EventHandler(this.OnSvgImageButton_Click);
            // 
            // pngImageButton
            // 
            this.pngImageButton.Location = new System.Drawing.Point(7, 23);
            this.pngImageButton.Name = "pngImageButton";
            this.pngImageButton.Size = new System.Drawing.Size(75, 23);
            this.pngImageButton.TabIndex = 0;
            this.pngImageButton.Text = "Png";
            this.pngImageButton.UseVisualStyleBackColor = true;
            this.pngImageButton.Click += new System.EventHandler(this.OnPngImageButton_Click);
            // 
            // svgImageLink
            // 
            this.svgImageLink.AutoSize = true;
            this.svgImageLink.Location = new System.Drawing.Point(108, 61);
            this.svgImageLink.Name = "svgImageLink";
            this.svgImageLink.Size = new System.Drawing.Size(48, 15);
            this.svgImageLink.TabIndex = 13;
            this.svgImageLink.TabStop = true;
            this.svgImageLink.Text = "Svg link";
            this.svgImageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnSvgLink_LinkClick);
            // 

            // resultGroup
            // 
            this.resultGroup.Controls.Add(this.resultList);
            this.resultGroup.Controls.Add(this.resultShowButton);
            this.resultGroup.Controls.Add(this.resultTypeBox);
            this.resultGroup.Location = new System.Drawing.Point(12, 12);
            this.resultGroup.Name = "resultGroup";
            this.resultGroup.Size = new System.Drawing.Size(315, 440);
            this.resultGroup.TabIndex = 19;
            this.resultGroup.TabStop = false;
            this.resultGroup.Text = "Select result type and element";
            // 
            // resultShowButton
            // 
            this.resultShowButton.Location = new System.Drawing.Point(6, 357);
            this.resultShowButton.Name = "resultShowButton";
            this.resultShowButton.Size = new System.Drawing.Size(303, 77);
            this.resultShowButton.TabIndex = 3;
            this.resultShowButton.Text = "Show result data";
            this.resultShowButton.UseVisualStyleBackColor = true;
            // 
            // resultTypeBox
            // 
            this.resultTypeBox.FormattingEnabled = true;
            this.resultTypeBox.Location = new System.Drawing.Point(6, 22);
            this.resultTypeBox.Name = "resultTypeBox";
            this.resultTypeBox.Size = new System.Drawing.Size(303, 23);
            this.resultTypeBox.TabIndex = 3;
            this.resultTypeBox.Text = "result type";
            // 
            // resultList2
            // 
            this.resultList2.AllowDrop = true;
            this.resultList2.HideSelection = false;
            this.resultList2.Location = new System.Drawing.Point(550, 179);
            this.resultList2.Multiline = true;
            this.resultList2.Name = "resultList2";
            this.resultList2.ReadOnly = true;
            this.resultList2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultList2.Size = new System.Drawing.Size(303, 300);
            this.resultList2.TabIndex = 2;
            this.resultList2.TabStop = false;
            // 
            // CheckedImagesIdsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 491);
            this.Controls.Add(this.resultGroup);
            this.Controls.Add(this.resultList2);
            this.Controls.Add(this.openImagesGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckedImagesIdsDialog";
            this.ShowIcon = false;
            this.Text = "Not used images";
            this.openImagesGroup.ResumeLayout(false);
            this.openImagesGroup.PerformLayout();
            this.resultGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox openImagesGroup;
        private System.Windows.Forms.Button svgImageButton;
        private System.Windows.Forms.Button pngImageButton;
        private System.Windows.Forms.LinkLabel svgImageLink;
        internal System.Windows.Forms.GroupBox resultGroup;
        internal System.Windows.Forms.Button resultShowButton;
        internal System.Windows.Forms.ComboBox resultTypeBox;
        internal System.Windows.Forms.TextBox resultList2;
        private System.Windows.Forms.ListBox resultList;
    }
}