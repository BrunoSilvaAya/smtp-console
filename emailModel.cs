
public class Model
{
    public Header Header { get; set; }
    public Body Body { get; set; }
    public Footer Footer { get; set; }
}

public class Header
{
    public bool IncludeShiftsLogo { get; set; }
}

public class Body
{
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Table> Tables { get; set; }
    public List<Button> Buttons { get; set; }
}

public class Table
{
    public string Title { get; set; }
    public List<Data> Data { get; set; }
}

public class Data
{
    public string Key { get; set; }
    public string Value { get; set; }
}

public class Button
{
    public string Url { get; set; }
    public string Text { get; set; }
    public string BorderColor { get; set; }
    public string BackgroundColor { get; set; }
}

public class Footer
{
    public string FooterText { get; set; }
}
