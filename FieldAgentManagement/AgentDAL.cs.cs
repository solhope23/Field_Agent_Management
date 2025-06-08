using System;
using MySql.Data.MySqlClient;

public class AgentDAL
{
    private string connStr;
    private MySqlConnection agents;

    public AgentDAL(string server, string username, string password = "", string database)
    {
        connStr = $"server={server};username={username};password={password};database={database}";

        this.agents = new MySqlConnection(connStr);

        TryConnect(); 
    }

    private void TryConnect()
    {
        try
        {
            this.agents.Open();
        }
        catch (Exception e)
        {
            Console.WriteLine($"err: {e.Message}");
        }
        finally
        {
            this.agents.Close();
        }
    }

    public 

}