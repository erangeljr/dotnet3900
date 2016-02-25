using System;

namespace HomeworkOne
{
    [Serializable]
    public class Faculty : Employee
    {
        public Faculty()
        {
            Generate();
        }

        public Faculty(int id) : base(id)
        {
            Generate(id);
        }

        protected string DegreeHeld { get; set; } = string.Empty;
        protected string Position { get; set; } = string.Empty;

        public new void Generate()
        {
            base.Generate();
            DegreeHeld = Names.degree[random.Next(Names.degree.Length)];
            Position = Names.position[random.Next(Names.position.Length)];
        }

        public new void Generate(int id)
        {
            base.Generate(id);
            DegreeHeld = Names.degree[random.Next(Names.degree.Length)];
            Position = Names.position[random.Next(Names.position.Length)];
        }

        public string toStToStringring()
        {
            return base.ToString() +
                   string.Format($" {DegreeHeld} {Position} ");
        }

        public new string ToString(bool value)
        {
            return (value ? "FAC " : "") + ToString();
        }

        public new string HtmlRow()
        {
            return "<tr>" + HtmlColumns() + "</tr>";
        }

        public new string HtmlColumns()
        {
            return
                base.HtmlColumns() +
                "<td>" + DegreeHeld + "</td>" +
                "<td>" + Position + "</td>";
        }
    }
}