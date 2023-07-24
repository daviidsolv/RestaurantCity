using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public static GameManager GetInstance() {
        return instance;
    }

    private Player player;

    public Player GetPlayer() {
        return player;
    }

    public void SetPlayer(Player player) {
        this.player = player;
    }
}
