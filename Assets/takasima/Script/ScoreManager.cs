using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static ScoreManager instance   = new ScoreManager();
    public static ScoreManager Instance => instance;
    private ScoreManager() { }

   public int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
    }

    // Update is called once per frame
    public void AddScore(int Point)
    {
        _score += Point;
    }
    public int GetScore()
    {
        return _score;
    }
}
