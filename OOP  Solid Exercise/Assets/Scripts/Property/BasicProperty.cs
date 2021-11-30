using UnityEngine;

public class BasicProperty : MonoBehaviour
{
    private int score;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }
}
