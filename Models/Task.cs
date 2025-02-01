namespace TaskManagementSystem.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Task {

    private Guid _task_id;
    private string? _task_title;
    private string? _task_description;
    private DateTime _task_creation;
    private DateTime _task_required;
    private ICollection<User> _task_assignees;
    private ICollection<Comment> _task_comments;

    public Task() {
        _task_assignees = new List<User>();
        _task_comments = new List<Comment>();
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Task_Id {
        get => _task_id;
        set => _task_id = value;
    }

    public string? Task_Title {
        get => _task_title;
        set => _task_title = value;
    }
    
    public string? Task_Description {
        get => _task_description;
        set => _task_description = value;
    }

    public DateTime Task_Creation {
        get => _task_creation;
        set => _task_creation = value;
    }

    public DateTime Task_Required {
        get => _task_required;
        set => _task_required = value;
    }

    public ICollection<User> Task_Assigness {
        get => _task_assignees;
        private set => _task_assignees = value;
    }

    public ICollection<Comment> Task_Comments {
        get => _task_comments;
        private set => _task_comments = value;
    }
}
