using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZMGC.Hall
{
    public class LoginMsgMgr : IMsgBehaviour
    {

        public void OnCreate()
        {

        }
        
        public void SendLoginRequest(string account, string password)
        {
            //创建出通讯结构体，发送给服务端
            
            //测试代码
            OnLoginResponse();
        }

        public void OnLoginResponse()
        {
            UserDataServerModelTest userData = new UserDataServerModelTest();
            userData.id = Random.Range(0, 99999);
            userData.name = "张三";
            userData.gold = Random.Range(0, 100000);
            HallWorld.GetExitsLogicCtrl<LoginLogicCtrl>().OnLoginResult(userData);
        }
        
        public void OnDestroy()
        {

        }
    }
}
