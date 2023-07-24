using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AuthManager : MonoBehaviour
{    
    [SerializeField] private TMPro.TMP_InputField email;
    [SerializeField] private TMPro.TMP_InputField password;
    
    private bool _loginSucceded = false;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    
    public void SignIn()
    {
        if (email.text == "" || password.text == "")
        {
            Debug.LogError("Email or password is empty");
            return;
        }
        SignUpSupabase(email.text, password.text);
    }
    
    public void LogIn()
    {
        if (email.text == "" || password.text == "")
        {
            Debug.LogError("Email or password is empty");
            return;
        }
        SignInSupabase(email.text, password.text);
    }

    public async void SignInSupabase(string email, string password) {
        try {
            Supabase.Client _supabase = SBManager.GetSupabase();
            var session = await _supabase.Auth.SignIn(email, password);
            Debug.Log("Login successfull!");
            GameManager.GetInstance().SetPlayer(new Player(session.User.Id, session.User.Email));
            _loginSucceded = true;
        } catch (Supabase.Gotrue.Exceptions.GotrueException e) {
            Debug.LogError(e);
        }
    }

    public async void SignUpSupabase(string email, string password) {
        Supabase.Client _supabase = SBManager.GetSupabase();
        Supabase.Gotrue.Session session = await _supabase.Auth.SignUp(email, password);
        _loginSucceded = true;
    }

    private void FixedUpdate()
    {
        if (_loginSucceded && SceneManager.GetActiveScene().buildIndex == 0)
            SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    
    private void OnDestroy()
    {     
        SBManager.GetInstance().SignOut();
    }
}
