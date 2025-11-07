using UnityEngine;

public class StudyCreateObject : MonoBehaviour
{
    public GameObject characterPrefab;

    void Awake()
    {
        GameObject newObj = Instantiate(characterPrefab);
        
        newObj.transform.position = transform.position; // 위치 설정
        newObj.transform.rotation = Quaternion.identity; // 회전 설정
        
        newObj.transform.SetPositionAndRotation(transform.position, Quaternion.identity); // 둘 다 설정
    }
}