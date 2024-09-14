using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZMGC.Hall;

public class GameMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WorldManager.CreateWorld<HallWorld>();
        HallWorld.GetExitsLogicCtrl<HallLogicCtrl>().Test();
        HallWorld.GetExitsDataMgr<TaskDataMgr>().Test();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        WorldManager.DestroyWorld<HallWorld>();
    }
}
