
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
            this.getKeyLessons = new System.Windows.Forms.Button();
            this.allWorldLessons = new System.Windows.Forms.Button();
            this.userTestsGroupBox = new System.Windows.Forms.GroupBox();
            this.getLessonByIdButton = new System.Windows.Forms.Button();
            this.keyLessonsComboBox = new System.Windows.Forms.ComboBox();
            this.authorLessonsCountLabel = new System.Windows.Forms.Label();
            this.getAuthorLessonsButton = new System.Windows.Forms.Button();
            this.keyLessonsCountLabel = new System.Windows.Forms.Label();
            this.moderatorTestsGroupBox = new System.Windows.Forms.GroupBox();
            this.allWorldLessonsCountLabel = new System.Windows.Forms.Label();
            this.lessonByIdLabel = new System.Windows.Forms.Label();
            this.userTestsGroupBox.SuspendLayout();
            this.moderatorTestsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // getKeyLessons
            // 
            this.getKeyLessons.Location = new System.Drawing.Point(6, 22);
            this.getKeyLessons.Name = "getKeyLessons";
            this.getKeyLessons.Size = new System.Drawing.Size(111, 23);
            this.getKeyLessons.TabIndex = 0;
            this.getKeyLessons.Text = "Get Key Lessons";
            this.getKeyLessons.UseVisualStyleBackColor = true;
            this.getKeyLessons.Click += new System.EventHandler(this.OnGetKeyLessonsClick);
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
            this.userTestsGroupBox.Controls.Add(this.lessonByIdLabel);
            this.userTestsGroupBox.Controls.Add(this.getLessonByIdButton);
            this.userTestsGroupBox.Controls.Add(this.keyLessonsComboBox);
            this.userTestsGroupBox.Controls.Add(this.authorLessonsCountLabel);
            this.userTestsGroupBox.Controls.Add(this.getAuthorLessonsButton);
            this.userTestsGroupBox.Controls.Add(this.keyLessonsCountLabel);
            this.userTestsGroupBox.Controls.Add(this.getKeyLessons);
            this.userTestsGroupBox.Location = new System.Drawing.Point(4, 4);
            this.userTestsGroupBox.Name = "userTestsGroupBox";
            this.userTestsGroupBox.Size = new System.Drawing.Size(487, 461);
            this.userTestsGroupBox.TabIndex = 2;
            this.userTestsGroupBox.TabStop = false;
            this.userTestsGroupBox.Text = "User Tests";
            // 
            // getLessonByIdButton
            // 
            this.getLessonByIdButton.Location = new System.Drawing.Point(292, 23);
            this.getLessonByIdButton.Name = "getLessonByIdButton";
            this.getLessonByIdButton.Size = new System.Drawing.Size(128, 23);
            this.getLessonByIdButton.TabIndex = 5;
            this.getLessonByIdButton.Text = "Get Lesson by Id";
            this.getLessonByIdButton.UseVisualStyleBackColor = true;
            this.getLessonByIdButton.Click += OnGetLessonByIdClick;
            // 
            // keyLessonsComboBox
            // 
            this.keyLessonsComboBox.Enabled = false;
            this.keyLessonsComboBox.FormattingEnabled = true;
            this.keyLessonsComboBox.Location = new System.Drawing.Point(165, 23);
            this.keyLessonsComboBox.Name = "keyLessonsComboBox";
            this.keyLessonsComboBox.Size = new System.Drawing.Size(121, 23);
            this.keyLessonsComboBox.Sorted = true;
            this.keyLessonsComboBox.TabIndex = 4;
            this.keyLessonsComboBox.Text = "Lesson Id";
            // 
            // authorLessonsCountLabel
            // 
            this.authorLessonsCountLabel.AutoSize = true;
            this.authorLessonsCountLabel.Location = new System.Drawing.Point(123, 56);
            this.authorLessonsCountLabel.Name = "authorLessonsCountLabel";
            this.authorLessonsCountLabel.Size = new System.Drawing.Size(36, 15);
            this.authorLessonsCountLabel.TabIndex = 3;
            this.authorLessonsCountLabel.Text = "None";
            // 
            // getAuthorLessonsButton
            // 
            this.getAuthorLessonsButton.Location = new System.Drawing.Point(7, 52);
            this.getAuthorLessonsButton.Name = "getAuthorLessonsButton";
            this.getAuthorLessonsButton.Size = new System.Drawing.Size(110, 23);
            this.getAuthorLessonsButton.TabIndex = 2;
            this.getAuthorLessonsButton.Text = "Get Author Lessons";
            this.getAuthorLessonsButton.UseVisualStyleBackColor = true;
            // 
            // keyLessonsCountLabel
            // 
            this.keyLessonsCountLabel.AutoSize = true;
            this.keyLessonsCountLabel.Location = new System.Drawing.Point(123, 26);
            this.keyLessonsCountLabel.Name = "keyLessonsCountLabel";
            this.keyLessonsCountLabel.Size = new System.Drawing.Size(36, 15);
            this.keyLessonsCountLabel.TabIndex = 1;
            this.keyLessonsCountLabel.Text = "None";
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
            // lessonByIdLabel
            // 
            this.lessonByIdLabel.AutoSize = true;
            this.lessonByIdLabel.Location = new System.Drawing.Point(427, 27);
            this.lessonByIdLabel.Name = "lessonByIdLabel";
            this.lessonByIdLabel.Size = new System.Drawing.Size(36, 15);
            this.lessonByIdLabel.TabIndex = 6;
            this.lessonByIdLabel.Text = "None";
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
            this.moderatorTestsGroupBox.ResumeLayout(false);
            this.moderatorTestsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getKeyLessons;
        private System.Windows.Forms.Button allWorldLessons;
        private System.Windows.Forms.GroupBox userTestsGroupBox;
        private System.Windows.Forms.GroupBox moderatorTestsGroupBox;
        private System.Windows.Forms.Label keyLessonsCountLabel;
        private System.Windows.Forms.Label allWorldLessonsCountLabel;
        private System.Windows.Forms.Label authorLessonsCountLabel;
        private System.Windows.Forms.Button getAuthorLessonsButton;
        private System.Windows.Forms.ComboBox keyLessonsComboBox;
        private System.Windows.Forms.Button getLessonByIdButton;
        private System.Windows.Forms.Label lessonByIdLabel;
    }
}
