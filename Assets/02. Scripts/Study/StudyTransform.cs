using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) // 만약 W키가 눌렸다면
        {
            this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime; // 앞으로 이동
        } 
        
        if (Input.GetKey(KeyCode.S)) // 만약 S키가 눌렸다면
        {
            this.transform.position += Vector3.back * moveSpeed * Time.deltaTime; // 뒤로 이동
        } 
        
        if (Input.GetKey(KeyCode.A)) // 만약 A키가 눌렸다면
        {
            this.transform.position += Vector3.left * moveSpeed * Time.deltaTime; // 왼쪽으로 이동
        } 
        
        if (Input.GetKey(KeyCode.D)) // 만약 D키가 눌렸다면
        {
            this.transform.position += Vector3.right * moveSpeed * Time.deltaTime; // 오른쪽으로 이동
        }
    }
}