namespace TaskManagementSystem.Models;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Comment {

    private Guid _comment_id;
    private string? _comment_text;
    private CommentType _comment_type;
    private DateTime? _comment_reminder_date;
    private Task? _comment_task;

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Comment_Id {
        get => _comment_id;
        set => _comment_id = value;
    }

    public string? Comment_Text {
        get => _comment_text;
        set => _comment_text = value;
    }

    public CommentType Comment_Type {
        get => _comment_type;
        set => _comment_type = value;
    }

    public DateTime? Comment_Reminder_Date {
        get => _comment_reminder_date;
        set => _comment_reminder_date = value;
    }

    public Task? Comment_Task {
        get => _comment_task;
        set => _comment_task = value;
    }
}
