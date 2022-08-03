
namespace KeyCheckGui
{
    partial class LessonsTests
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.testKeyLessons = new System.Windows.Forms.Button();
            this.allWorldLessons = new System.Windows.Forms.Button();
            this.userTestsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchLessonsGroupBox = new System.Windows.Forms.GroupBox();
            this.lessonsSearchLink = new System.Windows.Forms.LinkLabel();
            this.lessonsSearchButton = new System.Windows.Forms.Button();
            this.lessonsSearchTextBox = new System.Windows.Forms.TextBox();
            this.keyLessonsInfosGroupBox = new System.Windows.Forms.GroupBox();
            this.keyLessonsLink = new System.Windows.Forms.LinkLabel();
            this.authorLessonsLink = new System.Windows.Forms.LinkLabel();
            this.keyLessonsLabel = new System.Windows.Forms.Label();
            this.authorsLessonsLabel = new System.Windows.Forms.Label();
            this.keyLessonsTestsGroupBox = new System.Windows.Forms.GroupBox();
            this.canCreateNewLessonLink = new System.Windows.Forms.LinkLabel();
            this.canCreateNewLessonIcon = new System.Windows.Forms.Label();
            this.canDeleteLessonsLabel = new System.Windows.Forms.Label();
            this.canDeleteLessonLink = new System.Windows.Forms.LinkLabel();
            this.canCreateNewLessonLabel = new System.Windows.Forms.Label();
            this.canDeleteLessonsIcon = new System.Windows.Forms.Label();
            this.canForkPublishedLink = new System.Windows.Forms.LinkLabel();
            this.canForkPublishedIcon = new System.Windows.Forms.Label();
            this.canForkPublishedLabel = new System.Windows.Forms.Label();
            this.hasPublishedLessonsLink = new System.Windows.Forms.LinkLabel();
            this.hasPublishedLessonsIcon = new System.Windows.Forms.Label();
            this.hasPublishedLessonsLabel = new System.Windows.Forms.Label();
            this.canUpdateLessonsLabel = new System.Windows.Forms.Label();
            this.updateLessonLink = new System.Windows.Forms.LinkLabel();
            this.hasLinksToContentLabel = new System.Windows.Forms.Label();
            this.updateLessonTestIcon = new System.Windows.Forms.Label();
            this.keyLesonsTestIcon = new System.Windows.Forms.Label();
            this.keyLessonsTestLogLink = new System.Windows.Forms.LinkLabel();
            this.moderatorTestsGroupBox = new System.Windows.Forms.GroupBox();
            this.allWorldLessonsCountLabel = new System.Windows.Forms.Label();
            this.userTestsGroupBox.SuspendLayout();
            this.searchLessonsGroupBox.SuspendLayout();
            this.keyLessonsInfosGroupBox.SuspendLayout();
            this.keyLessonsTestsGroupBox.SuspendLayout();
            this.moderatorTestsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testKeyLessons
            // 
            this.testKeyLessons.Location = new System.Drawing.Point(202, 21);
            this.testKeyLessons.Name = "testKeyLessons";
            this.testKeyLessons.Size = new System.Drawing.Size(111, 23);
            this.testKeyLessons.TabIndex = 0;
            this.testKeyLessons.Text = "Check key lessons";
            this.testKeyLessons.UseVisualStyleBackColor = true;
            this.testKeyLessons.Click += new System.EventHandler(this.TestKeyLessonsClick);
            // 
            // allWorldLessons
            // 
            this.allWorldLessons.Location = new System.Drawing.Point(6, 22);
            this.allWorldLessons.Name = "allWorldLessons";
            this.allWorldLessons.Size = new System.Drawing.Size(120, 23);
            this.allWorldLessons.TabIndex = 1;
            this.allWorldLessons.Text = "All World Lessons";
            this.allWorldLessons.UseVisualStyleBackColor = true;
            this.allWorldLessons.Click += new System.EventHandler(this.OnAllWorldLessonsClick);
            // 
            // userTestsGroupBox
            // 
            this.userTestsGroupBox.Controls.Add(this.searchLessonsGroupBox);
            this.userTestsGroupBox.Controls.Add(this.keyLessonsInfosGroupBox);
            this.userTestsGroupBox.Controls.Add(this.keyLessonsTestsGroupBox);
            this.userTestsGroupBox.Controls.Add(this.testKeyLessons);
            this.userTestsGroupBox.Location = new System.Drawing.Point(4, 4);
            this.userTestsGroupBox.Name = "userTestsGroupBox";
            this.userTestsGroupBox.Size = new System.Drawing.Size(487, 461);
            this.userTestsGroupBox.TabIndex = 2;
            this.userTestsGroupBox.TabStop = false;
            this.userTestsGroupBox.Text = "User Tests";
            // 
            // searchLessonsGroupBox
            // 
            this.searchLessonsGroupBox.Controls.Add(this.lessonsSearchLink);
            this.searchLessonsGroupBox.Controls.Add(this.lessonsSearchButton);
            this.searchLessonsGroupBox.Controls.Add(this.lessonsSearchTextBox);
            this.searchLessonsGroupBox.Location = new System.Drawing.Point(7, 294);
            this.searchLessonsGroupBox.Name = "searchLessonsGroupBox";
            this.searchLessonsGroupBox.Size = new System.Drawing.Size(474, 131);
            this.searchLessonsGroupBox.TabIndex = 13;
            this.searchLessonsGroupBox.TabStop = false;
            this.searchLessonsGroupBox.Text = "Search lessons";
            // 
            // lessonsSearchLink
            // 
            this.lessonsSearchLink.AutoSize = true;
            this.lessonsSearchLink.Enabled = false;
            this.lessonsSearchLink.Location = new System.Drawing.Point(195, 26);
            this.lessonsSearchLink.Name = "lessonsSearchLink";
            this.lessonsSearchLink.Size = new System.Drawing.Size(36, 15);
            this.lessonsSearchLink.TabIndex = 20;
            this.lessonsSearchLink.TabStop = true;
            this.lessonsSearchLink.Text = "None";
            // 
            // lessonsSearchButton
            // 
            this.lessonsSearchButton.Location = new System.Drawing.Point(114, 23);
            this.lessonsSearchButton.Name = "lessonsSearchButton";
            this.lessonsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.lessonsSearchButton.TabIndex = 1;
            this.lessonsSearchButton.Text = "Search";
            this.lessonsSearchButton.UseVisualStyleBackColor = true;
            this.lessonsSearchButton.Click += OnSearchLessonsClick;
            // 
            // lessonsSearchTextBox
            // 
            this.lessonsSearchTextBox.Location = new System.Drawing.Point(7, 23);
            this.lessonsSearchTextBox.Name = "lessonsSearchTextBox";
            this.lessonsSearchTextBox.PlaceholderText = "lesson label";
            this.lessonsSearchTextBox.Size = new System.Drawing.Size(100, 23);
            this.lessonsSearchTextBox.TabIndex = 0;
            // 
            // keyLessonsInfosGroupBox
            // 
            this.keyLessonsInfosGroupBox.Controls.Add(this.keyLessonsLink);
            this.keyLessonsInfosGroupBox.Controls.Add(this.authorLessonsLink);
            this.keyLessonsInfosGroupBox.Controls.Add(this.keyLessonsLabel);
            this.keyLessonsInfosGroupBox.Controls.Add(this.authorsLessonsLabel);
            this.keyLessonsInfosGroupBox.Location = new System.Drawing.Point(7, 217);
            this.keyLessonsInfosGroupBox.Name = "keyLessonsInfosGroupBox";
            this.keyLessonsInfosGroupBox.Size = new System.Drawing.Size(474, 71);
            this.keyLessonsInfosGroupBox.TabIndex = 12;
            this.keyLessonsInfosGroupBox.TabStop = false;
            this.keyLessonsInfosGroupBox.Text = "User lessons infos";
            // 
            // keyLessonsLink
            // 
            this.keyLessonsLink.AutoSize = true;
            this.keyLessonsLink.BackColor = System.Drawing.SystemColors.Control;
            this.keyLessonsLink.Enabled = false;
            this.keyLessonsLink.Location = new System.Drawing.Point(135, 19);
            this.keyLessonsLink.Name = "keyLessonsLink";
            this.keyLessonsLink.Size = new System.Drawing.Size(36, 15);
            this.keyLessonsLink.TabIndex = 14;
            this.keyLessonsLink.TabStop = true;
            this.keyLessonsLink.Text = "None";
            // 
            // authorLessonsLink
            // 
            this.authorLessonsLink.AutoSize = true;
            this.authorLessonsLink.Enabled = false;
            this.authorLessonsLink.Location = new System.Drawing.Point(135, 42);
            this.authorLessonsLink.Name = "authorLessonsLink";
            this.authorLessonsLink.Size = new System.Drawing.Size(36, 15);
            this.authorLessonsLink.TabIndex = 13;
            this.authorLessonsLink.TabStop = true;
            this.authorLessonsLink.Text = "None";
            // 
            // keyLessonsLabel
            // 
            this.keyLessonsLabel.Location = new System.Drawing.Point(6, 19);
            this.keyLessonsLabel.Name = "keyLessonsLabel";
            this.keyLessonsLabel.Size = new System.Drawing.Size(123, 23);
            this.keyLessonsLabel.TabIndex = 13;
            this.keyLessonsLabel.Text = "Key lessons: ";
            // 
            // authorsLessonsLabel
            // 
            this.authorsLessonsLabel.Location = new System.Drawing.Point(6, 42);
            this.authorsLessonsLabel.Name = "authorsLessonsLabel";
            this.authorsLessonsLabel.Size = new System.Drawing.Size(123, 23);
            this.authorsLessonsLabel.TabIndex = 12;
            this.authorsLessonsLabel.Text = "Author lessons: ";
            // 
            // keyLessonsTestsGroupBox
            // 
            this.keyLessonsTestsGroupBox.Controls.Add(this.canCreateNewLessonLink);
            this.keyLessonsTestsGroupBox.Controls.Add(this.canCreateNewLessonIcon);
            this.keyLessonsTestsGroupBox.Controls.Add(this.canDeleteLessonsLabel);
            this.keyLessonsTestsGroupBox.Controls.Add(this.canDeleteLessonLink);
            this.keyLessonsTestsGroupBox.Controls.Add(this.canCreateNewLessonLabel);
            this.keyLessonsTestsGroupBox.Controls.Add(this.canDeleteLessonsIcon);
            this.keyLessonsTestsGroupBox.Controls.Add(this.canForkPublishedLink);
            this.keyLessonsTestsGroupBox.Controls.Add(this.canForkPublishedIcon);
            this.keyLessonsTestsGroupBox.Controls.Add(this.canForkPublishedLabel);
            this.keyLessonsTestsGroupBox.Controls.Add(this.hasPublishedLessonsLink);
            this.keyLessonsTestsGroupBox.Controls.Add(this.hasPublishedLessonsIcon);
            this.keyLessonsTestsGroupBox.Controls.Add(this.hasPublishedLessonsLabel);
            this.keyLessonsTestsGroupBox.Controls.Add(this.canUpdateLessonsLabel);
            this.keyLessonsTestsGroupBox.Controls.Add(this.updateLessonLink);
            this.keyLessonsTestsGroupBox.Controls.Add(this.hasLinksToContentLabel);
            this.keyLessonsTestsGroupBox.Controls.Add(this.updateLessonTestIcon);
            this.keyLessonsTestsGroupBox.Controls.Add(this.keyLesonsTestIcon);
            this.keyLessonsTestsGroupBox.Controls.Add(this.keyLessonsTestLogLink);
            this.keyLessonsTestsGroupBox.Location = new System.Drawing.Point(7, 52);
            this.keyLessonsTestsGroupBox.Name = "keyLessonsTestsGroupBox";
            this.keyLessonsTestsGroupBox.Size = new System.Drawing.Size(474, 159);
            this.keyLessonsTestsGroupBox.TabIndex = 11;
            this.keyLessonsTestsGroupBox.TabStop = false;
            this.keyLessonsTestsGroupBox.Text = "User lessons tests results";
            // 
            // canCreateNewLessonLink
            // 
            this.canCreateNewLessonLink.AutoSize = true;
            this.canCreateNewLessonLink.Location = new System.Drawing.Point(186, 111);
            this.canCreateNewLessonLink.Name = "canCreateNewLessonLink";
            this.canCreateNewLessonLink.Size = new System.Drawing.Size(56, 15);
            this.canCreateNewLessonLink.TabIndex = 22;
            this.canCreateNewLessonLink.TabStop = true;
            this.canCreateNewLessonLink.Text = "Open log";
            // 
            // canCreateNewLessonIcon
            // 
            this.canCreateNewLessonIcon.AutoSize = true;
            this.canCreateNewLessonIcon.Location = new System.Drawing.Point(143, 111);
            this.canCreateNewLessonIcon.Name = "canCreateNewLessonIcon";
            this.canCreateNewLessonIcon.Size = new System.Drawing.Size(36, 15);
            this.canCreateNewLessonIcon.TabIndex = 21;
            this.canCreateNewLessonIcon.Text = "None";
            // 
            // canDeleteLessonsLabel
            // 
            this.canDeleteLessonsLabel.Location = new System.Drawing.Point(7, 134);
            this.canDeleteLessonsLabel.Name = "canDeleteLessonsLabel";
            this.canDeleteLessonsLabel.Size = new System.Drawing.Size(130, 23);
            this.canDeleteLessonsLabel.TabIndex = 17;
            this.canDeleteLessonsLabel.Text = "Can delete lessons";
            // 
            // canDeleteLessonLink
            // 
            this.canDeleteLessonLink.AutoSize = true;
            this.canDeleteLessonLink.Location = new System.Drawing.Point(186, 134);
            this.canDeleteLessonLink.Name = "canDeleteLessonLink";
            this.canDeleteLessonLink.Size = new System.Drawing.Size(56, 15);
            this.canDeleteLessonLink.TabIndex = 19;
            this.canDeleteLessonLink.TabStop = true;
            this.canDeleteLessonLink.Text = "Open log";
            // 
            // canCreateNewLessonLabel
            // 
            this.canCreateNewLessonLabel.Location = new System.Drawing.Point(7, 111);
            this.canCreateNewLessonLabel.Name = "canCreateNewLessonLabel";
            this.canCreateNewLessonLabel.Size = new System.Drawing.Size(130, 23);
            this.canCreateNewLessonLabel.TabIndex = 20;
            this.canCreateNewLessonLabel.Text = "Can create lesson";
            // 
            // canDeleteLessonsIcon
            // 
            this.canDeleteLessonsIcon.AutoSize = true;
            this.canDeleteLessonsIcon.Location = new System.Drawing.Point(143, 134);
            this.canDeleteLessonsIcon.Name = "canDeleteLessonsIcon";
            this.canDeleteLessonsIcon.Size = new System.Drawing.Size(36, 15);
            this.canDeleteLessonsIcon.TabIndex = 18;
            this.canDeleteLessonsIcon.Text = "None";
            // 
            // canForkPublishedLink
            // 
            this.canForkPublishedLink.AutoSize = true;
            this.canForkPublishedLink.Location = new System.Drawing.Point(186, 88);
            this.canForkPublishedLink.Name = "canForkPublishedLink";
            this.canForkPublishedLink.Size = new System.Drawing.Size(56, 15);
            this.canForkPublishedLink.TabIndex = 16;
            this.canForkPublishedLink.TabStop = true;
            this.canForkPublishedLink.Text = "Open log";
            // 
            // canForkPublishedIcon
            // 
            this.canForkPublishedIcon.AutoSize = true;
            this.canForkPublishedIcon.Location = new System.Drawing.Point(143, 88);
            this.canForkPublishedIcon.Name = "canForkPublishedIcon";
            this.canForkPublishedIcon.Size = new System.Drawing.Size(36, 15);
            this.canForkPublishedIcon.TabIndex = 15;
            this.canForkPublishedIcon.Text = "None";
            // 
            // canForkPublishedLabel
            // 
            this.canForkPublishedLabel.Location = new System.Drawing.Point(7, 88);
            this.canForkPublishedLabel.Name = "canForkPublishedLabel";
            this.canForkPublishedLabel.Size = new System.Drawing.Size(130, 23);
            this.canForkPublishedLabel.TabIndex = 14;
            this.canForkPublishedLabel.Text = "Can fork published";
            // 
            // hasPublishedLessonsLink
            // 
            this.hasPublishedLessonsLink.AutoSize = true;
            this.hasPublishedLessonsLink.Location = new System.Drawing.Point(186, 65);
            this.hasPublishedLessonsLink.Name = "hasPublishedLessonsLink";
            this.hasPublishedLessonsLink.Size = new System.Drawing.Size(56, 15);
            this.hasPublishedLessonsLink.TabIndex = 13;
            this.hasPublishedLessonsLink.TabStop = true;
            this.hasPublishedLessonsLink.Text = "Open log";
            this.hasPublishedLessonsLink.Visible = false;
            // 
            // hasPublishedLessonsIcon
            // 
            this.hasPublishedLessonsIcon.AutoSize = true;
            this.hasPublishedLessonsIcon.Location = new System.Drawing.Point(143, 65);
            this.hasPublishedLessonsIcon.Name = "hasPublishedLessonsIcon";
            this.hasPublishedLessonsIcon.Size = new System.Drawing.Size(36, 15);
            this.hasPublishedLessonsIcon.TabIndex = 12;
            this.hasPublishedLessonsIcon.Text = "None";
            // 
            // hasPublishedLessonsLabel
            // 
            this.hasPublishedLessonsLabel.Location = new System.Drawing.Point(7, 65);
            this.hasPublishedLessonsLabel.Name = "hasPublishedLessonsLabel";
            this.hasPublishedLessonsLabel.Size = new System.Drawing.Size(130, 23);
            this.hasPublishedLessonsLabel.TabIndex = 11;
            this.hasPublishedLessonsLabel.Text = "Has published lessons";
            // 
            // canUpdateLessonsLabel
            // 
            this.canUpdateLessonsLabel.Location = new System.Drawing.Point(6, 42);
            this.canUpdateLessonsLabel.Name = "canUpdateLessonsLabel";
            this.canUpdateLessonsLabel.Size = new System.Drawing.Size(131, 23);
            this.canUpdateLessonsLabel.TabIndex = 9;
            this.canUpdateLessonsLabel.Text = "Can update lessons: ";
            // 
            // updateLessonLink
            // 
            this.updateLessonLink.AutoSize = true;
            this.updateLessonLink.Location = new System.Drawing.Point(186, 42);
            this.updateLessonLink.Name = "updateLessonLink";
            this.updateLessonLink.Size = new System.Drawing.Size(56, 15);
            this.updateLessonLink.TabIndex = 10;
            this.updateLessonLink.TabStop = true;
            this.updateLessonLink.Text = "Open log";
            this.updateLessonLink.Visible = false;
            // 
            // hasLinksToContentLabel
            // 
            this.hasLinksToContentLabel.Location = new System.Drawing.Point(6, 19);
            this.hasLinksToContentLabel.Name = "hasLinksToContentLabel";
            this.hasLinksToContentLabel.Size = new System.Drawing.Size(131, 23);
            this.hasLinksToContentLabel.TabIndex = 0;
            this.hasLinksToContentLabel.Text = "Has links to content:";
            // 
            // updateLessonTestIcon
            // 
            this.updateLessonTestIcon.AutoSize = true;
            this.updateLessonTestIcon.Location = new System.Drawing.Point(143, 42);
            this.updateLessonTestIcon.Name = "updateLessonTestIcon";
            this.updateLessonTestIcon.Size = new System.Drawing.Size(36, 15);
            this.updateLessonTestIcon.TabIndex = 9;
            this.updateLessonTestIcon.Text = "None";
            // 
            // keyLesonsTestIcon
            // 
            this.keyLesonsTestIcon.AutoSize = true;
            this.keyLesonsTestIcon.Location = new System.Drawing.Point(143, 19);
            this.keyLesonsTestIcon.Name = "keyLesonsTestIcon";
            this.keyLesonsTestIcon.Size = new System.Drawing.Size(36, 15);
            this.keyLesonsTestIcon.TabIndex = 1;
            this.keyLesonsTestIcon.Text = "None";
            // 
            // keyLessonsTestLogLink
            // 
            this.keyLessonsTestLogLink.AutoSize = true;
            this.keyLessonsTestLogLink.Location = new System.Drawing.Point(186, 19);
            this.keyLessonsTestLogLink.Name = "keyLessonsTestLogLink";
            this.keyLessonsTestLogLink.Size = new System.Drawing.Size(56, 15);
            this.keyLessonsTestLogLink.TabIndex = 8;
            this.keyLessonsTestLogLink.TabStop = true;
            this.keyLessonsTestLogLink.Text = "Open log";
            this.keyLessonsTestLogLink.Visible = false;
            // 
            // moderatorTestsGroupBox
            // 
            this.moderatorTestsGroupBox.Controls.Add(this.allWorldLessonsCountLabel);
            this.moderatorTestsGroupBox.Controls.Add(this.allWorldLessons);
            this.moderatorTestsGroupBox.Location = new System.Drawing.Point(497, 7);
            this.moderatorTestsGroupBox.Name = "moderatorTestsGroupBox";
            this.moderatorTestsGroupBox.Size = new System.Drawing.Size(437, 461);
            this.moderatorTestsGroupBox.TabIndex = 3;
            this.moderatorTestsGroupBox.TabStop = false;
            this.moderatorTestsGroupBox.Text = "Moderator Tests";
            // 
            // allWorldLessonsCountLabel
            // 
            this.allWorldLessonsCountLabel.AutoSize = true;
            this.allWorldLessonsCountLabel.Location = new System.Drawing.Point(132, 26);
            this.allWorldLessonsCountLabel.Name = "allWorldLessonsCountLabel";
            this.allWorldLessonsCountLabel.Size = new System.Drawing.Size(36, 15);
            this.allWorldLessonsCountLabel.TabIndex = 2;
            this.allWorldLessonsCountLabel.Text = "None";
            // 
            // LessonsTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moderatorTestsGroupBox);
            this.Controls.Add(this.userTestsGroupBox);
            this.Name = "LessonsTests";
            this.Size = new System.Drawing.Size(937, 468);
            this.userTestsGroupBox.ResumeLayout(false);
            this.searchLessonsGroupBox.ResumeLayout(false);
            this.searchLessonsGroupBox.PerformLayout();
            this.keyLessonsInfosGroupBox.ResumeLayout(false);
            this.keyLessonsInfosGroupBox.PerformLayout();
            this.keyLessonsTestsGroupBox.ResumeLayout(false);
            this.keyLessonsTestsGroupBox.PerformLayout();
            this.moderatorTestsGroupBox.ResumeLayout(false);
            this.moderatorTestsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testKeyLessons;
        private System.Windows.Forms.Button allWorldLessons;
        private System.Windows.Forms.GroupBox userTestsGroupBox;
        private System.Windows.Forms.GroupBox moderatorTestsGroupBox;
        private System.Windows.Forms.Label allWorldLessonsCountLabel;
        private System.Windows.Forms.LinkLabel keyLessonsTestLogLink;
        private System.Windows.Forms.Label keyLesonsTestIcon;
        private System.Windows.Forms.Label updateLessonTestIcon;
        private System.Windows.Forms.LinkLabel updateLessonLink;
        private System.Windows.Forms.Label hasLinksToContentLabel;
        private System.Windows.Forms.GroupBox keyLessonsTestsGroupBox;
        private System.Windows.Forms.Label canUpdateLessonsLabel;
        private System.Windows.Forms.GroupBox keyLessonsInfosGroupBox;
        private System.Windows.Forms.Label authorsLessonsLabel;
        private System.Windows.Forms.LinkLabel authorLessonsLink;
        private System.Windows.Forms.Label keyLessonsLabel;
        private System.Windows.Forms.LinkLabel keyLessonsLink;
        private System.Windows.Forms.Label hasPublishedLessonsLabel;
        private System.Windows.Forms.Label hasPublishedLessonsIcon;
        private System.Windows.Forms.LinkLabel hasPublishedLessonsLink;
        private System.Windows.Forms.LinkLabel canForkPublishedLink;
        private System.Windows.Forms.Label canForkPublishedIcon;
        private System.Windows.Forms.Label canForkPublishedLabel;
        private System.Windows.Forms.LinkLabel canDeleteLessonLink;
        private System.Windows.Forms.Label canDeleteLessonsIcon;
        private System.Windows.Forms.Label canDeleteLessonsLabel;
        private System.Windows.Forms.LinkLabel canCreateNewLessonLink;
        private System.Windows.Forms.Label canCreateNewLessonIcon;
        private System.Windows.Forms.Label canCreateNewLessonLabel;
        private System.Windows.Forms.GroupBox searchLessonsGroupBox;
        private System.Windows.Forms.Button lessonsSearchButton;
        private System.Windows.Forms.TextBox lessonsSearchTextBox;
        private System.Windows.Forms.LinkLabel lessonsSearchLink;
    }
}
