using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOne
{
    public class Faculty : Employee
    {
        protected string DegreeHeld { get; set; } = string.Empty;
        protected string Position { get; set; } = string.Empty;

        public Faculty()
        {
            Generate();
        }

        public Faculty(int id) : base(id)
        {
            Generate(id);
        }

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

        public String toString()
        {
            return base.toString() +
                    string.Format($" { DegreeHeld } { Position } ");
        }

        public String toString(bool value)
        {
            return (value ? "FAC " : "") + toString();
        }

        public String htmlRow()
        {
            return "<tr>" + htmlColumns() + "</tr>";
        }

        public String htmlColumns()
        {
            return
                    base.htmlColumns() +
                    "<td>" + DegreeHeld + "</td>" +
                    "<td>" + Position + "</td>";
        }
    }
}
