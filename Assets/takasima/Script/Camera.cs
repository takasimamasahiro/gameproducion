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

        //Player‚Ìî•ñ‚ğæ“¾
        _player = GameObject.Find("Player");

        // MainCamera(©•ª©g)‚Æplayer‚Æ‚Ì‘Š‘Î‹——£‚ğ‹‚ß‚é
         _offset = transform.position - _player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = _player.transform.position + _offset;

    }
}