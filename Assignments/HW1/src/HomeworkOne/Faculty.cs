namespace HomeworkOne
{
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

        public void Generate()
        {
            base.Generate();
            DegreeHeld = Names.degree[random.Next(Names.degree.Length)];
            Position = Names.position[random.Next(Names.position.Length)];
        }

        public void Generate(int id)
        {
            base.Generate(id);
            DegreeHeld = Names.degree[random.Next(Names.degree.Length)];
            Position = Names.position[random.Next(Names.position.Length)];
        }

        public string toString()
        {
            return base.toString() +
                   string.Format($" {DegreeHeld} {Position} ");
        }

        public string toString(bool value)
        {
            return (value ? "FAC " : "") + toString();
        }

        public string HtmlRow()
        {
            return "<tr>" + HtmlColumns() + "</tr>";
        }

        public string HtmlColumns()
        {
            return
                base.HtmlColumns() +
                "<td>" + DegreeHeld + "</td>" +
                "<td>" + Position + "</td>";
        }
    }
}