using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.scripts._Attributes._Attributes
{

    enum command
    {
        WAIT,
        MOVE,

    }

    [System.Serializable]
    class ActionsT
    {
        [SerializeField]
        private command _MyCommand;

        [SerializeField]
        List<command> _AllMyCommands;
    }
}
