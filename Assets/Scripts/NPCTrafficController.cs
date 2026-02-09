using UnityEngine;
using System.Collections;

public class NPCTrafficController : MonoBehaviour
{
    public GameObject npcVehiclePrefab;
    public float spawnInterval = 2.0f;
    public float speed = 10.0f;
    private float timer;

    void Start()
    {
        timer = spawnInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnNPCVehicle();
            timer = spawnInterval;
        }
    }

    void SpawnNPCVehicle()
    {
        GameObject npcVehicle = Instantiate(npcVehiclePrefab, GetRandomSpawnPosition(), Quaternion.identity);
        npcVehicle.GetComponent<NPCVehicle>().SetSpeed(speed);
    }

    Vector3 GetRandomSpawnPosition()
    {
        float x = Random.Range(-10f, 10f);
        // Assuming the road is between y = -5 and y = 5
        float y = 0f;
        float z = Random.Range(-10f, 10f);
        return new Vector3(x, y, z);
    }
}

public class NPCVehicle : MonoBehaviour
{
    private float speed;

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}