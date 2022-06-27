
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
            this.resultList = new System.Windows.Forms.ListBox();
            this.imageInfoGroup = new System.Windows.Forms.GroupBox();
            this.pngLinkLabel = new System.Windows.Forms.Label();
            this.pngLink = new System.Windows.Forms.LinkLabel();
            this.svgLinkLabel = new System.Windows.Forms.Label();
            this.svgImageButton = new System.Windows.Forms.Button();
            this.pngImageButton = new System.Windows.Forms.Button();
            this.svgLink = new System.Windows.Forms.LinkLabel();
            this.resultGroup = new System.Windows.Forms.GroupBox();
            this.resultShowButton = new System.Windows.Forms.Button();
            this.resultTypeBox = new System.Windows.Forms.ComboBox();
            this.testsList = new System.Windows.Forms.ListBox();
            this.factsList = new System.Windows.Forms.ListBox();
            this.imageInfoGroup.SuspendLayout();
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
            // imageInfoGroup
            // 
            this.imageInfoGroup.Controls.Add(this.factsList);
            this.imageInfoGroup.Controls.Add(this.testsList);
            this.imageInfoGroup.Controls.Add(this.pngLinkLabel);
            this.imageInfoGroup.Controls.Add(this.pngLink);
            this.imageInfoGroup.Controls.Add(this.svgLinkLabel);
            this.imageInfoGroup.Controls.Add(this.svgImageButton);
            this.imageInfoGroup.Controls.Add(this.pngImageButton);
            this.imageInfoGroup.Controls.Add(this.svgLink);
            this.imageInfoGroup.Location = new System.Drawing.Point(333, 12);
            this.imageInfoGroup.Name = "imageInfoGroup";
            this.imageInfoGroup.Size = new System.Drawing.Size(427, 440);
            this.imageInfoGroup.TabIndex = 17;
            this.imageInfoGroup.TabStop = false;
            this.imageInfoGroup.Text = "Open selected in new window";
            // 
            // pngLinkLabel
            // 
            this.pngLinkLabel.Location = new System.Drawing.Point(6, 37);
            this.pngLinkLabel.Name = "pngLinkLabel";
            this.pngLinkLabel.Size = new System.Drawing.Size(48, 15);
            this.pngLinkLabel.TabIndex = 16;
            this.pngLinkLabel.Text = "PNG";
            this.pngLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pngLink
            // 
            this.pngLink.Location = new System.Drawing.Point(60, 37);
            this.pngLink.Name = "pngLink";
            this.pngLink.Size = new System.Drawing.Size(60, 15);
            this.pngLink.TabIndex = 15;
            this.pngLink.TabStop = true;
            this.pngLink.Text = "Png link";
            this.pngLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // svgLinkLabel
            // 
            this.svgLinkLabel.Location = new System.Drawing.Point(6, 22);
            this.svgLinkLabel.Name = "svgLinkLabel";
            this.svgLinkLabel.Size = new System.Drawing.Size(48, 15);
            this.svgLinkLabel.TabIndex = 14;
            this.svgLinkLabel.Text = "SVG";
            this.svgLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // svgImageButton
            // 
            this.svgImageButton.Location = new System.Drawing.Point(321, 57);
            this.svgImageButton.Name = "svgImageButton";
            this.svgImageButton.Size = new System.Drawing.Size(75, 23);
            this.svgImageButton.TabIndex = 1;
            this.svgImageButton.Text = "Svg";
            this.svgImageButton.UseVisualStyleBackColor = true;
            this.svgImageButton.Click += new System.EventHandler(this.OnSvgImageButton_Click);
            // 
            // pngImageButton
            // 
            this.pngImageButton.Location = new System.Drawing.Point(321, 28);
            this.pngImageButton.Name = "pngImageButton";
            this.pngImageButton.Size = new System.Drawing.Size(75, 23);
            this.pngImageButton.TabIndex = 0;
            this.pngImageButton.Text = "Png";
            this.pngImageButton.UseVisualStyleBackColor = true;
            this.pngImageButton.Click += new System.EventHandler(this.OnPngImageButton_Click);
            // 
            // svgLink
            // 
            this.svgLink.Location = new System.Drawing.Point(60, 22);
            this.svgLink.Name = "svgLink";
            this.svgLink.Size = new System.Drawing.Size(60, 15);
            this.svgLink.TabIndex = 13;
            this.svgLink.TabStop = true;
            this.svgLink.Text = "Svg link";
            this.svgLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // testsList
            // 
            this.testsList.FormattingEnabled = true;
            this.testsList.ItemHeight = 15;
            this.testsList.Location = new System.Drawing.Point(218, 130);
            this.testsList.Name = "testsList";
            this.testsList.Size = new System.Drawing.Size(203, 304);
            this.testsList.TabIndex = 21;
            // 
            // factsList
            // 
            this.factsList.FormattingEnabled = true;
            this.factsList.ItemHeight = 15;
            this.factsList.Location = new System.Drawing.Point(6, 130);
            this.factsList.Name = "factsList";
            this.factsList.Size = new System.Drawing.Size(206, 304);
            this.factsList.TabIndex = 22;
            // 
            // CheckedImagesIdsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 491);
            this.Controls.Add(this.resultGroup);
            this.Controls.Add(this.imageInfoGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckedImagesIdsDialog";
            this.ShowIcon = false;
            this.Text = "Not used images";
            this.imageInfoGroup.ResumeLayout(false);
            this.resultGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox imageInfoGroup;
        private System.Windows.Forms.Button svgImageButton;
        private System.Windows.Forms.Button pngImageButton;
        private System.Windows.Forms.LinkLabel svgLink;
        internal System.Windows.Forms.GroupBox resultGroup;
        internal System.Windows.Forms.Button resultShowButton;
        internal System.Windows.Forms.ComboBox resultTypeBox;
        private System.Windows.Forms.ListBox resultList;
        private System.Windows.Forms.Label svgLinkLabel;
        private System.Windows.Forms.Label pngLinkLabel;
        private System.Windows.Forms.LinkLabel pngLink;
        private System.Windows.Forms.ListBox factsList;
        private System.Windows.Forms.ListBox testsList;
    }
}