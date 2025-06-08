public class agent
{
    public string CodeName { get; private set; }
    public string RealName { get; private set; }
    public string Location { get; private set; }
    public string Status { get; private set; }
    public int MissionsCompleted { get; private set; }

    public agent(string codeName, string realName, string location, string status, int missionsCompleted)
    {
        this.CodeName = codeName;
        this.RealName = realName;
        this.Location = location;
        this.Status = status;
        this.MissionsCompleted = missionsCompleted;
    }



}