using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Func : MonoBehaviour
{
    public TMP_InputField loginUsername;
    public TMP_InputField loginPassword;
    public TMP_Text loginStatus;

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
}
