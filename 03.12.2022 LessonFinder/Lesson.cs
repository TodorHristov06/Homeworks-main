using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Lesson
{
    private string title;
    private int duration;
    private int grade;
    private int difficulty;
    private string teacher;
    private List<int> ratings;

    public string Title
    {
        get => title;
        set
        {
            if (value.Length < 3 || value.Length > 54)
            {
                throw new ArgumentException("Title should be between 3 and 54 characters!");
            }
            title = value;
        }
    }

    public int Duration
    {
        get => duration;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Duration should be positive!");
            }
            duration = value;
        }
    }

    public int Grade
    {
        get => grade;
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Grade should be between 1 and 12!");
            }
            grade = value;
        }
    }

    public int Difficulty
    {
        get => difficulty;
        set
        {
            if (value < 1 || value > 3)
            {
                throw new ArgumentException("Difficulty should be between 1 and 3!");
            }
            difficulty = value;
        }
    }

    public string Teacher
    {
        get => teacher;
        set
        {
            if (value.Length < 3 || value.Length > 54)
            {
                throw new ArgumentException("Teacher should be between 3 and 54 characters!");
            }
            teacher = value;
        }
    }

    public Lesson(string title, int duration, int grade, int difficulty, string teacher)
    {
        Title = title;
        Duration = duration;
        Grade = grade;
        Difficulty = difficulty;
        Teacher = teacher;
        ratings = new List<int>();
    }

    public void AddRating(int rate)
    {
        if (rate >= 1 && rate <= 5)
        {
            ratings.Add(rate);
        }
        else
        {
            throw new ArgumentException("Rating should be between 1 and 5!");
        }
    }

    public double Rating
    {
        get
        {
            if (ratings.Count == 0)
            {
                return 0;
            }
            return ratings.Average();
        }
    }

    public override string ToString()
    {
        return $"Title: {Title} for {Grade} grade ({Duration} mins.) - difficulty {Difficulty} by {Teacher} (Rating: {Rating:F2} / 5)";
    }
}
