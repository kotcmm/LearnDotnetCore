public class MyController
{
    public MyView Index()
    {
        MyModel model = new MyModel()
        {
            Name = "I am Home!"
        };
        return new MyView(model);
    }

    public MyView About()
    {
        MyModel model = new MyModel()
        {
            Name = "I am About"
        };
        return new MyView(model);
    }

}