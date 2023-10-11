using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    [Required(ErrorMessage = "The item's description cannot be empty!")]
    public string Description { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your item to a category, create a category first!")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<ItemTag> JoinEntities { get; }
    public bool IsCompleted { get; set; }
    [DataType(DataType.Date)]
    // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
    //  ApplyFormatInEditMode = true)]
    public DateTime DueDate { get; set; }
  }
}