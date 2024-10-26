
using UnityEngine;


[CreateAssetMenu(fileName = "PassiveItemScriptableObject", menuName = "ScriptableObject/PassiveItem")]
public class PassiveItemScriptableObject : ScriptableObject
{
    [SerializeField] float multipler;

    public float Multipler { get => multipler; private set => multipler = value; }
}
