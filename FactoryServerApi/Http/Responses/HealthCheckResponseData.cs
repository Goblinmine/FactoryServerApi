﻿using System.Text.Json.Serialization;

namespace FactoryServerApi.Http.Responses;

public class HealthCheckResponseData
{
    public HealthState Health { get; }
    public string? ServerCustomData { get; }

    [JsonConstructor]
    internal HealthCheckResponseData(HealthState health, string? serverCustomData)
    {
        Health = health;
        ServerCustomData = serverCustomData;
    }


}
