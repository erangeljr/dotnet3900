using System;

namespace HomeworkOne
{
    [Serializable]
    public class Employee : Member
    {
        private int yearHired = 0;

        public Employee()
        {
            this.Generate();
        }

        public Employee(int id) : base(id)
        {
            this.Generate(id);
        }

        protected string Department { get; set; } = string.Empty;

        public new void Generate()
        {
            base.Generate();
            Department = Names.department[random.Next(Names.department.Length)];
        }

        public new void Generate(int id)
        {
            base.Generate(id);
            Department = Names.department[random.Next(Names.department.Length)];
        }

        public new string ToString()
        {
            return base.ToString() +
                   string.Format($"{Department}");
        }

        public string toString(bool value)
        {
            return (value ? "EMP " : "") + ToString();
        }

        public new string HtmlRow()
        {
            return "<tr>" + HtmlColumns() + "</tr>";
        }

        public new string HtmlColumns()
        {
            return base.HtmlColumns() +
                   "<td>" + Department + "</td>";
        }
    }
}