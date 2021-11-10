using System;

namespace Assessment__Phase_1
{
    class Program
    {
        /// <summary>
        /// This is the main method where the program execution starts
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int g = 1;
            TeacherBo tbo = new TeacherBo();
            //int cnt = 0;

            while (g == 1)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Hi, welcome to Little Flower School!!\nI am your friendly bot.\nHow can I help you with?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please select from the menu below, to perform action required :");
                Console.WriteLine("1: Display all the Teachers  ");
                Console.WriteLine("2: Display the teachers by ID");
                Console.WriteLine("3: Add a Teacher details ");
                Console.WriteLine("4: Delete a Teacher details");
                Console.WriteLine("5: Edit Teacher details");
                Console.WriteLine("6: Exit\n");
                int op = Convert.ToInt32(Console.ReadLine());



                switch (op)
                {
                    case 1:
                        tbo.Display();
                        break;

                    case 2:
                        Console.WriteLine("Enter the Id of Teacher:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Teachers it = tbo.getTeacherById(id);
                        Console.WriteLine(it.ToString());
                        break;

                    case 3:
                        Console.WriteLine("Enter Teacher's ID");
                        int tID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the class: ");
                        string clas = Console.ReadLine();
                        Console.WriteLine("Enter the section");
                        string section = Console.ReadLine();
                        tbo.addTeacher(tID, name, clas, section);
                        //tbo.Display();
                        break;

                    case 4:
                        Console.WriteLine("Enter the Id of Teacher to Delete it :");
                        int idToDelete = Convert.ToInt32(Console.ReadLine());
                        tbo.teacherDelete(idToDelete);
                        break;

                    case 5:
                        Console.WriteLine("Enter the ID of Teacher to edit the record:");
                        int idToEdit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the updated name: ");
                        string ed_name = Console.ReadLine();
                        Console.WriteLine("Enter the updated class: ");
                        string ed_clas = Console.ReadLine();
                        Console.WriteLine("Enter the updated section");
                        string ed_section = Console.ReadLine();
                        tbo.teacherEdit(idToEdit, ed_name, ed_clas, ed_section);
                        break;

                    case 6:
                        g = 0;
                        break;

                    default:
                        Console.WriteLine("Please select the valid value.");
                        break;
                }

            }
            FileOperations fp = new FileOperations();


            //Console.WriteLine(t.ToString());
        }
    }
}


