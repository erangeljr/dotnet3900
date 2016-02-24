using System;
using System.Runtime.Serialization;

namespace HomeworkOne
{
    public abstract class Member : IComparable<Member>, ISerializable
    {
        protected string FirstName, LastName;
        public int ID;
        public Random random = new Random();

        public Member()
        {
            Generate();
        }

        public Member(int id)
        {
            Generate(id);
        }

        public int CompareTo(Member other)
        {
            return ID - other.ID;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", ID, typeof (int));
            info.AddValue("FirstName", FirstName, typeof (string));
            info.AddValue("LastName", LastName, typeof (string));
        }

        public virtual void Generate()
        {
            ID = random.Next(999999999 - 10000000 + 1) + 10000000;
            FirstName = Names.firstName[random.Next(Names.firstName.Length)];
            LastName = Names.lastName[random.Next(Names.lastName.Length)];
        }

        public virtual void Generate(int id)
        {
            ID = id;
        }

        public string ToString()
        {
            return string.Format($"{ID,6} {FirstName,12} {LastName,12}");
        }

        public string ToString(bool value)
        {
            return string.Format($"{0} {ID,6} {FirstName,12} {LastName,12}", value ? "MEM" : "");
        }

        public string HtmlRow()
        {
            return "<tr>" + HtmlColumns() + "</tr>";
        }

        public string HtmlColumns()
        {
            return "<td>" + ID + "</td>" +
                   "<td>" + LastName + "</td>" +
                   "<td>" + FirstName + "</td>";
        }
    }
}