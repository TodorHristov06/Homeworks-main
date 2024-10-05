using System;
using System.Collections.Generic;
using System.Linq;

public class Controller
{
    private Dictionary<string, Subject> subjects;

    public Controller()
    {
        subjects = new Dictionary<string, Subject>();
    }

    public string AddSubject(List<string> args)
    {
        string name = args[0];
        if (!subjects.ContainsKey(name))
        {
            subjects[name] = new Subject(name);
            return $"Created Subject {name}!";
        }
        return $"Subject {name} already exists";
    }

    public string AddLesson(List<string> args)
    {
        string name = args[0];
        string title = args[1];
        int duration = int.Parse(args[2]);
        int grade = int.Parse(args[3]);
        int difficulty = int.Parse(args[4]);
        string teacher = args[5];

        if (subjects.TryGetValue(name, out Subject subject))
        {
            if (args[6] == "online")
            {
                string platform = args[7];
                subject.AddLesson(new OnlineLesson(title, duration, grade, difficulty, teacher, platform));
            }
            else if (args[6] == "lecture")
            {
                string location = args[7];
                subject.AddLesson(new LectureLesson(title, duration, grade, difficulty, teacher, location));
            }
            return $"Created Lesson {title} in Subject {name}!";
        }
        return $"Subject {name} not found";
    }

    public string RateLesson(List<string> args)
    {
        string name = args[0];
        string title = args[1];
        int rate = int.Parse(args[2]);

        if (subjects.TryGetValue(name, out Subject subject))
        {
            try
            {
                subject.AddRate(title, rate);
                return $"Rated {title} with {rate} rate";
            }
            catch (ArgumentException)
            {
                return "Lesson not found!";
            }
        }
        return $"Subject {name} not found";
    }

    public string GetAverageRating(List<string> args)
    {
        string name = args[0];

        if (subjects.TryGetValue(name, out Subject subject))
        {
            double averageRating = subject.AverageRating();
            return $"The average rating is: {averageRating:F2}";
        }
        return $"Subject {name} not found";
    }

    public string GetLessonsByTeacher(List<string> args)
    {
        string name = args[0];
        string teacher = args[1];

        if (subjects.TryGetValue(name, out Subject subject))
        {
            List<Lesson> lessons = subject.GetLessonsByTeacher(teacher);
            string result = $"Lessons by {teacher} in {name}:\n";
            foreach (Lesson lesson in lessons)
            {
                result += $"{lesson.Title} - {lesson.Duration} mins\n";
            }
            return result;
        }
        return $"Subject {name} not found";
    }

    public string GetLessonsBetweenDuration(List<string> args)
    {
        string name = args[0];
        int from = int.Parse(args[1]);
        int to = int.Parse(args[2]);

        if (subjects.TryGetValue(name, out Subject subject))
        {
            List<Lesson> lessons = subject.GetLessonsBetweenDuration(from, to);
            string result = $"Lessons in {name} between {from} and {to} minutes:\n";
            foreach (Lesson lesson in lessons)
            {
                result += $"{lesson.Title} - {lesson.Rating}\n";
            }
            return result;
        }
        return $"Subject {name} not found";
    }

    public string End()
    {
        Environment.Exit(0);
        return string.Empty; 
    }
}
