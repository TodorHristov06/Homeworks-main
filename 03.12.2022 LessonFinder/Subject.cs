using System;
using System.Collections.Generic;
using System.Linq;

public class Subject
{
    private string name;
    private List<Lesson> lessons;

    public string Name
    {
        get => name;
        set
        {
            if (value.Length < 2 || value.Length > 40)
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            name = value;
        }
    }

    public Subject(string name)
    {
        Name = name;
        lessons = new List<Lesson>();
    }

    public void AddLesson(Lesson lesson)
    {
        lessons.Add(lesson);
    }

    public void AddRate(string title, int rate)
    {
        Lesson foundLesson = lessons.FirstOrDefault(lesson => lesson.Title == title);
        if (foundLesson != null)
        {
            foundLesson.AddRating(rate);
        }
        else
        {
            throw new ArgumentException("Lesson not found!");
        }
    }

    public double AverageRating()
    {
        if (lessons.Count == 0)
        {
            return 0;
        }

        double totalRating = lessons.Sum(lesson => lesson.Rating);
        return totalRating / lessons.Count;
    }

    public List<Lesson> GetLessonsByTeacher(string teacher)
    {
        List<Lesson> teacherLessons = lessons.Where(lesson => lesson.Teacher == teacher)
                                             .OrderByDescending(lesson => lesson.Duration)
                                             .ToList();
        return teacherLessons;
    }

    public List<Lesson> GetLessonsBetweenDuration(int from, int to)
    {
        List<Lesson> durationLessons = lessons.Where(lesson => lesson.Duration >= from && lesson.Duration <= to)
                                              .OrderByDescending(lesson => lesson.Rating)
                                              .ToList();
        return durationLessons;
    }

    public override string ToString()
    {
        return $"Subject {Name}\nTotal Lessons: {lessons.Count}";
    }
}
