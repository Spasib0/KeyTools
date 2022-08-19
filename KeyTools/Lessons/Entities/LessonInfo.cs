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
        private LessonResponseData currentLesson => (LessonResponseData) lessonsComboBox.SelectedItem;
        private PersonalState personalState;
        private List<LessonResponseData> _lessons;
        private Action<Label, bool> SetIcon => KeyTools.SetIcon;
        

        public LessonInfo()
        {
            InitializeComponent();
        }

        public LessonInfo (List<LessonResponseData> lessons)
        {
            InitializeComponent();
            _lessons = lessons;
            personalState = new PersonalState(personalStateLink);
        }

        public void SetLessons(List<LessonResponseData> lessons)
        {
            var data = new BindingSource();
            data.DataSource = lessons;
            lessonsComboBox.DataSource = data;
            lessonsComboBox.DisplayMember = "Id";
        }

        private void SetLessonInfo(LessonResponseData lesson)
        {
            if (lesson == null)
            {
                SetLessonInfo(LessonResponseData.CreateNewLesson());
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

            publishButton.Enabled = lesson.personal;
            rejectButton.Enabled = !lesson.personal;
        }

        private void OnPublishClick(object sender, EventArgs e)
        {
            SetIcon(personalStateIcon, personalState.Publish(currentLesson));
        }

        private void OnRejectClick(object sender, EventArgs e)
        {
            SetIcon(personalStateIcon, personalState.Reject(currentLesson));
        }

        private void OnSelectedLessonChanged(object sender, EventArgs e)
        {
            SetLessonInfo((LessonResponseData) lessonsComboBox.SelectedItem);
        }
    }
}
