
using System;

namespace KeyTools.Lessons.Entities
{
    partial class ModeratorControl
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
            this.lessonIdLabel = new System.Windows.Forms.Label();
            this.lessonsComboBox = new System.Windows.Forms.ComboBox();
            this.lessonsCountLabel = new System.Windows.Forms.Label();
            this.updateLessonsButton = new System.Windows.Forms.Button();
            this.moderatorLessonView = new LessonInfo(lessons, lessonsComboBox);
            this.filterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lessonIdLabel
            // 
            this.lessonIdLabel.AutoSize = true;
            this.lessonIdLabel.Location = new System.Drawing.Point(0, 32);
            this.lessonIdLabel.Name = "lessonIdLabel";
            this.lessonIdLabel.Size = new System.Drawing.Size(62, 15);
            this.lessonIdLabel.TabIndex = 30;
            this.lessonIdLabel.Text = "Lesson id :";
            // 
            // moderatorLessonsComboBox
            // 
            this.lessonsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessonsComboBox.Location = new System.Drawing.Point(68, 29);
            this.lessonsComboBox.Name = "moderatorLessonsComboBox";
            this.lessonsComboBox.Size = new System.Drawing.Size(163, 23);
            this.lessonsComboBox.TabIndex = 29;
            this.lessonsComboBox.Tag = "";
            this.lessonsComboBox.SelectedIndexChanged += OnSelectedLessonChanged;
            // 
            // lessonsCountLabel
            // 
            this.lessonsCountLabel.AutoSize = true;
            this.lessonsCountLabel.Location = new System.Drawing.Point(295, 3);
            this.lessonsCountLabel.Name = "lessonsCountLabel";
            this.lessonsCountLabel.Size = new System.Drawing.Size(36, 15);
            this.lessonsCountLabel.TabIndex = 28;
            this.lessonsCountLabel.Text = "None";
            // 
            // updateLessonsButton
            // 
            this.updateLessonsButton.Location = new System.Drawing.Point(169, -1);
            this.updateLessonsButton.Name = "updateLessonsButton";
            this.updateLessonsButton.Size = new System.Drawing.Size(120, 23);
            this.updateLessonsButton.TabIndex = 27;
            this.updateLessonsButton.Text = "Update lessons";
            this.updateLessonsButton.UseVisualStyleBackColor = true;
            this.updateLessonsButton.Click += OnUpdateLessonsClick;
            // 
            // moderatorLessonView
            // 
            this.moderatorLessonView.Location = new System.Drawing.Point(0, 58);
            this.moderatorLessonView.Name = "moderatorLessonView";
            this.moderatorLessonView.Size = new System.Drawing.Size(352, 313);
            this.moderatorLessonView.TabIndex = 31;
            // 
            // filterTypeComboBox
            // 
            this.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeComboBox.Location = new System.Drawing.Point(0, 0);
            this.filterTypeComboBox.Name = "filterTypeComboBox";
            this.filterTypeComboBox.Size = new System.Drawing.Size(163, 23);
            this.filterTypeComboBox.TabIndex = 32;
            this.filterTypeComboBox.Tag = "";
            this.filterTypeComboBox.DataSource = Enum.GetValues(typeof(ModeratorRequestType));
            this.filterTypeComboBox.SelectedIndexChanged += OnSelectedFilterTypeChanged;
            //this.filterTypeComboBox.SelectedIndex = 0;
            //OnFilterTypeChanged(null, null); //todo чота не то
            // 
            // ModeratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterTypeComboBox);
            this.Controls.Add(this.moderatorLessonView);
            this.Controls.Add(this.lessonIdLabel);
            this.Controls.Add(this.lessonsComboBox);
            this.Controls.Add(this.lessonsCountLabel);
            this.Controls.Add(this.updateLessonsButton);
            this.Name = "ModeratorControl";
            this.Size = new System.Drawing.Size(352, 371);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lessonIdLabel;
        private System.Windows.Forms.ComboBox lessonsComboBox;
        private System.Windows.Forms.Label lessonsCountLabel;
        private System.Windows.Forms.Button updateLessonsButton;
        private LessonInfo moderatorLessonView;
        private System.Windows.Forms.ComboBox filterTypeComboBox;
    }
}
