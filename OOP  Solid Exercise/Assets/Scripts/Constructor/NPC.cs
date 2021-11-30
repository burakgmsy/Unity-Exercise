using UnityEngine;
public class NPC
{
    public string characterName;
    public NPC()
    {
        //CONSTRUCTOR
        Debug.Log("INSIDE EMPTY CONSTRUCTOR");

    }
    public NPC(string _characterName)
    {
        //CONSTRUCTOR
        this.characterName = _characterName;
        Debug.Log("INSIDE NAME INIT  CONSTRUCTOR");
    }
}
