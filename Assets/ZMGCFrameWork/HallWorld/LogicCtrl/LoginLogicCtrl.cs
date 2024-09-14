using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZMGC.Hall
{
    public class LoginLogicCtrl : ILogicBehaviour
    {
        private LoginMsgMgr _loginMsg;
        public void OnCreate()
        {
            _loginMsg = HallWorld.GetExitsMsgMgr<LoginMsgMgr>();
        }

        public int AccountLogin(string account, string password)
        {
            if (account.Length < 6) return 1;
            if (password.Length < 6) return 2;
            _loginMsg.SendLoginRequest(account, password);
            return 0;
        }

        public void OnLoginResult(UserDataServerModelTest user)
        {
            UserDataMgr userData = HallWorld.GetExitsDataMgr<UserDataMgr>();
            userData.CacheUserData(user);
            
            //通过时间发送到UI层，让UI去更新界面
            UIEventControl.DispensEvent(UIEventEnum.LoginSuccess);
            Debug.Log("登录成功 userId:" + user.id + " userName:" + user.name + " userGold:" + user.gold);
        }

        public void OnDestroy()
        {
            
        }
    }
}
