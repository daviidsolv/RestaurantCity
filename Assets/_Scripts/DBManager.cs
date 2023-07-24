using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class DBManager : MonoBehaviour
{
    // Create singleton
    private static DBManager instance;

    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public static DBManager GetInstance() {
        return instance;
    }

    private void Start() {
    }

    public void SaveUser(Player player)
    {
    }

    public void LoadUser(string userId)
    {
    }

    /*public async Task<bool> UserExists(string userId)
    {
        Debug.Log("Checking if user exists...");
        bool exists = false;

        return exists;
    }*/

    public void SaveGrid(Grid grid)
    {
        // Save grid to database
        string playerId = GameManager.GetInstance().GetPlayer().GetUid();
    }

}
