using System;
public class LectureLesson : Lesson
{
    private string location;

    public LectureLesson(string title, int duration, int grade, int difficulty, string teacher, string location)
        : base(title, duration, grade, difficulty, teacher)
    {
        Location = location;
    }

    public string Location
    {
        get => location;
        set => location = value;
    }

    public override string ToString()
    {
        return $"Title: {Title} for {Grade} grade ({Duration} mins.) - difficulty {Difficulty} by {Teacher} (Rating: {Rating} / 5) @ Onsite: {Location}";
    }
}
