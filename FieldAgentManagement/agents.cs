public class agent
{
    private string CodeName { get; set; }
    private string RealName { get; set; }
    private string Location { get; set; }
    private string Status { get; set; }
    private int MissionsCompleted { get; set; }

    public agent(string codeName, string realName, string location, string status, int missionsCompleted)
    {
        this.CodeName = codeName;
        this.RealName = realName;
        this.Location = location;
        this.Status = status;
        this.MissionsCompleted = missionsCompleted;
    }



}