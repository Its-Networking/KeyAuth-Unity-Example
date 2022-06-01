using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Func : MonoBehaviour
{
    [Header("Login")]
    public TMP_InputField loginUsername;
    public TMP_InputField loginPassword;
    
    [Header("Register")]
    public TMP_InputField registerUsername;
    public TMP_InputField registerPassword;
    public TMP_InputField registerKey;

    [Header("Status")]
    public TMP_Text statusLbl;

    private static api KeyAuthApp = new api(
    name: "",
    ownerid: "",
    secret: "",
    version: ""
    );

    public void Awake()
    {
        KeyAuthApp.init();
    }

    public void loginType()
    {
        KeyAuthApp.login(loginUsername.text, loginPassword.text);
        if (KeyAuthApp.response.success)
        {
            loginStatus.text = "Welcome " + loginUsername.text;
        }
        else
        {
            loginStatus.text = "Failed";
        }
    }
    
     public void loginType()
    {
        KeyAuthApp.login(registerUsername.text, registerPassword.text, registerKey.text);
        if (KeyAuthApp.response.success)
        {
            statusLbl.text = "Success, welcome " + registerUsername.text;
        }
        else
        {
            statusLbl.text = "Failed";
        }
    }
}
