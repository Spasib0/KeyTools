using System.Windows.Forms;

namespace KeyTools.Lessons.Entities
{
    internal class LessonView
    {
        private Label label;
        private Label author;
        private Label school;
        private Label updated;
        private Label personal;
        private Label origin;
        private Label forks;
        private Label views;
        private Label checkedTime;
        private Label review;

        public LessonView(Label label, Label author, Label school, Label updated, Label personal, Label origin, Label forks, Label views, Label checkedTime, Label review)
        {
            this.label = label;
            this.author = author;
            this.school = school;
            this.updated = updated;
            this.personal = personal;
            this.origin = origin;
            this.forks = forks;
            this.views = views;
            this.checkedTime = checkedTime;
            this.review = review;
        }
    }
}
