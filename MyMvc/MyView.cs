using Microsoft.AspNetCore.Http;

public class MyView
{
    private MyModel _model;

    public MyView(MyModel model)
    {
        _model = model;
    }

    public async System.Threading.Tasks.Task Show(HttpContext context)
    {
        await context.Response.WriteAsync($"Hello {_model.Name}");
    }
}