using UnityEngine;

public class Player
{
    private string id;
    private string username;
    private int experience;
    private int credits;

    private PlayerDAO playerDAO;

    public Player(string id, string username)
    {
        LoadPlayer(id);
    }

    public async void LoadPlayer(string id) {
        Debug.Log("Loading player with uid: " + id + "...");
        Supabase.Client _supabase = SBManager.GetSupabase();
        var res = await _supabase.From<PlayerDAO>().Get();

        Debug.Log(res.Model);

        if (res.Model != null) {
            playerDAO = res.Model;
            this.username = playerDAO.Username;
            this.id = playerDAO.Uid;
            this.experience = playerDAO.Experience;
            this.credits = playerDAO.Credits;

            GameUIManager.GetInstance().UpdateUI();
        }
    }

    public string GetUid()
    {
        return id;
    }

    public string GetUsername()
    {
        return username;
    }

    public int GetExperience()
    {
        return experience;
    }

    public int GetCredits()
    {
        return credits;
    }

    public async void SetUsername(string username)
    {
        this.username = username;
        playerDAO.Username = username;
        await playerDAO.Update<PlayerDAO>();
        GameUIManager.GetInstance().UpdateUI();
    }
}
