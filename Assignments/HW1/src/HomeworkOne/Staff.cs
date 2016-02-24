using System;

namespace HomeworkOne
{
    public class Staff : Employee
    {
        protected string JobTitle { get; set; } = String.Empty;
        protected string Skill { get; set; } = String.Empty;

        public Staff()
        {
        }

        public Staff(int id) : base(id)
        {
        }

        public void Generate()
        {
            base.Generate();
            JobTitle = Names.title[random.Next(Names.title.Length)];
            Skill = Names.skill[random.Next(Names.skill.Length)];
        }

        public void Generate(int id)
        {
            base.Generate(id);
            JobTitle = Names.title[random.Next(Names.title.Length)];
            Skill = Names.skill[random.Next(Names.skill.Length)];
        }

        public string ToString()
        {
            return base.ToString() +
                   string.Format(" %s %s ", JobTitle, Skill);
        }

        public string ToString(bool value)
        {
            return (value ? "STA " : "") + ToString();
        }

        public string HtmlRow()
        {
            return "<tr>" + HtmlColumns() + "</tr>";
        }

        public string HtmlColumns()
        {
            return
                base.HtmlColumns() +
                "<td>" + JobTitle + "</td>" +
                "<td>" + Skill + "</td>";
        }
    }
}