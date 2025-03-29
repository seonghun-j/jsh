using UnityEngine;

public class PangPlayer : MonoBehaviour

{
    public enum STATE
    {
        IDLE,//가만히 서 있는 상태
        MOVE,//움직이는 상태
        HITTED,
    }

    private STATE _currentState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _currentState = STATE.IDLE;
    }
    [SerializeField]
    private Sprite[] Idelsprite;
    [SerializeField]
    private Sprite[] Walksprite;
    private void IDLE_Action()
    { 
    
    }
    private void Move_Action()
    { 
    
    }
    private float _speed = 3;
    // Update is called once per frame
    void Update()
    {
        switch (_currentState)
        { 
            case STATE.IDLE:
                IDLE_Action(); 
                break;
            case STATE.MOVE:
                Move_Action();
                break;
            case STATE.HITTED:
                break;
        }
        if (Input.GetMouseButtonDown(0))
        { 
            _currentState = STATE.MOVE;
        }
        if (Input.GetMouseButtonDown(1))
        {
            _currentState = STATE.MOVE;
        }


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("right");
            transform.position += Vector3.left * Time.deltaTime * _speed;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("left");
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }
    }
}
