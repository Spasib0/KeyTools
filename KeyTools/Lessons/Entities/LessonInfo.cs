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
            if(lessons.Count < 1)
            {
                SetLessonInfo(LessonResponseData.CreateNewLesson());
            }

            var data = new BindingSource();
            data.DataSource = lessons;
            lessonsComboBox.DataSource = data;
            lessonsComboBox.DisplayMember = "Id";
        }

        private void SetLessonInfo(LessonResponseData lesson)
        {
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

            bool notFound = string.IsNullOrEmpty(lesson.content.Label);
            publishButton.Enabled = !notFound && lesson.personal;
            rejectButton.Enabled = !notFound && !lesson.personal;
        }

        private void OnPublishClick(object sender, EventArgs e)
        {
            SetState(false);
        }

        private void OnRejectClick(object sender, EventArgs e)
        {
            SetState(true);
        }

        private void SetState(bool state)
        {
            var isOk = state ? personalState.Reject(currentLesson) : personalState.Publish(currentLesson);
            SetIcon(personalStateIcon, isOk);
            currentLesson.personal = state;
            SetLessonInfo(currentLesson);
        }

        private void OnSelectedLessonChanged(object sender, EventArgs e)
        {
            SetLessonInfo((LessonResponseData) lessonsComboBox.SelectedItem);
        }
    }
}
