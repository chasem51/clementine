#define DATABASEFUNCS

using System;
using System.Collections.Generic;

public class DataBase
{

    // Driver code 
    public static LinkedList<String> MakeMajors()
    {

        // Creating a LinkedList of Strings 
        var Majors = new LinkedList<String>();

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

        Majors.AddLast("0");

        return Majors;
    }



    static public List<String> ReturnMajor()
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        var currentalias = Majors.First.Next;
        List<String> majorlist = new List<String>();
        /*
        do
        {
            if (current.ToString() == "Mechanical Engineering" || current.ToString() == "Electrical Engineering" || current.ToString() == "Computer Engineering" || current.ToString() == "Biomedical Engineering")
            {
                majorlist.Add(current.ToString());
            }
            current = currentalias;
            currentalias = currentalias.Next;
        } while ((currentalias) != null);
        */

        majorlist.Add("Mechanical Engineering");
        majorlist.Add("Elecrical Engineering");
        majorlist.Add("Computer Engineering");
        majorlist.Add("Biomedical Engineering");


        return majorlist;
    }

    static string coursestring;
    static public List<String> ReturnMajor_courses(string userinput)
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        List<String> majorcourses = new List<String>();
        /*
       do
       {
           if (current.ToString() == userinput)
           {
               coursestring = current.ToString();
           }
           current = current.Next;
       } while ((current) != null);

       string[] coursearrayandcredit = coursestring.Split(',');


       for (int i = 1; i < coursearrayandcredit.Length; i = i+2)
       {
           majorcourses.Add(coursearrayandcredit[i]);
           majorcourseelectives.add("One Systems Elective")
            majorcourseelectives.add("One Electrophysics Elective");
            majorcourseelectives.add("One Computer Elective");
            majorcourseelectives.add("Three Technical Electives");
       }
       */

        if (userinput == "Biomedical Engineering")
        {
            majorcourses.add("CAS MA123");
            majorcourses.add("ENG EK100");
            majorcourses.add("CAS CH101");
            majorcourses.add("ENG EK125");
            majorcourses.add("CAS WR120");
            majorcourses.add("CAS MA124");
            majorcourses.add("CAS PY211");
            majorcourses.add("CAS CH102");
            majorcourses.add("ENG EK131");
            majorcourses.add("ENG EK103");
            majorcourses.add("CAS MA225");
            majorcourses.add("CAS PY212");
            majorcourses.add("ENG EK307");
            majorcourses.add("ENG EK210");
            majorcourses.add("CAS WR150");
            majorcourses.add("CAS MA226");
            majorcourses.add("ENG BE209");
            majorcourses.add("ENG EK301");
            majorcourses.add("ENG EK381");
            majorcourses.add("CAS BI315");
            majorcourses.add("ENG BE403");
            majorcourses.add("ENG BE403");
            majorcourses.add("ENG BE491");
            majorcourses.add("ENG EK424");
            majorcourses.add("ENG BE492");
            majorcourses.add("ENG BE465");
            majorcourses.add("ENG BE466");
        }
        else if (userinput == "Computer Engineering")
        {
            majorcourses.add("CAS MA123");
            majorcourses.add("CAS CH131");
            majorcourses.add("ENG EK100");
            majorcourses.add("ENG EK125");
            majorcourses.add("CAS WR120");
            majorcourses.add("CAS MA124");
            majorcourses.add("CAS PY211");
            majorcourses.add("ENG EK131");
            majorcourses.add("ENG EK103");
            majorcourses.add("CAS WR150");
            majorcourses.add("CAS MA225");
            majorcourses.add("CAS PY212");
            majorcourses.add("ENG EK307");
            majorcourses.add("ENG EK327");
            majorcourses.add("CAS MA226");
            majorcourses.add("ENG EC311");
            majorcourses.add("ENG EK301");
            majorcourses.add("ENG EK210");
            majorcourses.add("ENG EC330");
            majorcourses.add("ENG EK381");
            majorcourses.add("ENG EC413");
            majorcourses.add("CAS MA193");
            majorcourses.add("ENG EC463");
            majorcourses.add("ENG EC464");


        }
        else if (userinput == "Mechanical Engineering")
        {
            majorcourses.add("CAS MA123");
            majorcourses.add("CAS CH131");
            majorcourses.add("ENG EK100");
            majorcourses.add("ENG EK125");
            majorcourses.add("CAS WR120");
            majorcourses.add("CAS MA124");
            majorcourses.add("CAS PY211");
            majorcourses.add("ENG EK131");
            majorcourses.add("ENG EK103");
            majorcourses.add("CAS WR150");
            majorcourses.add("CAS MA225");
            majorcourses.add("CAS PY212");
            majorcourses.add("ENG EK307");
            majorcourses.add("ENG ME357");
            majorcourses.add("CAS MA226");
            majorcourses.add("ENG EC381");
            majorcourses.add("ENG EK301");
            majorcourses.add("ENG EK210");
            majorcourses.add("ENG ME304");
            majorcourses.add("ENG ME303");
            majorcourses.add("ENG ME305");
            majorcourses.add("ENG ME358");
            majorcourses.add("ENG ME306");
            majorcourses.add("ENG ME419");
            majorcourses.add("ENG ME302");
            majorcourses.add("ENG ME360");
            majorcourses.add("ENG ME310");
            majorcourses.add("ENG ME460");
            majorcourses.add("ENG ME461");

        }
        else if (userinput == "Electrical Engineering")
        {
            majorcourses.Add("CAS MA123");
            majorcourses.Add("CAS CH131");
            majorcourses.Add("ENG EK100");
            majorcourses.Add("ENG EK125");
            majorcourses.Add("CAS WR120");
            majorcourses.Add("CAS MA124");
            majorcourses.Add("CAS PY211");
            majorcourses.Add("ENG EK131");
            majorcourses.Add("ENG EK103");
            majorcourses.Add("CAS WR150");
            majorcourses.Add("CAS MA225");
            majorcourses.Add("CAS PY212");
            majorcourses.Add("ENG EK307");
            majorcourses.Add("ENG EK210");
            majorcourses.Add("CAS MA226");
            majorcourses.Add("CAS PY313");
            majorcourses.Add("ENG EK301");
            majorcourses.Add("ENG EC455");
            majorcourses.Add("ENG EC401");
            majorcourses.Add("ENG EC311");
            majorcourses.Add("ENG EK381");
            majorcourses.Add("ENG EC464");
        }

        return majorcourses;


    }

    static public List<String> ReturnMajor_coursecredits(string userinput)
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        List<String> majorcoursecredits = new List<String>();

        /*
        do
        {
            if (current.ToString() == userinput)
            {
                coursestring = Majors.First.Next.ToString();
            }
            current = current.Next;
        } while ((current.ToString()) != "0");

        string[] coursearrayandcredit = coursestring.Split(',');

        for (int i = 2; i < coursearrayandcredit.Length; i = i + 2)
        {
            majorcoursecredits.Add(coursearrayandcredit[i]);
        }
        */

        if (userinput == "Biomedical Engineering")
        {
            majorcoursecredits.add("4");
            majorcoursecredits.add("0");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("3");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
        }
        else if (userinput == "Computer Engineering")
        {

            majorcoursecredits.add("4");
            majorcoursecredits.add("0");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("3");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
        }
        else if (userinput == "Mechanical Engineering")
        {

            majorcoursecredits.add("4");
            majorcoursecredits.add("0");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("3");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
        }
        else if (userinput == "Electrical Engineering")
        {

            majorcoursecredits.add("4");
            majorcoursecredits.add("0");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("3");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("4");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("2");
            majorcoursecredits.add("4");
        }

        return majorcoursecredits;

    }


    static string electivestring;
    static public List<String> ReturnMajor_electives(string userinput)
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        List<String> majorcourseelectives = new List<String>();

        /*
        do
        {
            if (current.ToString() == userinput)
            {
                current =current.Next;
                electivestring = current.Next.ToString();
            }
            current = current.Next;
        } while ((current) != null);

        string[] electives = electivestring.Split(',');

        for (int i = 0; i < electives.Length; i++)
        {
            majorcourseelectives.Add(electives[i]);
        }
        */
        if (userinput == "Biomedical Engineering")
        {
            majorcourseelectives.add("One Continua & Fields Elective");
            majorcourseelectives.add("Two Suitable Professional Electives");
            majorcourseelectives.add("One Engineering elective");
            majorcourseelectives.add("Two Biomedical engineering electives");
            majorcourseelectives.add("One Biomedical engineering design elective");
        }
        else if (userinput == "Computer Engineering")
        {
            majorcourseelectives.add("Two Core Electives");
            majorcourseelectives.add("Two Computer Engineering Electives");
            majorcourseelectives.add("One EE Breadth Elective");
            majorcourseelectives.add("Technical Electives");
        }
        else if (userinput == "Mechanical Engineering")
        {
            majorcourseelectives.add("Four Advanced Electives");
        }
        else if (userinput == "Electrical Engineering")
        {
            majorcourseelectives.add("One Systems Elective");
            majorcourseelectives.add("One Electrophysics Elective");
            majorcourseelectives.add("One Computer Elective");
            majorcourseelectives.add("Three Technical Electives");
        }


        return majorcourseelectives;
    }


    static string hubstring;
    static public List<String> ReturnMajor_hub(string userinput)
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        List<String> majorcoursehubs = new List<String>();

        /*
        do
        {
            if (current.ToString() == userinput)
            {
                current = current.Next;
                current = current.Next;
                hubstring = current.Next.ToString();
            }

            current = current.Next;
        } while ((current = current.Next) != null);

        string[] hubs = hubstring.Split(',');

        for (int i = 0; i < hubs.Length; i++)
        {
            majorcoursehubs.Add(hubs[i]);
        }
        */
        majorcoursehubs.add("PIL");
        majorcoursehubs.add("AE");
        majorcoursehubs.add("HC");
        majorcoursehubs.add("SI");
        majorcoursehubs.add("IC");
        majorcoursehubs.add("GCI");
        majorcoursehubs.add("GCI");
        majorcoursehubs.add("ER");



        return majorcoursehubs;
    }
}