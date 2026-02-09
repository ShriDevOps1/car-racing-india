using UnityEngine;

public class CarController : MonoBehaviour
{
    [Header("Car Properties")]
    public float maxSpeed = 100f;
    public float acceleration = 10f;
    public float brakingPower = 15f;
    public float steeringSpeed = 3f;
    public float maxSteerAngle = 30f;
    
    [Header("Fuel System")]
    public float currentFuel = 100f;
    public float maxFuel = 100f;
    public float fuelConsumptionRate = 0.1f;
    
    [Header("Physics")]
    public Rigidbody rb;
    public float dragCoefficient = 0.3f;
    
    private float currentSpeed = 0f;
    private float steerAngle = 0f;
    private bool isEngineRunning = false;
    
    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody>();
        isEngineRunning = true;
    }
    
    void Update()
    {
        HandleInput();
        ConsumeFuel();
        UpdateSpeed();
    }
    
    void HandleInput()
    {
        // Accelerate
        if (Input.GetKey(KeyCode.W))
        {
            if (currentFuel > 0)
                currentSpeed = Mathf.Min(currentSpeed + acceleration * Time.deltaTime, maxSpeed);
        }
        // Brake
        else if (Input.GetKey(KeyCode.S))
        {
            currentSpeed = Mathf.Max(currentSpeed - brakingPower * Time.deltaTime, 0f);
        }
        else
        {
            // Natural deceleration
            currentSpeed = Mathf.Max(currentSpeed - dragCoefficient * Time.deltaTime, 0f);
        }
        
        // Steering
        steerAngle = Input.GetAxis("Horizontal") * maxSteerAngle;
        transform.Rotate(0, steerAngle * steeringSpeed * Time.deltaTime, 0);
    }
    
    void UpdateSpeed()
    {
        Vector3 movement = transform.forward * currentSpeed * Time.deltaTime;
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, movement.z);
    }
    
    void ConsumeFuel()
    {
        if (currentFuel > 0 && currentSpeed > 0)
        {
            currentFuel -= fuelConsumptionRate * Time.deltaTime;
        }
    }
    
    public void RefuelCar(float amount)
    {
        currentFuel = Mathf.Min(currentFuel + amount, maxFuel);
    }
    
    public float GetCurrentSpeed()
    {
        return currentSpeed;
    }
    
    public float GetFuelPercentage()
    {
        return (currentFuel / maxFuel) * 100f;
    }
}