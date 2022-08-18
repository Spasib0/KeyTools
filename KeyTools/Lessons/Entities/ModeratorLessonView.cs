using KeyTools.Lessons.Tests;
using KeyTools.Responces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KeyTools.Lessons.Entities
{
    public partial class LessonInfo : UserControl
    {
        private ChangePersonalState changePersonalState;
        private List<LessonResponseData> _lessons;
        private ComboBox _lessonsComboBox;

        public LessonInfo(List<LessonResponseData> lessons, ComboBox lessonsComboBox)
        {
            InitializeComponent();
            _lessons = lessons;
            _lessonsComboBox = lessonsComboBox;
            changePersonalState = new ChangePersonalState(changePersonalStateLink);
        }

        public void Set(LessonResponseData lesson)
        {
            if(lesson == null)
            {
                Set(LessonResponseData.CreateNewLesson());
                return;
            }

            lessonLabel.Text = lesson.content.Label;
            authorLabel.Text = lesson.author;
            schoolLabel.Text = lesson.school;
            updatedLabel.Text = lesson.updated;
            personalLabel.Text = lesson.personal.ToString();
            originLabel.Text = lesson.origin;
            forksLabel.Text = lesson.forks.ToString();
            viewsLabel.Text = lesson.views.ToString();
            checkedTimeLabel.Text = lesson.checkedTime.ToString();
            reviewLabel.Text = lesson.content.Review.review;
        }

        private void OnPublishLessonClick(object sender, EventArgs e)
        {
            var lesson = _lessons.FirstOrDefault(lesson => lesson.id.ToString().Equals(_lessonsComboBox.SelectedItem));
            var res = changePersonalState.Update(lesson);
        }
    }
}
