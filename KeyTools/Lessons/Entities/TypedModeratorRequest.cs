using KeyTools.Lessons.Requests;
using System.Windows.Forms;

namespace KeyTools.Lessons.Entities
{
    public class TypedModeratorRequest
    {
        public ILessonsRequest Request => Get(SelectedType);

        private ModeratorRequestType SelectedType => (ModeratorRequestType)_typeComboBox.SelectedItem;
        private ComboBox _typeComboBox;
        private ComboBox _lessonComboBox;

        

        public TypedModeratorRequest(ComboBox typeComboBox, ComboBox lessonComboBox)
        {
            _typeComboBox = typeComboBox;
            _lessonComboBox = lessonComboBox;
        }

        public ILessonsRequest Get(ModeratorRequestType type)
        {
            switch (type)

            {
                case ModeratorRequestType.ById:
                    return new LessonByIdRequest(_lessonComboBox.Text);
                case ModeratorRequestType.AllPublic:
                    return new AllModeratorLessonsRequest(false);
                case ModeratorRequestType.AllPersonal:
                default:
                    return new AllModeratorLessonsRequest(true);
            }
        }
    }
}
