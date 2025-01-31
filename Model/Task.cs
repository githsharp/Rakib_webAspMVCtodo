﻿using System;
using System.Text.Json;

namespace classwebsite.Model
{
    public class Task
    {
public int id { get; set; }     
public string description { get; set; }
public string created_at { get; set; }
public string image { get; set; }

public bool is_complete { get; set; }

public override string ToString() => JsonSerializer.Serialize<Task>(this);
        

    }
}

