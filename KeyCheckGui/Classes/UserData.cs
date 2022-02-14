using System.Collections.Generic;

namespace KeyCheckGui
{
    public class UserData
    {
        public User user { get; set; }
        public School school { get; set; }
    }

    public class User
    {
        public string username { get; set; }
        public bool enabled { get; set; }
        public string registred { get; set; }
        public bool verified { get; set; }
        public bool isBounced { get; set; }
        public UserHardware[] hardwares { get; set; }
        public Purchase[] purchases { get; set; }
        public bool bounced { get; set; }
    }

    public class School
    {
        public string username { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string association { get; set; }
        public string description { get; set; }
        public bool master { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string region { get; set; }
        public string contact { get; set; }
        public string position { get; set; }
        public int devices { get; set; }
        public int additionalComputers { get; set; }
        public string[] licenses { get; set; }
        public string[] trials { get; set; }
        public Dictionary<string, object> expire { get; set; }
        public bool bounced { get; set; }
        public Teacher[] teachers { get; set; }
    }

    public class UserHardware
    {
        public string save { get; set; }
        public string settings { get; set; }
        public string id { get; set; }
        public string deviceModel { get; set; }
        public string deviceName { get; set; }
        public string deviceType { get; set; }
        public string operatingSystem { get; set; }
        public string processorType { get; set; }
        public string systemMemorySize { get; set; }
        public string graphicsDeviceID { get; set; }
        public string graphicsDeviceName { get; set; }
        public string graphicsDeviceVersion { get; set; }
        public string graphicsMemorySize { get; set; }
        public int emailBounceAttempts { get; set; }
        public string product { get; set; }
        public bool authorized { get; set; }
        public string duplicatedId { get; set; }
        public string token { get; set; }
        public string refreshToken { get; set; }
        public string previousToken { get; set; }
        public int deviceId { get; set; }

        public string[] ToArray()
        {
            return new string[] { deviceId.ToString(), product, id, deviceName };
        }
    }

    public class Purchase
    {
        public int id { get; set; }
        public string username { get; set; }
        public string dlc { get; set; }
        public string date { get; set; }
        public float price { get; set; }
        public string save { get; set; }
        public string seller { get; set; }
        public bool canceled { get; set; }
        public string canceler { get; set; }
        public string canceldate { get; set; }
    }

    public class Hardware
    {
        public Hardware(UserHardware hardware)
        {
            id = hardware.id;
            deviceModel = hardware.deviceModel;
            deviceName = hardware.deviceName;
            deviceType = hardware.deviceType;
            operatingSystem = hardware.operatingSystem;
            processorCount = hardware.processorType;
            processorFrequency = "";
            processorType = hardware.processorType;
            systemMemorySize = hardware.systemMemorySize;
            graphicsDeviceID = hardware.graphicsDeviceID;
            graphicsDeviceName = hardware.graphicsDeviceName;
            graphicsDeviceType = "";
            graphicsDeviceVendor = "";
            graphicsDeviceVendorID = "";
            graphicsDeviceVersion = "";
            graphicsMemorySize = hardware.graphicsMemorySize;
            graphicsMultiThreaded = "";
            graphicsShaderLevel = "";
            maxTextureSize = "";
            npotSupport = "";
        }

        public string id { get; set; }
        public string deviceModel { get; set; }
        public string deviceName { get; set; }
        public string deviceType { get; set; }
        public string operatingSystem { get; set; }
        public string processorCount { get; set; }
        public string processorFrequency { get; set; }
        public string processorType { get; set; }
        public string systemMemorySize { get; set; }
        public string graphicsDeviceID { get; set; }
        public string graphicsDeviceName { get; set; }
        public string graphicsDeviceType { get; set; }
        public string graphicsDeviceVendor { get; set; }
        public string graphicsDeviceVendorID { get; set; }
        public string graphicsDeviceVersion { get; set; }
        public string graphicsMemorySize { get; set; }
        public string graphicsMultiThreaded { get; set; }
        public string graphicsShaderLevel { get; set; }
        public string maxTextureSize { get; set; }
        public string npotSupport { get; set; }
    }

    public class Teacher
    {
        public string name { get; set; }
        public string teacher { get; set; }
    }
}