using System;

namespace HomeworkOne
{
    [Serializable]
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

        public new void Generate()
        {
            base.Generate();
            JobTitle = Names.title[random.Next(Names.title.Length)];
            Skill = Names.skill[random.Next(Names.skill.Length)];
        }

        public new void Generate(int id)
        {
            base.Generate(id);
            JobTitle = Names.title[random.Next(Names.title.Length)];
            Skill = Names.skill[random.Next(Names.skill.Length)];
        }

        public new string ToString()
        {
            return base.ToString() +
                   string.Format($" { JobTitle} {Skill} ");
        }

        public new string ToString(bool value)
        {
            return (value ? "STA " : "") + ToString();
        }

        public new string HtmlRow()
        {
            return "<tr>" + HtmlColumns() + "</tr>";
        }

        public new string HtmlColumns()
        {
            return
                base.HtmlColumns() +
                "<td>" + JobTitle + "</td>" +
                "<td>" + Skill + "</td>";
        }
    }
}