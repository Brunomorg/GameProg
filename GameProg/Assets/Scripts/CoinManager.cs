using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private int Score = 0;
    [SerializeField]private int Value = 5;

    public void OnCoinCollect()
    {
        Score = Score + Value;
        Debug.Log(Score);
    }


}
