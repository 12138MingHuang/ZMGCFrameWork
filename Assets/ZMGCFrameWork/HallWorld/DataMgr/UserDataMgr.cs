using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZMGC.Hall
{
    /// <summary>
    /// 测试服务端数据结构体
    /// </summary>
    public class UserDataServerModelTest
    {
        public long id;
        public string name;
        public long gold;
    }
    
    public class UserDataMgr : IDataBehaviour
    {
        public long id;
        public string name;
        public long gold;
        
        public void OnCreate()
        {
            Debug.Log("UserDataMgr OnCreate>>>");
        }
        
        public void CacheUserData(UserDataServerModelTest data)
        {
            id = data.id;
            name = data.name;
            gold = data.gold;
        }
        
        public void OnDestroy()
        {
            Debug.Log("UserDataMgr OnDestroy>>>");
        }
    }
}

