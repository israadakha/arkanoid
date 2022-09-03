using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;
    public int addscore(int hp)
    {
        score += hp;
        return score;
    }

}
