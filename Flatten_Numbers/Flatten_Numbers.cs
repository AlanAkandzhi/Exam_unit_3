﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Task2
{
    static void Main(string[] args)
    {
        string jsonFilePath = "arrays.json";
        string jsonString = File.ReadAllText(jsonFilePath);
        JsonElement jsonElement = JsonDocument.Parse(jsonString).RootElement;

        List<int> flattenedArray = FlattenArray(jsonElement);
        Console.WriteLine($"[{string.Join(", ", flattenedArray)}]");
    }

    static List<int> FlattenArray(JsonElement element)
    {
        List<int> result = new List<int>();

        if (element.ValueKind == JsonValueKind.Array)
        {
            foreach (var item in element.EnumerateArray())
            {
                result.AddRange(FlattenArray(item));
            }
        }
        else if (element.ValueKind == JsonValueKind.Number)
        {
            result.Add(element.GetInt32());
        }

        return result;
    }
}
