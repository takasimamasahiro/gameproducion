using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSample : MonoBehaviour
{

   [SerializeField] GameObject _player;
    Vector3 _offset;

    // Use this for initialization
    void Start()
    {
        // MainCamera(自分自身)とplayerとの相対距離を求める
         _offset = transform.position - _player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = _player.transform.position + _offset;

    }
}