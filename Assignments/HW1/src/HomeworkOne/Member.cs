using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOne
{
    public abstract class Member : IComparable<Member>, ISerializable
    {
        public Random random = new Random();
        public int ID = 0;
        protected string FirstName, LastName;

        public Member()
        {
            Generate();
        }

        public Member(int id)
        {
            Generate(id);
        }

        public void Generate()
        {
            ID = random.Next(999999999 - 10000000 + 1) + 10000000;
            FirstName = Names.firstName[random.Next(Names.firstName.Length)];
            LastName = Names.lastName[random.Next(Names.lastName.Length)];
        }

        public void Generate(int id)
        {
            ID = id;
        }
        
        public string toString()
        {
            return String.Format($"{ID, 6} {FirstName, 12} {LastName, 12}");
        }

        public string toString(bool value)
        {
            return String.Format($"{0} {ID,6} {FirstName,12} {LastName,12}", value ? "MEM":"");
        }

        public string htmlRow()
        {
            return "<tr>" + htmlColumns() + "</tr>";
        }

        public string htmlColumns()
        {
            return "<td>" + ID + "</td>" +
                    "<td>" + LastName + "</td>" +
                    "<td>" + FirstName + "</td>";
        }

        public int CompareTo(Member other)
        {
            return ID - other.ID;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
