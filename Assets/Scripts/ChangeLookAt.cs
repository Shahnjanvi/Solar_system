using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    // declare a gameobject variable which defines the target where the camera should look at
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target== null)
      {
        target=this.gameObject;
        Debug.Log("Change look at target not specified. Defaulting to parent object");
      } 
    }

    private void OnMouseDown(){
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
    }
}