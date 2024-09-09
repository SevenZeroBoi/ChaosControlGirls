using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectSelecting : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [HideInInspector] public Dictionary<GameObject, Vector3> collidedObjects = new Dictionary<GameObject, Vector3>();
    public static GameObject selectedObject;

    //public List<string> canSelectedObjectTag = new List<string>();

    private void CursorMovement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + new Vector3(moveX, moveY).normalized * Time.deltaTime * moveSpeed;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        collidedObjects.Add(other.gameObject, other.transform.position);
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        collidedObjects.Remove(other.gameObject);
    }

    public void CheckRangeBetweenObject()
    {
        Dictionary<GameObject, float> checkrangebetween = new Dictionary<GameObject, float>();

        foreach (var obj in collidedObjects)
        {
            float distance = Vector3.Distance(transform.position, obj.Value);
            checkrangebetween.Add(obj.Key, distance);
        }

        var sortedDict = checkrangebetween
            .OrderBy(kv => kv.Value)
            .ToDictionary(kv => kv.Key, kv => kv.Value);

        selectedObject = sortedDict.Keys.FirstOrDefault();

        if (selectedObject != null)
        {
            ObjectGlowing();
        }
    }

    public void ObjectGlowing()
    {
        
    }

    public enum CursorState
    {
        OBJ, NONE, DISABLE
    }

}
