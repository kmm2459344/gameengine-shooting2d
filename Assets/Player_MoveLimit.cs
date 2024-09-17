using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MoveLimit : MonoBehaviour
{
    // x�������̈ړ��͈͂̍ŏ��l
    [SerializeField] private float _minX = -2.304f;

    // x�������̈ړ��͈͂̍ő�l
    [SerializeField] private float _maxX = 2.304f;

    // y�������̈ړ��͈͂̍ŏ��l
    [SerializeField] private float _minY = -4.494f;

    // y�������̈ړ��͈͂̍ő�l
    [SerializeField] private float _maxY = 4.494f;

    private void Update()
    {
        var pos = transform.position;

        // x�������̈ړ��͈͐���
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);
        // y�������̈ړ��͈͐���
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);

        transform.position = pos;
    }
}
