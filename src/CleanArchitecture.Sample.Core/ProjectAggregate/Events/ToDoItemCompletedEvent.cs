﻿using CleanArchitecture.Sample.SharedKernel;

namespace CleanArchitecture.Sample.Core.ProjectAggregate.Events;
public class ToDoItemCompletedEvent : DomainEventBase
{
  public ToDoItem CompletedItem { get; set; }

  public ToDoItemCompletedEvent(ToDoItem completedItem)
  {
    CompletedItem = completedItem;
  }
}
