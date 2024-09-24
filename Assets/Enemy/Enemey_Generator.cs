using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class Enemey_Generator : MonoBehaviour
{
    [SerializeField] List<SplineContainer> allSplines; // すべてのスプラインを保持するリスト

    private List<SplineContainer> availableSplines; // 現在使用可能なスプラインのリスト

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeSplineList()
    {
        // 使用可能スプラインリストを初期化
        availableSplines = new List<SplineContainer>(allSplines);
        availableSplines.Sort((a, b) => Random.Range(-1, 2));
    }

}
