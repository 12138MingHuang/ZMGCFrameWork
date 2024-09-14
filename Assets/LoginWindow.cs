using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ZMGC.Hall;

public class LoginWindow : MonoBehaviour
{
    public InputField accountInput;
    public InputField passwordInput;
    private LoginLogicCtrl _loginLogic;
    
    void Start()
    {
        _loginLogic = HallWorld.GetExitsLogicCtrl<LoginLogicCtrl>();
    }

    private void OnEnable()
    {
        UIEventControl.AddEvent(UIEventEnum.LoginSuccess, OnLoginSuccess);
    }

    private void OnDisable()
    {
        UIEventControl.RemoveEvent(UIEventEnum.LoginSuccess, OnLoginSuccess);
    }

    private void OnLoginSuccess(object data)
    {
        Debug.Log("登录成功");
    }
    
    public void LoginButtonClick()
    {
        int result = _loginLogic.AccountLogin(accountInput.text, passwordInput.text);
        if (result == 1)
        {
            Debug.Log("账号不符合规范");
        }
        else if (result == 2)
        {
            Debug.Log("密码不符合规范");
        }
    }
}
