using System;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

public class AgentDAL
{
    private string connStr;
    private MySqlConnection agents;

    public AgentDAL(string server, string username, string database, string password = "")
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

    public void AddAgent(agent Agent)
    {
        try
        {
            this.agents.Open();

            string query = "INSERT INTO agents(codeName, realName, location, status, missionsCompleted)" +
                           " VALUES (@codeName, @realName, @location, @status, @missionsCompleted)";

            MySqlCommand cmd = new MySqlCommand(query, this.agents);

            cmd.Parameters.AddWithValue("@codeName", Agent.CodeName);
            cmd.Parameters.AddWithValue("@realName", Agent.RealName);
            cmd.Parameters.AddWithValue("@location", Agent.Location);
            cmd.Parameters.AddWithValue("@status", Agent.Status);
            cmd.Parameters.AddWithValue("@missionsCompleted", Agent.MissionsCompleted);

            cmd.ExecuteNonQuery();

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
}