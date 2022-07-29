
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
            this.keyLessonsInfosGroupBox = new System.Windows.Forms.GroupBox();
            this.authorLessonsLink = new System.Windows.Forms.LinkLabel();
            this.authorsLessonsLabel = new System.Windows.Forms.Label();
            this.keyLessonsTestsGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateLessonLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.updateLessonTestIcon = new System.Windows.Forms.Label();
            this.keyLesonsTestIcon = new System.Windows.Forms.Label();
            this.keyLessonsTestLogLink = new System.Windows.Forms.LinkLabel();
            this.getLessonWithContentButton = new System.Windows.Forms.Button();
            this.lessonByIdLabel = new System.Windows.Forms.Label();
            this.updateLessonByIdButton = new System.Windows.Forms.Button();
            this.keyLessonsComboBox = new System.Windows.Forms.ComboBox();
            this.authorLessonsCountLabel = new System.Windows.Forms.Label();
            this.getAuthorLessonsButton = new System.Windows.Forms.Button();
            this.moderatorTestsGroupBox = new System.Windows.Forms.GroupBox();
            this.allWorldLessonsCountLabel = new System.Windows.Forms.Label();
            this.userTestsGroupBox.SuspendLayout();
            this.keyLessonsInfosGroupBox.SuspendLayout();
            this.keyLessonsTestsGroupBox.SuspendLayout();
            this.moderatorTestsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testKeyLessons
            // 
            this.testKeyLessons.Location = new System.Drawing.Point(6, 22);
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
            this.userTestsGroupBox.Controls.Add(this.keyLessonsInfosGroupBox);
            this.userTestsGroupBox.Controls.Add(this.keyLessonsTestsGroupBox);
            this.userTestsGroupBox.Controls.Add(this.getLessonWithContentButton);
            this.userTestsGroupBox.Controls.Add(this.lessonByIdLabel);
            this.userTestsGroupBox.Controls.Add(this.updateLessonByIdButton);
            this.userTestsGroupBox.Controls.Add(this.keyLessonsComboBox);
            this.userTestsGroupBox.Controls.Add(this.authorLessonsCountLabel);
            this.userTestsGroupBox.Controls.Add(this.getAuthorLessonsButton);
            this.userTestsGroupBox.Controls.Add(this.testKeyLessons);
            this.userTestsGroupBox.Location = new System.Drawing.Point(4, 4);
            this.userTestsGroupBox.Name = "userTestsGroupBox";
            this.userTestsGroupBox.Size = new System.Drawing.Size(487, 461);
            this.userTestsGroupBox.TabIndex = 2;
            this.userTestsGroupBox.TabStop = false;
            this.userTestsGroupBox.Text = "User Tests";
            // 
            // keyLessonsInfosGroupBox
            // 
            this.keyLessonsInfosGroupBox.Controls.Add(this.authorLessonsLink);
            this.keyLessonsInfosGroupBox.Controls.Add(this.authorsLessonsLabel);
            this.keyLessonsInfosGroupBox.Location = new System.Drawing.Point(7, 204);
            this.keyLessonsInfosGroupBox.Name = "keyLessonsInfosGroupBox";
            this.keyLessonsInfosGroupBox.Size = new System.Drawing.Size(474, 141);
            this.keyLessonsInfosGroupBox.TabIndex = 12;
            this.keyLessonsInfosGroupBox.TabStop = false;
            this.keyLessonsInfosGroupBox.Text = "User lessons infos";
            // 
            // authorLessonsLink
            // 
            this.authorLessonsLink.AutoSize = true;
            this.authorLessonsLink.Enabled = false;
            this.authorLessonsLink.Location = new System.Drawing.Point(136, 19);
            this.authorLessonsLink.Name = "authorLessonsLink";
            this.authorLessonsLink.Size = new System.Drawing.Size(36, 15);
            this.authorLessonsLink.TabIndex = 13;
            this.authorLessonsLink.TabStop = true;
            this.authorLessonsLink.Text = "None";
            // 
            // authorsLessonsLabel
            // 
            this.authorsLessonsLabel.Location = new System.Drawing.Point(6, 19);
            this.authorsLessonsLabel.Name = "authorsLessonsLabel";
            this.authorsLessonsLabel.Size = new System.Drawing.Size(123, 23);
            this.authorsLessonsLabel.TabIndex = 12;
            this.authorsLessonsLabel.Text = "Author lessons: ";
            // 
            // keyLessonsTestsGroupBox
            // 
            this.keyLessonsTestsGroupBox.Controls.Add(this.label2);
            this.keyLessonsTestsGroupBox.Controls.Add(this.updateLessonLink);
            this.keyLessonsTestsGroupBox.Controls.Add(this.label1);
            this.keyLessonsTestsGroupBox.Controls.Add(this.updateLessonTestIcon);
            this.keyLessonsTestsGroupBox.Controls.Add(this.keyLesonsTestIcon);
            this.keyLessonsTestsGroupBox.Controls.Add(this.keyLessonsTestLogLink);
            this.keyLessonsTestsGroupBox.Location = new System.Drawing.Point(7, 52);
            this.keyLessonsTestsGroupBox.Name = "keyLessonsTestsGroupBox";
            this.keyLessonsTestsGroupBox.Size = new System.Drawing.Size(474, 146);
            this.keyLessonsTestsGroupBox.TabIndex = 11;
            this.keyLessonsTestsGroupBox.TabStop = false;
            this.keyLessonsTestsGroupBox.Text = "User lessons tests results";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Can update lessons: ";
            // 
            // updateLessonLink
            // 
            this.updateLessonLink.AutoSize = true;
            this.updateLessonLink.Location = new System.Drawing.Point(178, 42);
            this.updateLessonLink.Name = "updateLessonLink";
            this.updateLessonLink.Size = new System.Drawing.Size(56, 15);
            this.updateLessonLink.TabIndex = 10;
            this.updateLessonLink.TabStop = true;
            this.updateLessonLink.Text = "Open log";
            this.updateLessonLink.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Has links to content:";
            // 
            // updateLessonTestIcon
            // 
            this.updateLessonTestIcon.AutoSize = true;
            this.updateLessonTestIcon.Location = new System.Drawing.Point(135, 42);
            this.updateLessonTestIcon.Name = "updateLessonTestIcon";
            this.updateLessonTestIcon.Size = new System.Drawing.Size(36, 15);
            this.updateLessonTestIcon.TabIndex = 9;
            this.updateLessonTestIcon.Text = "None";
            // 
            // keyLesonsTestIcon
            // 
            this.keyLesonsTestIcon.AutoSize = true;
            this.keyLesonsTestIcon.Location = new System.Drawing.Point(136, 19);
            this.keyLesonsTestIcon.Name = "keyLesonsTestIcon";
            this.keyLesonsTestIcon.Size = new System.Drawing.Size(36, 15);
            this.keyLesonsTestIcon.TabIndex = 1;
            this.keyLesonsTestIcon.Text = "None";
            // 
            // keyLessonsTestLogLink
            // 
            this.keyLessonsTestLogLink.AutoSize = true;
            this.keyLessonsTestLogLink.Location = new System.Drawing.Point(179, 19);
            this.keyLessonsTestLogLink.Name = "keyLessonsTestLogLink";
            this.keyLessonsTestLogLink.Size = new System.Drawing.Size(56, 15);
            this.keyLessonsTestLogLink.TabIndex = 8;
            this.keyLessonsTestLogLink.TabStop = true;
            this.keyLessonsTestLogLink.Text = "Open log";
            this.keyLessonsTestLogLink.Visible = false;
            // 
            // getLessonWithContentButton
            // 
            this.getLessonWithContentButton.Location = new System.Drawing.Point(212, 389);
            this.getLessonWithContentButton.Name = "getLessonWithContentButton";
            this.getLessonWithContentButton.Size = new System.Drawing.Size(171, 23);
            this.getLessonWithContentButton.TabIndex = 7;
            this.getLessonWithContentButton.Text = "Get Lesson by Id with content";
            this.getLessonWithContentButton.UseVisualStyleBackColor = true;
            // 
            // lessonByIdLabel
            // 
            this.lessonByIdLabel.AutoSize = true;
            this.lessonByIdLabel.Location = new System.Drawing.Point(389, 393);
            this.lessonByIdLabel.Name = "lessonByIdLabel";
            this.lessonByIdLabel.Size = new System.Drawing.Size(36, 15);
            this.lessonByIdLabel.TabIndex = 6;
            this.lessonByIdLabel.Text = "None";
            // 
            // updateLessonByIdButton
            // 
            this.updateLessonByIdButton.Location = new System.Drawing.Point(123, 351);
            this.updateLessonByIdButton.Name = "updateLessonByIdButton";
            this.updateLessonByIdButton.Size = new System.Drawing.Size(110, 23);
            this.updateLessonByIdButton.TabIndex = 5;
            this.updateLessonByIdButton.Text = "Update Lesson by Id";
            this.updateLessonByIdButton.UseVisualStyleBackColor = true;
            // 
            // keyLessonsComboBox
            // 
            this.keyLessonsComboBox.Enabled = false;
            this.keyLessonsComboBox.FormattingEnabled = true;
            this.keyLessonsComboBox.Location = new System.Drawing.Point(7, 352);
            this.keyLessonsComboBox.Name = "keyLessonsComboBox";
            this.keyLessonsComboBox.Size = new System.Drawing.Size(110, 23);
            this.keyLessonsComboBox.Sorted = true;
            this.keyLessonsComboBox.TabIndex = 4;
            this.keyLessonsComboBox.Text = "Lesson Id";
            // 
            // authorLessonsCountLabel
            // 
            this.authorLessonsCountLabel.AutoSize = true;
            this.authorLessonsCountLabel.Location = new System.Drawing.Point(123, 405);
            this.authorLessonsCountLabel.Name = "authorLessonsCountLabel";
            this.authorLessonsCountLabel.Size = new System.Drawing.Size(36, 15);
            this.authorLessonsCountLabel.TabIndex = 3;
            this.authorLessonsCountLabel.Text = "None";
            // 
            // getAuthorLessonsButton
            // 
            this.getAuthorLessonsButton.Location = new System.Drawing.Point(7, 401);
            this.getAuthorLessonsButton.Name = "getAuthorLessonsButton";
            this.getAuthorLessonsButton.Size = new System.Drawing.Size(110, 23);
            this.getAuthorLessonsButton.TabIndex = 2;
            this.getAuthorLessonsButton.Text = "Get Author Lessons";
            this.getAuthorLessonsButton.UseVisualStyleBackColor = true;
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
            this.userTestsGroupBox.PerformLayout();
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
        private System.Windows.Forms.Label authorLessonsCountLabel;
        private System.Windows.Forms.Button getAuthorLessonsButton;
        private System.Windows.Forms.ComboBox keyLessonsComboBox;
        private System.Windows.Forms.Button updateLessonByIdButton;
        private System.Windows.Forms.Label lessonByIdLabel;
        private System.Windows.Forms.Button getLessonWithContentButton;
        private System.Windows.Forms.LinkLabel keyLessonsTestLogLink;
        private System.Windows.Forms.Label keyLesonsTestIcon;
        private System.Windows.Forms.Label updateLessonTestIcon;
        private System.Windows.Forms.LinkLabel updateLessonLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox keyLessonsTestsGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox keyLessonsInfosGroupBox;
        private System.Windows.Forms.Label authorsLessonsLabel;
        private System.Windows.Forms.LinkLabel authorLessonsLink;
    }
}
