using UnityEngine;

public class NPC
{
    public string npcName;
    public int npcAge;

    public NPC()
    {
        
    }
}

public class NPCManager : MonoBehaviour
{
    void Start() // 유니티 에디터를 실행했을 때 1번 실행되는 함수
    {
        NPC npc1 = new NPC();
        npc1.npcName = "상인";
        npc1.npcAge = 50;
        Debug.Log(npc1.npcName);
        Debug.Log(npc1.npcAge);
        
        Debug.Log("----------------");
        
        NPC npc2 = new NPC();
        npc2.npcName = "경비병";
        npc2.npcAge = 30;
        Debug.Log(npc2.npcName);
        Debug.Log(npc2.npcAge);
    }
}