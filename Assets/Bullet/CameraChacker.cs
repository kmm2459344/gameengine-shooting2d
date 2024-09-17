using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChacker : MonoBehaviour
{
    enum Mode
    {
        None,
        Render,
        RenderOut,
    }

    private Mode _mode;

    // Start is called before the first frame update
    void Start()
    {
        _mode = Mode.None;
    }

    // Update is called once per frame
    void Update()
    {
        _Dead();
    }

    //�I�u�W�F�N�g���J�����ɉf���Ă����
    private void OnWillRenderObject()
    {
        if(Camera.current.name == "Main Camera")
        {
            _mode = Mode.Render;
        }
    }

    private void _Dead()
    {
        if(_mode == Mode.RenderOut)
        {
            Destroy(gameObject);
        }
        else if (_mode == Mode.Render)
        {
            _mode = Mode.RenderOut;
        }
    }


}
