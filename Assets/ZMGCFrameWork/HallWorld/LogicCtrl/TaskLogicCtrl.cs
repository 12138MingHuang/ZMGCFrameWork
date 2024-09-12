using UnityEngine;

namespace ZMGC.Hall
{
    public class TaskLogicCtrl : ILogicBehaviour
    {

        public void OnCreate()
        {
            Debug.Log("TaskLogicCtrl OnCreate>>>");
        }
        public void OnDestroy()
        {
            Debug.Log("TaskLogicCtrl OnDestroy>>>");
        }
    }
}
