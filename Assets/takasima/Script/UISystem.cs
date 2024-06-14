using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISystem : MonoBehaviour
{
    [SerializeField] Text _ScoreText = default;
    int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        _ScoreText.text = ScoreManager.Instance.GetScore().ToString();
        
    }
}
