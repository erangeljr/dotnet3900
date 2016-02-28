using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOne
{
    public class MemberManager
    {

        static Member[] memberArray = null;
        static List<Member> memberList = new List<Member>();
        static Random random = new Random();

        public MemberManager()
        {

        }

        public static Member GetMember()
        {
            int kind = random.Next(4);

            switch (kind)
            {
                case 0:
                    return new Staff();
                case 1:
                    return new Faculty();
                case 2:
                    return new Employee();
                case 3:
                    return new Student();
            }
            return null;
        }

        private static void GenerateMembers(int number)
        {
            Console.WriteLine($"Generating {number} members");
            memberArray = new Member[number];
            for (int i = 0; i < number; i++)
            {
                var member = GetMember();
                memberArray[i] = member;
                memberList.Add(member);
            }
            Console.WriteLine($"Array Length: {memberArray.Length} ");
            Console.WriteLine($"List Length: {memberList.Count} ");
        }


    }
}
