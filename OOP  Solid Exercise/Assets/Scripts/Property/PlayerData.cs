using UnityEngine;

public class PlayerData : MonoBehaviour
{
    //read only name 
    private string playerFirstName = "Burak";
    private string playerLastName = "Gumusay";
    private int health;
    private int maxHealth = 100;

    public string playerName
    {
        get
        {
            return playerFirstName + " " + playerLastName;
        }
    }

    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            if (value > maxHealth)
                health = maxHealth;

            else
                health = value;
        }
    }
}
