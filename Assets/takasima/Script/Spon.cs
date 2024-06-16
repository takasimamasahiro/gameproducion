using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spon : MonoBehaviour
{
    [SerializeField] GameObject SponEnemy;
    public int _nums;
    public  Vector3 _position;
    public int _interval = 2;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < _nums; i++)
        {
           _position = new Vector3( _position.x - _interval, _position.y, _position.z );
            Instantiate(SponEnemy, _position , Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //for(int i = 0; i < _m; i++)
        //{
        //    Instantiate(SponEnemy);
        //}
        
    }
}
