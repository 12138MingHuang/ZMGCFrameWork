using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZMGC.Hall;

public class HallWorldScriptExecutionOrder : IBehaviourExecution
{
    private static Type[] _logicBehaviourExecution = new Type[]
    {
        // typeof(TaskLogicCtrl),
    };
    
    private static Type[] _dataBehaviourExecution = new Type[]
    {
        typeof(UserDataMgr),
    };
    
    private static Type[] _msgBehaviourExecution = new Type[]
    {
        // typeof(TaskMsgMgr),
    };

    public Type[] GetLogicBehaviourExecution()
    {
        return _logicBehaviourExecution;
    }
    public Type[] GetDataBehaviourExecution()
    {
        return _dataBehaviourExecution;
    }
    public Type[] GetMsgBehaviourExecution()
    {
        return _msgBehaviourExecution;
    }
}
