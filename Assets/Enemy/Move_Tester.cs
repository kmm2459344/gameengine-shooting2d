using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

[CreateAssetMenu(fileName = "Move_Tester", menuName = "Scriptable Objects/Move_Tester")]
public class Move_Tester : MonoBehaviour
{
    Vector2 Pos = Vector2.zero;

    private void Start()
    {
        Pos = transform.position;
    }

    private void Update()
    {
        Pos.x += 1;
    }
}
