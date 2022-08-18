using KeyTools.Lessons.Requests;
using KeyTools.Responces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KeyTools.Lessons.Entities
{
    public partial class ModeratorControl : UserControl
    {
        private List<LessonResponseData> lessons;
        private TypedModeratorRequest typedReqest;
        private ModeratorRequestType SelectedFilterType => (ModeratorRequestType)filterTypeComboBox.SelectedItem;
        private ILessonsRequest Request => typedReqest.Request;

        public ModeratorControl()
        {
            InitializeComponent();
            typedReqest = new TypedModeratorRequest(filterTypeComboBox, lessonsComboBox);
        }

        private void OnUpdateLessonsClick(object sender, EventArgs e)
        {
            if (SelectedFilterType != ModeratorRequestType.ById)
            {
                lessons = new LessonsData(LessonsTests.Client.Call(Request)).Lessons;
                lessonsCountLabel.Text = lessons.Count.ToString();
                lessonsComboBox.Items.Clear();
                lessonsComboBox.Items.AddRange(lessons.Select(lesson => lesson.id.ToString()).ToArray());
                lessonsComboBox.SelectedIndex = 0;
            }
            else
            {
                var lesson = ((JToken)JsonConvert.DeserializeObject(LessonsTests.Client.Call(Request))).Value<JToken>("data");
                lessons = new List<LessonResponseData> { new LessonResponseData(lesson) };
                OnSelectedLessonChanged(null, null);
            }
            //OnSelectedLessonChanged(null, null);
        }

        private void OnSelectedFilterTypeChanged(object sender, EventArgs e)
        {
            moderatorLessonView.Set(null);

            bool isSingle = SelectedFilterType == ModeratorRequestType.ById;

            lessonsComboBox.DropDownStyle = isSingle ? ComboBoxStyle.Simple : ComboBoxStyle.DropDownList;
            //lessonsComboBox.CanSelect = !isSingle;
        }

        private void OnSelectedLessonChanged(object sender, EventArgs e)
        {
            var lesson = lessons.FirstOrDefault(item => item.id.ToString() == lessonsComboBox.SelectedItem.ToString());
            moderatorLessonView.Set(lesson);
        }
    }

}
