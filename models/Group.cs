

public class Group
{

    public int GroupId { get; private set; }

    public string GroupName { get; set; }

    private int Count;


    public Group(string groupName, int groupId)
    {
        GroupName = groupName;
        GroupId = groupId;
        Count = 0;
    }


    public void DisplayGroupInfo()
    {
        Console.WriteLine($"Group ID: {GroupId}, Group Name: {GroupName}, Number of Students: {Count}");
    }


    public void AddStudent()
    {
        Count++;
    }

    public void RemoveStudent()
    {
        if (Count > 0)
        {
            Count--;
        }
    }


    public int GetStudentsCount()
    {
        return Count;
    }

    internal void ShowAllStudents()
    {
        throw new NotImplementedException();
    }
}
