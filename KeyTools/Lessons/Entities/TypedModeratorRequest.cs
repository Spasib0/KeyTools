using KeyTools.Lessons.Requests;
using System.Windows.Forms;

namespace KeyTools.Lessons.Entities
{
    public class TypedModeratorRequest
    {
        public ILessonsRequest Request => Get(SelectedType);

        private ModeratorRequestType SelectedType => (ModeratorRequestType)_typeComboBox.SelectedItem;
        private ComboBox _typeComboBox;
        private TextBox _lessonTextBox;

        

        public TypedModeratorRequest(ComboBox typeComboBox, TextBox lessonComboBox)
        {
            _typeComboBox = typeComboBox;
            _lessonTextBox = lessonComboBox;
        }

        public ILessonsRequest Get(ModeratorRequestType type)
        {
            switch (type)

            {
                case ModeratorRequestType.ById:
                    return new LessonByIdRequest(_lessonTextBox.Text);
                case ModeratorRequestType.AllPublic:
                    return new AllModeratorLessonsRequest(false);
                case ModeratorRequestType.AllPersonal:
                default:
                    return new AllModeratorLessonsRequest(true);
            }
        }
    }
}
