using System;

namespace HomeworkOne
{
    [Serializable]
    public class Student : Member
    {
        private double GPA;
        protected string Major { get; set; } = String.Empty;
        protected string Sport { get; set; } = String.Empty;

        public Student()
        {
        }

        public Student(int id) : base(id)
        {
        }

        public new void Generate()
        {
            base.Generate();
            Major = Names.department[random.Next(Names.department.Length)];
            GPA = (random.Next(400 - 200 + 1) + 200)/100.0;
        }

        public new void Generate(int id)
        {
            base.Generate(id);
            Major = Names.department[random.Next(Names.department.Length)];
            GPA = (random.Next(400 - 200 + 1) + 200)/100.0;
        }

        public new string ToString()
        {
            return base.ToString() +
                   string.Format($" { GPA, 2 } {Major} ");
        }

        public string toString(bool value)
        {
            return (value ? "STU " : "") + ToString();
        }

        public new string HtmlRow()
        {
            return "<tr>" + HtmlColumns() + "</tr>";
        }

        public new string HtmlColumns()
        {
            return
                base.HtmlColumns() +
                "<td>" + GPA + "</td>" +
                "<td colspan=2>" + Major + "</td>";
        }

    }
}