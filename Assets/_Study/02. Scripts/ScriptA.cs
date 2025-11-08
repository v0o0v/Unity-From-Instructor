using UnityEngine;

public class ScriptA : MonoBehaviour
{
    int number1 = 1; // private 멤버변수
    
    private int number2 = 2; // private 멤버변수
    
    public int number3 = 3; // public 멤버변수
    
    [SerializeField] private int number4 = 4; // private 멤버변수
    
    protected int number5 = 5; // protected 멤버변수

    void Start()
    {
        int number6 = 6; // 지역변수
    }
}