
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
            this.lessonsCountLabel = new System.Windows.Forms.Label();
            this.updateLessonsButton = new System.Windows.Forms.Button();
            this.filterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.lessonInfoGroup = new System.Windows.Forms.GroupBox();
            this.lessonInfoGroup.SuspendLayout();
            this.SuspendLayout();
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
            this.updateLessonsButton.Location = new System.Drawing.Point(0, 29);
            this.updateLessonsButton.Name = "updateLessonsButton";
            this.updateLessonsButton.Size = new System.Drawing.Size(163, 23);
            this.updateLessonsButton.TabIndex = 27;
            this.updateLessonsButton.Text = "Update lessons";
            this.updateLessonsButton.UseVisualStyleBackColor = true;
            this.updateLessonsButton.Click += OnUpdateLessonsClick;
            // 
            // filterTypeComboBox
            // 
            
            this.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeComboBox.Location = new System.Drawing.Point(0, 0);
            this.filterTypeComboBox.Name = "filterTypeComboBox";
            this.filterTypeComboBox.Size = new System.Drawing.Size(163, 23);
            this.filterTypeComboBox.TabIndex = 32;
            this.filterTypeComboBox.Tag = "";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(170, 0);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(100, 23);
            this.filterTextBox.TabIndex = 33;
            // 
            // lessonInfoGroup
            // 
            this.lessonInfoGroup.Controls.Add(this.lessonsInfo);
            this.lessonInfoGroup.Location = new System.Drawing.Point(3, 58);
            this.lessonInfoGroup.Name = "lessonInfoGroup";
            this.lessonInfoGroup.Size = new System.Drawing.Size(377, 327);
            this.lessonInfoGroup.TabIndex = 34;
            this.lessonInfoGroup.TabStop = false;
            this.lessonInfoGroup.Text = "Avalible lessons";
            // 
            // lessonsInfo
            // 
            this.lessonsInfo.Location = new System.Drawing.Point(6, 22);
            this.lessonsInfo.Name = "lessonsInfo";
            this.lessonsInfo.Size = new System.Drawing.Size(365, 299);
            this.lessonsInfo.TabIndex = 0;
            // 
            // ModeratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lessonInfoGroup);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.filterTypeComboBox);
            this.Controls.Add(this.lessonsCountLabel);
            this.Controls.Add(this.updateLessonsButton);
            this.Name = "ModeratorControl";
            this.Size = new System.Drawing.Size(384, 403);
            this.lessonInfoGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lessonsCountLabel;
        private System.Windows.Forms.Button updateLessonsButton;
        private System.Windows.Forms.ComboBox filterTypeComboBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.GroupBox lessonInfoGroup;
        private LessonInfo lessonsInfo;
    }
}
