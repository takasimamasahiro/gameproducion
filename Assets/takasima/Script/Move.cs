using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
     Rigidbody _rigidBody;
    [SerializeField] float _MoveSpeed = 1f;
    bool isStop = false;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {   //TODO
        //ˆÚ“®‚¹‚æ
        //https://candle-stoplight-544.notion.site/4e021f226d584730b715626436ccc330
        if (!isStop)
        {
            _rigidBody.AddForce (new Vector3 ((_MoveSpeed * -1), 0, 0));
        }
        else if (isStop) 
        {
            _rigidBody.velocity = Vector3.zero;
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Start")) isStop = false;
        else if(other.gameObject.tag.Equals("Goal")) isStop = true;
    }
}
