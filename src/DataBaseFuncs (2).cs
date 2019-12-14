#define DBSESSIONTEST

using System;
using Systems.Collections.Generic;

public class Majors 
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
  
        // To check if LinkedList is empty or not 
        if (myList.Count > 0) 
            Console.WriteLine("LinkedList is not empty"); 
        else
            Console.WriteLine("LinkedList is empty"); 
    } 
}


string userinput = "Mechanical Engineering";

public class ReturnMajor
{
    public string[] ReturnMajor()
    {
        string current = Majors.First;
        List<String> majorlist = new List<String>(); 
        string[] majorarray;

        do
        {
            if(current == "Mechanical Engineering" || current == "Electrical Engineering" || current == "Computer Engineering" || current == "Biomedical Engineering")
            {
                majorlist.AddLast(current);
            }
            current = current.Next;
        } while ((current = current.Next) != null);

        majorarray = majorlist.ToArray();
        return majorarray;
    }

    string [] MajorsArray = ReturnMajor();
}

public class ReturnMajor_course
{
    public string[] ReturnMajor_courses(string userinput)
    {
        string current = Majors.First;
        string coursestring;
        do
        {
            if(current == userinput)
            {
                coursestring = current.Next;
            }
        } while ((current = current.Next) != null);

    }

    public string ReturnMajor_coursecredits(string[] userinput)
    {
        string current = Majors.First;
        do
        {
            if(current == userinput)
            {
                return current.Next;
            }
        } while ((current = current.Next) != null);

    }
}

string [] CurrentMajorCourses = ;
string [] CurrentMajorCourseCredits = ;

public class ReturnMajor_electives
{
    public string[] ReturnMajor_electives(string userinput)
    {
        string current = Majors.First;
        do
        {
            if(current == userinput)
            {
                current = current.Next;
                return current.Next;
            }
        } while ((current = current.Next) != null);

    }
}

string [] CurrentMajorElectives = ;

public class ReturnMajor_hub
{
    public string ReturnMajor_hub(string[] userinput)
    {
        string current = Majors.First;
        do
        {
            if(current == userinput)
            {
                current = current.Next;
                current = current.Next;
                return current.Next;
            }
        } while ((current = current.Next) != null);

    }
}


public class ReturnMajor_courses_and_credits
{
    public string 
}

public class 

public class DBCourse
{
    public String CourseName;
    public float CourseCredits;

    public DBCourse()
    {
        CourseName = "";
        CourseCredits = 0;
    }

}

public class DBSchool
{
    public String SchoolName;
    public int NumCourses;
    public DBCourse[] Courses;

    public DBSchool()
    {
        SchoolName = "";
        NumCourses = 0;
    }

}


public class DBUserCourse
{
    public DBCourse Course;
    public enum DBYear
    {
        DBYEAR_1,  //remember year 1 has the value 0
        DBYEAR_2,
        DBYEAR_3,
        DBYEAR_4
    };

    public DBYear Year;
}

public class DatabaseSession
{
    public enum DBSessionStatus
    {
        DBSESSIONSTATUS_VOID,  //basic so that the GUI can get status info
        DBSESSIONSTATUS_OPEN,
        DBSESSIONSTATUS_CLOSED,
        DBSESSIONSTATUS_ERROR
    }



    public DBSessionStatus SessionStatus;
    public String UserID;

    public int NumSchools;
    public DBSchool Schools; //this should be a linked list in the final implementation so it can vary in size.

    public DBUserCourse[] UserCourses;


    public DatabaseSession()
    {
        UserID = "";
        SessionStatus = DBSessionStatus.DBSESSIONSTATUS_VOID;
    }

    public void StartSession(String UserIDForSession)
    {

#if DBSESSIONTEST
        //hand initialising the database so you have stuff to work with
        UserID = UserIDForSession;
        SessionStatus = DBSessionStatus.DBSESSIONSTATUS_OPEN;

        //basic initialising
        Schools.SchoolName = "PAIGE CODING";
        Schools.NumCourses = 3;
        Schools.Courses = new DBCourse[3];

        Schools.Courses[0].CourseName = "C#";
        Schools.Courses[0].CourseCredits = 5;
        Schools.Courses[1].CourseName = "C++";
        Schools.Courses[1].CourseCredits = 11;
        Schools.Courses[2].CourseName = "C";
        Schools.Courses[2].CourseCredits = 22;

        UserCourses = new DBUserCourse[5];
        UserCourses[0].Course = Schools.Courses[0];
        UserCourses[0].Year = DBUserCourse.DBYear.DBYEAR_1;
        UserCourses[1].Course = Schools.Courses[0];
        UserCourses[1].Year = DBUserCourse.DBYear.DBYEAR_2;
        UserCourses[2].Course = Schools.Courses[0];
        UserCourses[2].Year = DBUserCourse.DBYear.DBYEAR_3;
        UserCourses[3].Course = Schools.Courses[2];
        UserCourses[3].Year = DBUserCourse.DBYear.DBYEAR_1;
        UserCourses[4].Course = Schools.Courses[1];
        UserCourses[4].Year = DBUserCourse.DBYear.DBYEAR_4;

#else

        // typically this is where you would run database access for the user.

#endif
    }

    public void StartSession(String UserIDForSession)
    {

#if DBSESSIONTEST
        UserID = UserIDForSession;
        SessionStatus = DBSessionStatus.DBSESSIONSTATUS_OPEN;
#else
        // typically this is where you would run database access for the user

#endif
    }

    public void EndSession()
    {
    }

    public void AddUserCourse() { } //will take course id, school, year, etc to add class - error check here for credit exceeding and duplicate courses & update interface
    public void RemoveUserCourse() { } 
}