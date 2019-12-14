﻿#define DATABASEFUNCS

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
        }

        return majorcourses;

    }

    static public List<String> ReturnMajor_coursecredits(string userinput)
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        List<String> majorcoursecredits = new List<String>();
        
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

        return majorcoursecredits;

    }


    static string electivestring;
    static public List<String> ReturnMajor_electives(string userinput)
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        List<String> majorcourseelectives = new List<String>();
        
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

        return majorcourseelectives;
    }


    static string hubstring;
    static public List<String> ReturnMajor_hub(string userinput)
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        List<String> majorcoursehubs = new List<String>();
        
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

        return majorcoursehubs;
    }
}