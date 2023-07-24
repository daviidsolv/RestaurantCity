using System.Collections;
using System.Collections.Generic;
using Supabase;
using Client = Supabase.Client;
using UnityEngine;
using Postgrest.Models;
using Postgrest.Attributes;

public class SBManager : MonoBehaviour
{
    public bool LoggedIn { get; private set;}

    public static SBManager instance;

    public const string url = "https://eaemgirnrgihpznobocu.supabase.co";
    public const string key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImVhZW1naXJucmdpaHB6bm9ib2N1Iiwicm9sZSI6ImFub24iLCJpYXQiOjE2Nzk1MDIzMzgsImV4cCI6MTk5NTA3ODMzOH0.YlbcPqanSG8FQC_MKbMeaIqbkFXMmNz_XvBlSFPiW24";

    private static Client _supabase;

    public static SBManager GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        LoggedIn = false;
        Debug.Log("SBManager Awake");
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        _supabase = new Client(url, key);
    }

    public static Client GetSupabase()
    {
        return _supabase;
    }    

    public Supabase.Gotrue.Session GetSession() {
        var session = _supabase.Auth.CurrentSession;
        return session;
    }

    public Supabase.Gotrue.User GetUser() {
        var user = _supabase.Auth.CurrentUser;
        return user;
    }

    public void SignOut() {
        _supabase.Auth.SignOut();
        LoggedIn = false;
    }
}
