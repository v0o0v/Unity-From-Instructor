using UnityEngine;

public class ScriptB : MonoBehaviour
{
    public int number = 1;
    
    void Start()
    {
        // number++; // number에 1 더하기
        // number += 3; // number에 3 더하기
        
        // Shift 연산
        number = number << 2;

        Debug.Log(number);
    }
}