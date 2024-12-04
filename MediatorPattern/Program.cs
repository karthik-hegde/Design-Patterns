using MediatorPattern;

Console.WriteLine("=== Smart Home Control System ===");

// Create the mediator (HomeHub)
var homeHub = new HomeHub();

// Create devices
var light = new SmartLight("Living Room Light");
var thermostat = new Thermostat("Main Thermostat");
var securitySystem = new SecuritySystem("Home Security");
var smartDoor = new SmartDoor("Front Door");

// Register devices with the mediator
homeHub.RegisterDevice(light);
homeHub.RegisterDevice(thermostat);
homeHub.RegisterDevice(securitySystem);
homeHub.RegisterDevice(smartDoor);

// Test scenarios
Console.WriteLine("\n--- Scenario: Door opens at night ---");
smartDoor.Open(); // Should turn on the light at night

smartDoor.Close();

smartDoor.Open(); // Should turn on the light at night
Console.WriteLine("Waiting for the auto close...");
Console.ReadLine();