using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private Vector2 velocityLimitMinMax;

    public GameObject FinishScreen;
    private void FixedUpdate()
    {
        var vertical = myRigidBody.velocity;
        vertical.y = Mathf.Clamp(vertical.y, velocityLimitMinMax.y, velocityLimitMinMax.x); // y eksenindeki hizini kontrol etmek icin.
        myRigidBody.velocity = vertical; 
    }

    public void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
    

}
