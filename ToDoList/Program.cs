using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace Program
{
  public class ToDo
  {
    public static void Main()
    {
      AddItem();
      
    }
    public static void AddItem()
    {
      Console.WriteLine("welcome! press v to view list, press a to add item to list.");
      string answer = Console.ReadLine();
      if (answer == "a")
      {
        Console.WriteLine("enter a task to add to your to do list");
        string response = Console.ReadLine(); 
        Item toDo = new Item(response);
        Console.WriteLine(response + " has been added to your to do list");
        WhatNext();
      }
      else if (answer == "v")
      {
      Console.WriteLine(Item.GetAll());
      Main();
      }
    }
    public static void WhatNext()
    {
      Console.WriteLine("Add another item? [a] Or view list? [v]");
      string whatNextResponse = Console.ReadLine();
      if (whatNextResponse == "v")
      {
        List<Item> finalList = Item.GetAll();
        foreach (Item item in finalList)
        {
          Console.WriteLine(item.Description);
        }
        AddItem();
      }
      else if (whatNextResponse == "a")
      {
        AddItem();
      }
    }
  }
}
