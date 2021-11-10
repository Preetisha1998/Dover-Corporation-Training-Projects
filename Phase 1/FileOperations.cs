using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assessment__Phase_1
{
    /// <summary>
    /// This class perform the write operation in the text file.
    /// </summary>
    class FileOperations
    {
        public FileOperations()
        {
            string fpath = @"C:\Users\11035915\source\repos\ProjectSolution\ProjectSolutionPhase1\Collection.txt";
            FileStream fname = new FileStream(fpath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fname);
            sw.WriteLine("Teachers Records are as shown below!!\n");


            List<Teachers> list = TeacherBo.teacherList;

            foreach (var item in list)
            {
                sw.WriteLine($"{item.ToString()}");
                sw.WriteLine("==========================================================================");
            }
            sw.Close();
        }
    }
}
