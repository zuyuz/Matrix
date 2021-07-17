﻿using Matrix.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Matrix.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
