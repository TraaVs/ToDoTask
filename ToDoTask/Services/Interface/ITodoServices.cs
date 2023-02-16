﻿namespace AspBackend.Services.Interface;

public interface ITodoServices
{
    public Task<Todo> CreateTodoAsync(Todo model);

    public Task<Todo> UpdateTodoAsync(Todo model);

    public Task<Todo> DeleteTodoAsync(int id);

    public Task<UserTodo> AddUserAsync(UserTodo model);

    public Task<UserTodo> DeleteUserAsync(UserTodo model);
}
