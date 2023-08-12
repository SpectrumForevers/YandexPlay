
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField] float strength = 5f;
    [SerializeField] float speed = 5f;
    [SerializeField] GameObject cameraMain;
    
    private Rigidbody player;
    private void Start()
    {
        player = gameObject.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        cameraMain.transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.Space))
        {
            player.AddForce(transform.up * strength);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Tags.death)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("DEATH");
        }
        if (other.tag == Tags.points)
        {
            GameManager.Instance.SetScore(1);
            Destroy(other.gameObject);
        }
    }
}
