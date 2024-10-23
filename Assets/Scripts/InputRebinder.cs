using UnityEngine;
using UnityEngine.InputSystem;

public class InputRebinder : MonoBehaviour
{

    public InputActionAsset actionAsset;
    private InputAction spaceAction;

    private void Awake()
    {
        spaceAction = actionAsset.FindAction("Space");
        spaceAction.Enable();
    }

    [ContextMenu("Rebind Space To Escape")]
    public void RebindSpaceToEscape()
    {

    }


    //public InputActionAsset actionAsset;
    //private InputAction spaceAction;

    //void Start()
    //{
    //    // [�������� 1] actionAsset���� Space �׼��� ã�� Ȱ��ȭ�մϴ�.

    //}

    //// [�������� 2] ContextMenu ��Ʈ����Ʈ�� Ȱ���ؼ� �ν�����â���� ������ �� �ֵ��� ��

    //public void RebindSpaceToEscape()
    //{
    //    if (spaceAction == null)
    //        return;

    //    // [�������� 3] ���� ���ε��� ��Ȱ��ȭ�ϰ� �� Ű�� ����ε�


    //    Debug.Log("Done!");
    //}

    //void OnDestroy()
    //{
    //    // �׼��� ��Ȱ��ȭ�մϴ�.
    //    spaceAction?.Disable();
    //}
}