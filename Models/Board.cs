using System;

using System.ComponentModel.DataAnnotations;

using System.Text.Json.Serialization;

namespace TodoApi.Models;


    public class Board

    {

       [Key]

        public long Id { get; set; }

        public string? Name { get; set; }



       //  public ICollection<TodoItem> TodoItems { get; set; }

   

    }