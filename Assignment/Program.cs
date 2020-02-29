using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment.ModelClass;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            BusinessLayer businesslayer = new BusinessLayer();
            List<WholeDetails> Listwholedetails = new List<WholeDetails>();

            Listwholedetails = businesslayer.Bl_GetAllRequireDetails();

            Console.WriteLine("StudentName" + "\t" + "Professor" + "\t" + "CourseName");

            foreach (WholeDetails wholedetailsobj in Listwholedetails)

            {
                Console.WriteLine(wholedetailsobj.StudentName + "\t" + wholedetailsobj.Professor
                    + "\t" + wholedetailsobj.CourseName);

            }

            Console.WriteLine("Press the any key to see the change ");
            Console.WriteLine();
            Console.ReadLine();


            List<ChangeData> listChangeDetails = new List<ChangeData>();

            listChangeDetails = businesslayer.Bl_GetChangeDetails();
            

            if (listChangeDetails.Count == 0)
                Console.WriteLine("NO Change added");
            else
            {
                Console.WriteLine("StudentName" + "\t" + "\t" + "Professor" + "\t" + "\t" + "Action" + "\t" + "\t" + "Type");
                foreach (ChangeData changedata in listChangeDetails)
                {
                    if (string.IsNullOrEmpty(changedata.StudentName))
                        Console.Write("No Data" + "\t" + "\t" + "\t");
                    else
                        Console.Write(changedata.StudentName + "\t" + "\t" + "\t");
                    if (string.IsNullOrEmpty(changedata.Professor))
                        Console.Write("No Data" + "\t" + "\t");
                    else
                        Console.Write(changedata.Professor + "\t" + "\t");
                    if (changedata.ActionType.ToUpper() == "INSERT")
                        Console.Write("NEW RECORD" + "\t" + "\t");
                    else if (changedata.ActionType.ToUpper() == "UPDATE")
                        Console.Write("RECORD UPDATED" + "\t" + "\t");
                    else
                        Console.Write("RECORD DELETED" + "\t" + "\t");

                    if (changedata.ActionType.ToUpper() == "STUDENT")
                        Console.Write("STUDENT");
                    else
                        Console.Write("COURSE/PROFESSOR ADDED");

                    Console.WriteLine();

                }
               
            }
            Console.ReadLine();
        }
        
    }
}
