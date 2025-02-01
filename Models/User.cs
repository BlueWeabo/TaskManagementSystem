namespace TaskManagementSystem.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User {

    private Guid _user_id;
    private string? _user_name;
    private string? _user_position;
    private ICollection<Task> _user_tasks;

    public User() {
        _user_tasks = new List<Task>();
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid User_Id {
        get => _user_id;
        set => _user_id = value;
    }

    public string? User_Name {
        get => _user_name;
        set => _user_position = value;
    }

    public string? User_Position {
        get => _user_position;
        set => _user_position = value;
    }

    public ICollection<Task> User_Tasks {
        get => _user_tasks;
        private set => _user_tasks = value;
    }
}
