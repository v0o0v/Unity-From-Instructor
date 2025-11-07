using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    void Start()
    {
        // this.GetComponent<MeshRenderer>().material.color = Color.green; // 본인의 Material 변경
        
        // Material 에셋 자체를 변경하는 기능 -> 똑같은 Material을 사용하는 모든 오브젝트 변경
        // this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;

        GetComponent<MeshRenderer>().material.color = new Color(1, 173f / 255f, 173f / 255f);
    }
}