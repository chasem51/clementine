#define DATABASEFUNCS

using System;
using Systems.Collections.Generic;

public class DataBase
{

    // Driver code 
    public static void MakeMajors()
    {

        // Creating a LinkedList of Strings 
        LinkedList<String> Majors = new LinkedList<String>();

        // Biomedical Engineering 
        Majors.AddLast("Biomedical Engineering");
        Majors.AddLast("Required, CAS MA123, 4, ENG EK100, 0, CAS CH101, 4, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, CAS CH102, 4, ENG EK131, 2, ENG EK103, 3, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG EK210, 2, CAS WR150, 4, CAS MA226, 4, ENG BE209, 4, ENG EK301, 4, ENG EK381, 4, CAS BI315, 4, ENG BE403, 4, ENG BE403, 4, ENG BE491, 2, ENG EK424, 4, ENG BE 492, 2, ENG BE465, 2, ENG BE466, 4, end");
        Majors.AddLast("Electives, One Continua & Fields Elective, Two Suitable Professional Electives, One Engineering elective, Two Biomedical engineering electives, One Biomedical engineering design elective");
        Majors.AddLast("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

        //Computer Engineering

        Majors.AddLast("Computer Engineering");
        Majors.AddLast("Required, CAS MA123, 4, CAS CH 131, 4, ENG EK100, 0, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, ENG EK131, 2, ENG EK103, 3, CAS WR150, 4, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG EK327, 4, CAS MA226, 4, ENG EC311, 4, ENG EK301, 4, ENG EK210, 2, ENG EC330, 4, ENG EK381, 4, ENG EC413, 4, CAS MA193, 2, ENG EC463, 4, ENG EC464, 4, end");
        Majors.AddLast("Electives, Two Core Electives, Two Computer Engineering Electives, One EE Breadth Elective, 3 Technical Electives");
        Majors.AddLast("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

        // Mechaincal Engineering

        Majors.AddLast("Mechanical Engineering");
        Majors.AddLast("Required, CAS MA123, 4, CAS CH 131, 4, ENG EK100, 0, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, ENG EK131, 2, ENG EK103, 3, CAS WR150, 4, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG ME357, 2, CAS MA226, 4, ENG EC381, 4, ENG EK301, 4, ENG EK210, 2, ENG ME304, 4, ENG ME303, 4, ENG ME305, 4, ENG ME358, 2, ENG ME306, 4, ENG ME419, 4, ENG ME302, 4, ENG ME360, 4, ENG ME310, 4, ENG ME460, 4, ENG ME461, 4, end");
        Majors.AddLast("Electives, Four Advanced Electives");
        Majors.AddLast("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

        // Electrical Engineering

        Majors.AddLast("Electrical Engineering");
        Majors.AddLast("Required, CAS MA123, 4, CAS CH 131, 4, ENG EK100, 0, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, ENG EK131, 2, ENG EK103, 3, CAS WR150, 4, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG EK210, 2, CAS MA226, 4, CAS PY 313, 4, ENG EK301, 4, ENG EC455, 4, ENG EC401, 4, ENG EC311, 4, ENG EC311, 4, ENG EK381, 4, END EC 463, 4, ENG EC 464, 4, end");
        Majors.AddLast("Electives, One Electronics Elective, One Systems Elective, One Electrophysics Elective, One Computer Elective, Three Technical Electives");
        Majors.AddLast("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

        Majors.AddLast(NULL);
    }

    public List<String> ReturnMajor()
    {
        string current = Majors.First;
        List<String> majorlist = new List<String>();
        string[] majorarray;

        do
        {
            if (current == "Mechanical Engineering" || current == "Electrical Engineering" || current == "Computer Engineering" || current == "Biomedical Engineering")
            {
                majorlist.AddLast(current);
            }
            current = current.Next;
        } while ((current = current.Next) != null);

        majorarray = majorlist.ToArray();
        return majorlist;
    }

    public List<String> ReturnMajor_courses(string userinput)
    {
        string current = Majors.First;
        List<String> majorcourses = new List<String>();
        string coursestring;
        do
        {
            if (current == userinput)
            {
                coursestring = current.Next;
            }
        } while ((current = current.Next) != null);

        string[] coursearrayandcredit = coursestring.split(',');

        for (i = 1; i < coursearrayandcredit.size; i + 2)
        {
            majorcourses.AddLast(coursearrayandcredit[i]);
        }

        return majorcourses;

    }

    public List<String> ReturnMajor_coursecredits(string userinput)
    {
        string current = Majors.First;
        List<String> majorcoursecredits = new List<String>();
        string coursestring;
        do
        {
            if (current == userinput)
            {
                coursestring = current.Next;
            }
        } while ((current = current.Next) != null);

        string[] coursearrayandcredit = coursestring.split(',');

        for (i = 2; i < coursearrayandcredit.size; i + 2)
        {
            majorcoursecredits.AddLast(coursearrayandcredit[i]);
        }

        return majorcoursecredits;

    }



    public List<String> ReturnMajor_electives(string userinput)
    {
        string current = Majors.First;
        List<String> majorcourseelectives = new List<String>();
        string electivestring;
        do
        {
            if (current == userinput)
            {
                current = current.Next;
                electivestring = current.Next;
            }
        } while ((current = current.Next) != null);

        string[] electives = electivestring.split(',');

        for (i = 0; i < electives.size; i++)
        {
            majorcourseelectives.AddLast(electives[i]);
        }

        return majorcourseelectives;
    }



    public List<String> ReturnMajor_hub(string[] userinput)
    {
        string current = Majors.First;
        List<String> majorcoursehubs = new List<String>();
        string hubstring;
        do
        {
            if (current == userinput)
            {
                current = current.Next;
                current = current.Next;
                hubstring = current.Next;
            }
        } while ((current = current.Next) != null);

        string[] hubs = hubstring.split(',');

        for (i = 0; i < hubs.size; i++)
        {
            majorcoursehubs.AddLast(electives[i]);
        }

        return majorcoursehubs;
    }
}