using System;
using System.Collections.Generic;
using UnityEditor;
using Assets.scripts._Attributes._Attributes;
namespace Assets.scripts._Attributes._Attributes.Editor
{

    public class ActionsTInspector : UnityEditor.Editor
    {
        List<List<object>> s_DropDownLists = new List<List<object>>();


        public override void OnInspectorGUI()
        {

           // target as ActionsT
            EditorGUI.BeginChangeCheck();
            base.OnInspectorGUI();



            
        }

    }

}
