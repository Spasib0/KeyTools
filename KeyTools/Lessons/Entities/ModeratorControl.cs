using KeyTools.Lessons.Requests;
using KeyTools.Responces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeyTools.Lessons.Entities
{
    public partial class ModeratorControl : UserControl
    {
        private List<LessonResponseData> lessons;
        private TypedModeratorRequest typedReqest;
        private ILessonsRequest Request => typedReqest.Request;
        private string lessonsCountString => string.Format(LESSONS_COUNT, lessons.Count < 1 ? "None" : lessons.Count.ToString());
        private const string LESSONS_COUNT = "Avalible lessons - {0}";
        
        public ModeratorControl()
        {
            lessonInfo = new LessonInfo(lessons);
            InitializeComponent();
            filterTypeComboBox.DataSource = Enum.GetValues(typeof(ModeratorRequestType));
            typedReqest = new TypedModeratorRequest(filterTypeComboBox, idTextBox);
        }

        private void OnUpdateLessonsClick(object sender, EventArgs e)
        {
            lessons = new LessonsData(LessonsTests.Client.Call(Request)).Lessons;
            lessonInfoGroup.Text = lessonsCountString;
            lessonsCountLabel.Text = lessons.Count.ToString();
            lessonInfo.SetLessons(lessons);
        }

        private void OnIdTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void OnFilterTypeChanged(object sender, EventArgs e)
        {
            idTextBox.Enabled = (ModeratorRequestType)filterTypeComboBox.SelectedItem == ModeratorRequestType.ById;
        }
    }
}
