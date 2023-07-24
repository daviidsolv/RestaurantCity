using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    private static GameUIManager instance;

    public static GameUIManager GetInstance() {
        return instance;
    }

    [SerializeField] private TextMeshProUGUI usernameTM;
    [SerializeField] private TextMeshProUGUI XP_Credits_TM;

    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void UpdateUI() {
        Debug.Log("Updating UI");
        Player player = GameManager.GetInstance().GetPlayer();
        usernameTM.text = player.GetUsername();
        XP_Credits_TM.text = "XP: " + player.GetExperience() + " Credits: " + player.GetCredits();
    }
}
