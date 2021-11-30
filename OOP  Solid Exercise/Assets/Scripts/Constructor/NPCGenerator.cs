using UnityEngine;

public class NPCGenerator : MonoBehaviour
{

    private void Start()
    {
        NPC npc = new NPC();
        Debug.Log(npc.characterName);

        Debug.Log("*************************");
        
        NPC npc2 = new NPC("Burak");
        Debug.Log(npc2.characterName);
    }
}
