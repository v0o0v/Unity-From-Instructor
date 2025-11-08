using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position -= Vector3.right * moveSpeed * Time.deltaTime;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftShift)) // 가속
        {
            moveSpeed = 5f; // 쉬프트 키를 누르면 속도 5로 변경
        }
        
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = 3f; // 쉬프트 키를 떼면 원래 속도로 변경
        }
    }
}