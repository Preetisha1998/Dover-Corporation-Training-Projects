using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment__Phase_1
{
    /// <summary>
    /// This class handles all the operations related to teacher in it
    /// </summary>
    class TeacherBo
    {
        public static List<Teachers> teacherList;
        public TeacherBo()
        {
            teacherList = new List<Teachers>();
        }

        public Boolean addTeacher(int id, string name, string clas, string section)
        {
            Teachers t = new Teachers(id, name, clas, section);
            teacherList.Add(t);
            return true;

        }
        public void Display()
        {
            foreach (var item in teacherList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public Teachers getTeacherById(int id)
        {
            return teacherList.Find(x => x.id == id);
        }
        public string teacherDelete(int id)
        {
            Teachers t = teacherList.Find(x => x.id == id);
            teacherList.Remove(t);
            return "Item Deleted!!";
        }
        public string teacherEdit(int id, string name, string clas, string section)
        {
            var index = teacherList.FindIndex(x => x.id == id);
            if (index>-1)
            {
                teacherList[index].name = name;
                teacherList[index].clas = clas;
                teacherList[index].section = section;
            }
            else
            {
                Console.WriteLine("Record Not Found. Please enter it using the menu shown!!");
            }

            return "Item updated!!";


        }
    }
}

