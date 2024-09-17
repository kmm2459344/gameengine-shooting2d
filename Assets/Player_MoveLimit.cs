using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MoveLimit : MonoBehaviour
{
    // x軸方向の移動範囲の最小値
    [SerializeField] private float _minX = -2.304f;

    // x軸方向の移動範囲の最大値
    [SerializeField] private float _maxX = 2.304f;

    // y軸方向の移動範囲の最小値
    [SerializeField] private float _minY = -4.494f;

    // y軸方向の移動範囲の最大値
    [SerializeField] private float _maxY = 4.494f;

    private void Update()
    {
        var pos = transform.position;

        // x軸方向の移動範囲制限
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);
        // y軸方向の移動範囲制限
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);

        transform.position = pos;
    }
}
