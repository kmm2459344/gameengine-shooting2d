using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class Enemey_Generator : MonoBehaviour
{
    [SerializeField] List<SplineContainer> allSplines; // ���ׂẴX�v���C����ێ����郊�X�g

    private List<SplineContainer> availableSplines; // ���ݎg�p�\�ȃX�v���C���̃��X�g

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
        // �g�p�\�X�v���C�����X�g��������
        availableSplines = new List<SplineContainer>(allSplines);
        availableSplines.Sort((a, b) => Random.Range(-1, 2));
    }

}
