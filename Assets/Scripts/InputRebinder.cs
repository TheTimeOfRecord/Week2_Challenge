using UnityEngine;
using UnityEngine.InputSystem;

public class InputRebinder : MonoBehaviour
{
    public InputActionAsset actionAsset;
    private InputAction spaceAction;

    private void OnEnable()
    {
        Debug.Log("InputRebinder Enable");
        spaceAction = actionAsset.FindAction("Space");
        spaceAction?.Enable();
    }

    [ContextMenu("Rebind Space To Escape")]
    public void RebindSpaceToEscape()
    {
        int bindingIndex = spaceAction.bindings.IndexOf(x => x.path == "<Keyboard>/space");

        if (bindingIndex != -1)
        {
            spaceAction.ChangeBinding(bindingIndex).WithPath("<Keyboard>/escape");
            Debug.Log("Rebinding Complete: Space to Escape");
        }
        else
        {
            Debug.Log("Rebinding Failed: Space to Escape");
        }
    }

    private void OnDisable()
    {
        Debug.Log("InputRebinder Disable");
        spaceAction?.Disable();
    }
}