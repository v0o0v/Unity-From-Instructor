using System.Collections.Generic;
using UnityEngine;

public class StudyStructure : MonoBehaviour
{
    [Header("멤버변수")]
    
    [Space(30)]
    
    [Header("특별한 기능")]
    
    [SerializeField]
    private int level = 1;
    
    void Start()
    {
        LevelUp();
    }

    public void LevelUp()
    {
        // 현재 레벨에서 + 1을 하는 기능
        level = level + 2;

        level += 1;

        level++;
        
        
        
        
        
        level -= 1;

        level--;
        
        
        
        level *= 2;
        

    }
}