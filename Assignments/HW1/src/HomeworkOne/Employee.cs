namespace HomeworkOne
{
    public class Employee : Member
    {
        private int yearHired = 0;

        public Employee()
        {
            Generate();
        }

        public Employee(int id) : base(id)
        {
            Generate(id);
        }

        protected string Department { get; set; } = string.Empty;

        public override void Generate()
        {
            base.Generate();
            Department = Names.department[random.Next(Names.department.Length)];
        }

        public override void Generate(int id)
        {
            base.Generate(id);
            Department = Names.department[random.Next(Names.department.Length)];
        }

        public string ToString()
        {
            return base.ToString() +
                   string.Format($"{Department}");
        }

        public string toString(bool value)
        {
            return (value ? "EMP " : "") + ToString();
        }

        public string HtmlRow()
        {
            return "<tr>" + HtmlColumns() + "</tr>";
        }

        public string HtmlColumns()
        {
            return base.HtmlColumns() +
                   "<td>" + Department + "</td>";
        }
    }
}