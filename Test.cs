using FastEndpoints;
using FluentValidation.Results;

namespace TestProj;

/* 
 Examples below show usage of proposed snippets for VS Code.
 */

// fe_req
public sealed class GetTodosEndpoint : Endpoint<GetTodosRequest>
{
  public override void Configure()
  {
    Get("todos");
  }

  public override async Task HandleAsync(GetTodosRequest req, CancellationToken ct)
  {

  }
}

// fe_reqres
public sealed class GetTodosEndpoint : Endpoint<GetTodosRequest, GetTodosResponse>
{
  public override void Configure()
  {
    Get("todos2");
  }

  public override async Task<GetTodosResponse> HandleAsync(GetTodosRequest req, CancellationToken ct)
  {

  }
}

// fe_noreq
public sealed class GetTodosEndpoint : EndpointWithoutRequest
{
  public override void Configure()
  {
    Get("todos3");
  }

  public override async Task HandleAsync(CancellationToken ct)
  {

  }
}

// fe_res
public sealed class GetTodosEndpoint : EndpointWithoutRequest<GetTodosResponse>
{
  public override void Configure()
  {
    Get("todos4");
  }

  public override async Task<GetTodosResponse> HandleAsync(CancellationToken ct)
  {

  }
}

// fe_dtos
public class GetTodosRequest { }
public class GetTodosResponse { }

// fe_val
public class GetTodosValidator : Validator<GetTodosRequest>
{
  public GetTodosValidator()
  {

  }
}

// fe_map
public sealed class GetTodosMapper : Mapper<GetTodosRequest, GetTodosResponse, Todo>
{
  public override Todo ToEntity(GetTodosRequest req)
  {

  }

  public override GetTodosResponse FromEntity(Todo entity)
  {

  }
}

// fe_sum
public sealed class GetTodosSummary : Summary<GetTodosEndpoint, GetTodosRequest>
{
  public GetTodosSummary()
  {

  }
}

// fe_full
public sealed class GetTodosEndpoint : Endpoint<GetTodosRequest, GetTodosResponse, GetTodosMapper>
{
  public override void Configure()
  {
    Get("todos");
  }

  public override async Task<GetTodosResponse> HandleAsync(GetTodosRequest req, CancellationToken ct)
  {

  }
}

public class GetTodosRequest { }

public class GetTodosResponse { }

public class GetTodosValidator : Validator<GetTodosRequest>
{
  public GetTodosValidator()
  {

  }
}

public class GetTodosMapper : Mapper<GetTodosRequest, GetTodosResponse, Todo>
{
  public override Todo ToEntity(GetTodosRequest req)
  {

  }

  public override GetTodosResponse FromEntity(Todo entity)
  {

  }
}

// fe_eh
public sealed class TodoCreatedEventHandler : IEventHandler<TodoCreatedEvent>
{
  public async Task HandleAsync(TodoCreatedEvent @event, CancellationToken ct)
  {

  }
}

// fe_cmd_nores
public sealed class PrintTodoCommand : ICommand
{

}

// fe_cmd_res
public sealed class GetTodoCommand : ICommand<Todo>
{

}

// fe_cmd_handler_res
public sealed class GetTodoCommandHandler : ICommandHandler<GetTodoCommand, Todo>
{
  public async Task<Todo> ExecuteAsync(GetTodoCommand command, CancellationToken ct)
  {

  }
}

// fe_cmd_handler_nores
public sealed class PrintTodoCommandHandler : ICommandHandler<PrintTodoCommand>
{
  public async Task ExecuteAsync(PrintTodoCommand command, CancellationToken ct)
  {

  }
}

// fe_preproc
public sealed class MyRequestLogger<TRequest> : IPreProcessor<TRequest>
{
  public async Task PreProcessAsync(TRequest req, HttpContext ctx, List<ValidationFailure> failures, CancellationToken ct)
  {

  }
}

// fe_postproc
public sealed class MyPostProcessor<TRequest, TResponse> : IPostProcessor<TRequest, TResponse>
{
  public async Task PostProcessAsync(TRequest req, TResponse res, HttpContext ctx, IReadOnlyCollection<ValidationFailure> failures, CancellationToken ct)
  {

  }
}

// fe_global_preproc
public sealed class GlobalPreProcessor : IGlobalPreProcessor
{
  public async Task PreProcessAsync(object req, HttpContext ctx, List<ValidationFailure> failures, CancellationToken ct)
  {

  }
}

// fe_global_postproc
public sealed class GlobalPostProcessor : IGlobalPostProcessor
{
  public async Task PostProcessAsync(object req, object? res, HttpContext ctx, IReadOnlyCollection<ValidationFailure> failures, CancellationToken ct)
  {

  }
}