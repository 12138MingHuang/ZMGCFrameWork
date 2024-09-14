using UnityEngine;

namespace ZMGC.Hall
{
    public class TaskDataMgr : IDataBehaviour
    {

        public void OnCreate()
        {
            Debug.Log("TaskDataMgr OnCreate>>>");
        }
        public void OnDestroy()
        {
            Debug.Log("TaskDataMgr OnDestroy>>>");
        }
        public void Test()
        {
            Debug.Log("TaskDataMgr Test>>>");
        }
    }
}
