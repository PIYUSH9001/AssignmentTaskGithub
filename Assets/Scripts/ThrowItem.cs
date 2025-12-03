using UnityEngine;

public class ThrowItem : MonoBehaviour
{   
    public static GameObject HoldingItem;
    Rigidbody rb;
    [SerializeField] Transform PlayerArmature;
    private float forceConstant = 100f;
    public void HandleItemThrow()
    {
        if(PlayerItemDetection.isHoldingItem)
        {
            rb = HoldingItem.GetComponent<Rigidbody>();
            HoldingItem.transform.parent = null;
            rb.useGravity = true;
            rb.isKinematic = false;
            rb.AddForce(PlayerArmature.transform.forward * forceConstant * ThrowBtn.forceStrength);
            rb.AddForce((PlayerArmature.transform.forward * forceConstant * ThrowBtn.forceStrength)/2);
            PlayerItemDetection.isHoldingItem = false;
        }
    }

    // For testing purpose

    //private void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.F))
    //    {
    //        HandleItemThrow();
    //    }
    //}
}
