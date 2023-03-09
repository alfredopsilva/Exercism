using System;

public static class PlayAnalyzer
{

    public static string AnalyzeOnField(int shirtNum)
    {
        string position;

        switch (shirtNum)
        {
            case 1:
                position = "goalie";
                break;
            case 2:
                position = "left back";
                break;
            case 3:
            case 4:
                position = "center back";
                break;
            case 5:
                position = "right back";
                break;
            case 6:
            case 7:
            case 8:
                position = "midfielder";
                break;
            case 9:
                position = "left wing";
                break;
            case 10:
                position = "striker";
                break;
            case 11:
                position = "right wing";
                break;
            default:
                throw new ArgumentOutOfRangeException("You must insert a valid shirt number");
        }

        return position;
    }

    public static string AnalyzeOffField(object report)
    {
        string message = null;

        switch (report) {
            case (string):
                message = (string)report;
                break;
            case (int):
                message = $"There are {report} supporters at the match.";
                break;
            case (Manager):
                if (((Manager)report).Club == null)
                {
                    message = $"{((Manager)report).Name}";
                }
                else
                {
                    message = $"{((Manager)report).Name} ({((Manager)report).Club})"; 
                }
                break;
            case (Foul):
                message = ((Foul)report).GetDescription();
                break;
            case (Injury):
                message = $"Oh no! {((Injury)report).GetDescription()} Medics are on the field.";
                break;
            case (Incident):
                message = ((Incident)report).GetDescription();
                break;
            default:
                throw new ArgumentException();
                break;
        }

        return message;
    }
}
