using System;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public StudyStructure structure;

    public string str;
    
    void Start()
    {
        // structure.level = 100;
        
        structure.LevelUp();

        str = "안녕하세요.";

        Debug.Log(str);
        
        // str = "";
        str = String.Empty;
    }
}