using UnityEngine;

namespace ZMGC.Hall
{
    public class TaskMsgMgr : IMsgBehaviour
    {

        public void OnCreate()
        {
            Debug.Log("TaskMsgMgr OnCreate>>>");
        }
        public void OnDestroy()
        {
            Debug.Log("TaskMsgMgr OnDestroy>>>");
        }
    }
}
