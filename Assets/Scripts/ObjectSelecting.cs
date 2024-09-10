using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ObjectSelecting : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [HideInInspector] public Dictionary<GameObject, Vector3> collidedObjects = new Dictionary<GameObject, Vector3>();
    public static GameObject selectedObject;

    //public List<string> canSelectedObjectTag = new List<string>();
    public enum CursorState
    {
        OBJ, NONE, DISABLE
    }

    private void Update()
    {
        CursorMovement();
        CheckingStateChange();
        CheckRangeBetweenObject();
        PickingItem();
        StateActions();
    }

    private void CursorMovement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + new Vector3(moveX, moveY).normalized * Time.deltaTime * moveSpeed;
    }

    public string tagcheck;

    #region Working With GameStates
    void ChangingTargetWithGameState()
    {
        switch (GameStates.currentGameState)
        {
            case GameStates.GameStateList.BUILDING:
                tagcheck = "Buildings";
                break;
            case GameStates.GameStateList.AGENTSETUP:
                tagcheck = "Agents";
                break;
            case GameStates.GameStateList.MOVING:
                tagcheck = null;
                break;
            default:
                break;
        }
    }

    GameStates.GameStateList pastState;
    void CheckingStateChange()
    {
        if (GameStates.currentGameState != pastState)
        {
            //trigger command
            collidedObjects.Clear();
            pastState = GameStates.currentGameState;
            ChangingTargetWithGameState();
        }
    }

    #endregion


    #region Finding Object to tag
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (tagcheck != null)
        {
            if (other.gameObject.tag == tagcheck)
            {
                Debug.Log("Tagggg mitch!");
                collidedObjects.Add(other.gameObject, other.transform.position);
            }
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        collidedObjects.Remove(other.gameObject);
    }

    public void CheckRangeBetweenObject()
    {
        Dictionary<GameObject, float> checkrangebetween = new Dictionary<GameObject, float>();

        if (collidedObjects.Count >= 0)
        {
            selectedObject = null;
        }

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

        }
    }


    private void OnDrawGizmos()
    {
        if (collidedObjects != null && selectedObject != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, selectedObject.transform.position);
        }
    }
    #endregion

    public enum ObjectState
    {
        SELECTED,FOLLOWING
    }

    public ObjectState OBJState;
    
    private void PickingItem()
    {
        if (selectedObject != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Press Space!");
                if (OBJState == ObjectState.SELECTED)
                {
                    OBJState = ObjectState.FOLLOWING;
                }
                if (OBJState == ObjectState.FOLLOWING)
                {
                    OBJState = ObjectState.SELECTED;
                }
            }
            

        }
    }


    private void StateActions()
    {
        if (OBJState == ObjectState.FOLLOWING)
        {
            selectedObject.transform.position = gameObject.transform.position;
        }
    }

}